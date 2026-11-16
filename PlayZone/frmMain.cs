using PlayZone_Buisness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PlayZone
{
    public partial class frmMain : Form
    {
        private enum enRole { Owner = 1, Admin = 2, Cashier = 3 }

        private readonly clsUser _currentUser;
        private readonly Form? _shiftForm;   // Cashier
        private readonly Form? _loginForm;   // Admin / Owner
        private bool _forceClose = false;    // skips the running-spots check on FormClosing


        public frmMain(Form loginForm, clsUser currentUser) : this(currentUser)
        {
            _loginForm = loginForm;
            LockSpots();
        }

        public frmMain(clsUser currentUser, Form shiftForm) : this(currentUser)
        {
            _shiftForm = shiftForm;
        }

        private frmMain(clsUser currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            this.FormClosing += frmMain_FormClosing;
        }

        // ============ Roles ============
        private bool IsAdminOrOwner =>
            _currentUser.RoleID == (int)enRole.Owner ||
            _currentUser.RoleID == (int)enRole.Admin;

        private ToolStripMenuItem[] AdminOnlyItems => new[]
        {
            usersManagementToolStripMenuItem,
            salesAndIncomeReportsToolStripMenuItem,
            shiftHistoryToolStripMenuItem,
            ReservationsToolStripMenuItem,
            productsToolStripMenuItem,
            managementAssignSpotsToolStripMenuItem,
            spotTypesManagementToolStripMenuItem1
        };

        // ============ Load ============
        private async void frmMain_Load(object sender, EventArgs e)
        {
            if (!EnsureLicensed())
                return;

            if(!IsAdminOrOwner)
               ApplyPermissions();

            clsRole? role = await clsRole.FindByIDAsync(_currentUser.RoleID!);
            cashaierToolStripMenuItem.Text = $"{role?.RoleName ?? "Unknown"}: {_currentUser.Username}";
        }

        private void ApplyPermissions()
        {
            // Cashier (and any unknown role): Open/Close Shift, General Settings, Log Out, Exit only
            foreach (var item in AdminOnlyItems)
                item.Visible = false;

            //openShiftToolStripMenuItem.Enabled = false;
            //closeShiftToolStripMenuItem.Enabled = true;
        }

        void LockSpots()
        {
            //if (IsAdminOrOwner) // cut
            //{
            // Full access. No shift is open yet, so the spots are locked.
            openShiftToolStripMenuItem.Enabled = true;
            closeShiftToolStripMenuItem.Enabled = false;

            foreach (ctrlSpot spot in GetAllSpots())
                spot.LockMode(true);

            //   return;
            // }// cut
        }

        void OpenSpotes()
        {
            openShiftToolStripMenuItem.Enabled = false;
            closeShiftToolStripMenuItem.Enabled = true;
            foreach (ctrlSpot spot in GetAllSpots())
                spot.LockMode(false);
        }

        // Safety net: a cashier can't open admin forms even if an item becomes visible
        private void ShowAdminForm(Form form)
        {
            if (!IsAdminOrOwner)
            {
                form.Dispose();
                MessageBox.Show("You do not have permission to open this section.",
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (form)
                form.ShowDialog();
        }

        // ============ Running spots check ============
        private IEnumerable<ctrlSpot> GetAllSpots() => GetControls<ctrlSpot>(this);

        private static IEnumerable<T> GetControls<T>(Control parent) where T : Control
        {
            foreach (Control c in parent.Controls)
            {
                if (c is T match)
                    yield return match;

                foreach (T child in GetControls<T>(c))
                    yield return child;
            }
        }

        // Returns true (and shows a message) if any spot is running
        private bool BlockIfSpotsRunning(string action)
        {
            int running = GetAllSpots().Count(s => s.IsBusy);
            if (running == 0)
                return false;

            MessageBox.Show(
                $"You cannot {action} while {running} spot(s) are still running.\n" +
                "Please end all running sessions first.",
                "Spots Still Running", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return true;
        }

        private bool EnsureLicensed()
        {
            string key = LicensingHelper.ReadLicenseKey();
            if (LicensingHelper.ValidateActivationKey(key))
                return true;

            MessageBox.Show("This application is not activated on this device.",
                "License Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            using (var frmAct = new frmActivation())
                frmAct.ShowDialog();

            // Re-read the key after the activation form
            key = LicensingHelper.ReadLicenseKey();
            if (LicensingHelper.ValidateActivationKey(key))
                return true;

            _forceClose = true;
            Application.Exit();
            return false;
        }

        // ============ Closing (X button / Alt+F4) ============
        private void frmMain_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (_forceClose || e.CloseReason != CloseReason.UserClosing)
                return;

            if (BlockIfSpotsRunning("close the application"))
                e.Cancel = true;
        }

        // ============ Menu: everyone ============
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BlockIfSpotsRunning("exit"))
                return;

            _forceClose = true;
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BlockIfSpotsRunning("log out"))
                return;

            Form? next = _shiftForm ?? _loginForm;   // cashier -> shift form, admin/owner -> login form

            _forceClose = true;
            this.Close();
            next?.Show();
        }

        private void generalSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var frm = new frmSettings();
            frm.ShowDialog();
        }

        private void openShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var frm = new frmShift(_currentUser, _loginForm,true);
            frm.ShowDialog();
            OpenSpotes();
        }

        private void closeShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BlockIfSpotsRunning("close the shift"))
                return;

            using var frm = new frmCloseShift(0);
            frm.ShowDialog();
        }

        // ============ Menu: Admin / Owner only ============
        private void usersManagementToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowAdminForm(new frmUsersManagement());

        private void salesAndIncomeReportsToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowAdminForm(new frmSalesAndIncomeReport());

        private void shiftHistoryToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowAdminForm(new frmShiftHistory());

        private void ReservationsToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowAdminForm(new frmArchives());

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowAdminForm(new frmProductsManagement());

        private void managementAssignSpotsToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowAdminForm(new frmAssignSpots());

        private void spotTypesManagementToolStripMenuItem1_Click(object sender, EventArgs e)
            => ShowAdminForm(new frmSpotTypesManagement());
    }
}