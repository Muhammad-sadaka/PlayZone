using PlayZone_Buisness;
using PlayZone_DataAccessEF.Models;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class ctrlSpot : UserControl
    {
        private enum enState { Available, InUse, Paused, OutOfOrder }
        private enState _State = enState.Available;

        // Used by frmMain to block Exit / Log Out / Close Shift
        public bool IsBusy => _State == enState.InUse || _State == enState.Paused;

        private bool _LockMode = false;

        private string _PlayerName;
        private int? _DurationMinutes;          // null = Open Time
        private int _TotalSeconds = 0;          // actual play seconds (excluding pauses)
        private bool _TimeUpRaised = false;
        private bool _BlinkOn = false;

        private clsSpot _Spot = new clsSpot();
        private clsReservation _Reservation = new clsReservation();

        // Colors
        private static readonly Color AvailableColor = Color.FromArgb(46, 160, 67);
        private static readonly Color InUseColor = Color.FromArgb(47, 128, 237);
        private static readonly Color OutOfOrderColor = Color.FromArgb(220, 70, 70);
        private static readonly Color OpenTimeColor = Color.FromArgb(46, 204, 64);   // green
        private static readonly Color TimedColor = Color.FromArgb(235, 60, 60);      // red
        private static readonly Color PausedColor = Color.FromArgb(240, 165, 0);
        private static readonly Color IdleColor = Color.Gray;

        public ctrlSpot()
        {
            InitializeComponent();
        }

        private async void ctrlSpot_Load(object sender, EventArgs e)
        {
            try
            {
                await SetupAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load spot data:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task SetupAsync()
        {
            lblSpotName.Text = this.Tag?.ToString() ?? string.Empty;

            var spot = await clsSpot.FindBySpotNameAsync(lblSpotName.Text);
            if (spot != null) _Spot = spot;

            lblSpotType.Text = _Spot.SpotType.SpotTypeName;
            lblPrice.Text = $"{_Spot.SpotType.PricePerHour:0.00} / hour";

            // Don't override a running session
            if (!IsBusy)
                _State = _Spot.Active ? enState.Available : enState.OutOfOrder;

            if (!string.IsNullOrEmpty(_Spot.SpotType.ImagePath) && File.Exists(_Spot.SpotType.ImagePath))
                pictureBox1.ImageLocation = _Spot.SpotType.ImagePath;

            _ApplyState();
        }

        // ============ State / Colors ============
        private void _ApplyState()
        {
            Color main = _State switch
            {
                enState.Available => AvailableColor,
                enState.OutOfOrder => OutOfOrderColor,
                _ => InUseColor
            };

            panel1.BackColor = main;
            lblDot.ForeColor = main;
            lblStatus.ForeColor = main;
            lblStatus.Text = _State switch
            {
                enState.Available => "Available",
                enState.OutOfOrder => "Out of Order",
                enState.Paused => "Paused",
                _ => "In Use"
            };

            bool active = IsBusy;

            lblOutOfOrder.Visible = panel4.Visible = _State == enState.OutOfOrder;

            if (active)
            {
                lblPlayerName.Text = _PlayerName;
                lblStarted.Text = $"{_Reservation.StartDate:dd/MM/yyyy hh:mm tt}";
                lblStarted.Visible = true;
            }
            else
            {
                lblStarted.Visible = false;
                lblTimer.Text = "00:00:00";
                lblTimer.ForeColor = IdleColor;
            }

            // Start button doubles as Resume while paused
            btnStart.Visible = _State == enState.Available || _State == enState.Paused;
            btnStart.Text = _State == enState.Paused ? "Resume" : "Start";
            btnPause.Visible = active;
            lblPlayerName.Visible = active;

            // Lock mode: everything is locked, and it survives state changes
            btnStart.Enabled = !_LockMode;
            btnPause.Enabled = _State == enState.InUse && !_LockMode;
            btnEnd.Enabled = active && !_LockMode;
            btnDetatils.Enabled = active && !_LockMode;
        }

        // ============ Start / Resume ============
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_State == enState.Available)
            {
                var frm = new frmSetName(_Spot.SpotType.SpotTypeName, $"Spot {this.Tag}", _Spot.SpotType.PricePerHour.Value);
                frm.DataBack += async (s, name, minutes) => await StartSessionAsync(name, minutes);
                frm.ShowDialog();
            }
            else if (_State == enState.Paused)
            {
                _State = enState.InUse;
                timer1.Start();
                _ApplyState();
                _RefreshTimerLabel();
            }
        }

        private async Task StartSessionAsync(string playerName, int? durationMinutes)
        {
            _Reservation = new clsReservation
            {
                CustomerName = playerName,
                StartDate = DateTime.Now,
                SpotTypeID = _Spot.SpotTypeID
            };

            // The timer starts only if saving succeeds
            if (!await _Reservation.SaveAsync())
            {
                MessageBox.Show("Failed to add the reservation.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Reservation = new clsReservation();
                return;
            }

            _PlayerName = playerName;
            _DurationMinutes = durationMinutes;
            _TotalSeconds = 0;
            _TimeUpRaised = false;

            _State = enState.InUse;
            _ApplyState();
            _RefreshTimerLabel();
            timer1.Start();
        }

        // ============ Pause ============
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (_State != enState.InUse) return;

            _State = enState.Paused;
            timer1.Stop();

            _ApplyState();
            _RefreshTimerLabel();
        }

        // ============ Timer ============
        private void timer1_Tick(object sender, EventArgs e)
        {
            _TotalSeconds++;
            _RefreshTimerLabel();
        }

        private void _RefreshTimerLabel()
        {
            if (!IsBusy) return;

            TimeSpan shown;
            Color color;

            if (_DurationMinutes.HasValue)
            {
                // Timed: countdown + red
                int remaining = Math.Max(0, _DurationMinutes.Value * 60 - _TotalSeconds);
                shown = TimeSpan.FromSeconds(remaining);
                color = TimedColor;

                if (remaining == 0 && _State == enState.InUse)
                {
                    _BlinkOn = !_BlinkOn;
                    color = _BlinkOn ? TimedColor : IdleColor;

                    if (!_TimeUpRaised)
                    {
                        _TimeUpRaised = true;
                        MessageBox.Show($"Time is up for {_PlayerName} (Spot {this.Tag}).", "Time Up",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                // Open Time: count up + green
                shown = TimeSpan.FromSeconds(_TotalSeconds);
                color = OpenTimeColor;
            }

            if (_State == enState.Paused) color = PausedColor;

            lblTimer.Text = $"{(int)shown.TotalHours:00}:{shown.Minutes:00}:{shown.Seconds:00}";
            lblTimer.ForeColor = color;
        }

        // ============ End ============
        private async void btnEnd_Click(object sender, EventArgs e)
        {
            if (!IsBusy) return;

            if (MessageBox.Show($"End session for \"{_PlayerName}\"?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            timer1.Stop();

            _Reservation.EndDate = DateTime.Now;
            _Reservation.Period = TimeSpan.FromSeconds(_TotalSeconds);
            _Reservation.TotalPrice = Math.Round(
                _Spot.SpotType.PricePerHour.Value * (Convert.ToDecimal(_TotalSeconds) / 3600m), 2);
            _Reservation.Mode = clsReservation.enMode.Update;

            if (!await _Reservation.SaveAsync())
            {
                MessageBox.Show("Failed to update the reservation.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Keep the session alive only if it was running before
                if (_State == enState.InUse)
                    timer1.Start();
                return;
            }

            MessageBox.Show(
                $"\nSpot Type: {_Spot.SpotType.SpotTypeName}\nSpot Number: {this.Tag}" +
                $"\nDuration of play: {_Reservation.Period:hh\\:mm\\:ss}" +
                $"\nPrice Per Hour: {_Spot.SpotType.PricePerHour:0.00}" +
                $"\nTotal Price: {_Reservation.TotalPrice:0.00}",
                "Reservation Details", MessageBoxButtons.OK);

            ResetControl();
        }

        private void ResetControl()
        {
            timer1.Stop();
            _PlayerName = null;
            _DurationMinutes = null;
            _TotalSeconds = 0;
            _TimeUpRaised = false;
            _Reservation = new clsReservation();
            _State = _Spot.Active ? enState.Available : enState.OutOfOrder;
            _ApplyState();
        }

        // ============ Details ============
        private void btnDetatils_Click(object sender, EventArgs e)
        {
            DateTime effectiveStart = DateTime.Now - TimeSpan.FromSeconds(_TotalSeconds);

            new frmDetails(_Reservation.ReservationID.Value, _Spot.SpotType.SpotTypeName,
                $"Spot {this.Tag}", _PlayerName, effectiveStart, _Spot.SpotType.PricePerHour.Value)
                .ShowDialog();
        }

        // ============ Out of order / Admin mode ============
        public void SetOutOfOrder(bool value)
        {
            if (IsBusy)
            {
                MessageBox.Show("The spot is busy! End the session first and try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _State = value ? enState.OutOfOrder : enState.Available;
            _ApplyState();
        }

        public void LockMode(bool Lock)
        {
            _LockMode = Lock;
            _ApplyState();
        }
    }
}