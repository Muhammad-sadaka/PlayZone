namespace PlayZone
{
    partial class ctrlSpot
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlSpot));
            btnStart = new System.Windows.Forms.Button();
            btnEnd = new System.Windows.Forms.Button();
            lblSpotType = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTimer = new System.Windows.Forms.Label();
            lblSpotName = new System.Windows.Forms.Label();
            lblDot = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            lblPlayerName = new System.Windows.Forms.Label();
            lblPrice = new System.Windows.Forms.Label();
            btnDetatils = new System.Windows.Forms.Button();
            lblStarted = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            btnPause = new System.Windows.Forms.Button();
            lblOutOfOrder = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnStart.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            btnStart.Image = (System.Drawing.Image)resources.GetObject("btnStart.Image");
            btnStart.Location = new System.Drawing.Point(14, 56);
            btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(55, 40);
            btnStart.TabIndex = 0;
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnEnd.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            btnEnd.Image = (System.Drawing.Image)resources.GetObject("btnEnd.Image");
            btnEnd.Location = new System.Drawing.Point(86, 57);
            btnEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new System.Drawing.Size(55, 39);
            btnEnd.TabIndex = 2;
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // lblSpotType
            // 
            lblSpotType.AutoSize = true;
            lblSpotType.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSpotType.ForeColor = System.Drawing.Color.White;
            lblSpotType.Location = new System.Drawing.Point(8, 0);
            lblSpotType.Name = "lblSpotType";
            lblSpotType.Size = new System.Drawing.Size(163, 34);
            lblSpotType.TabIndex = 3;
            lblSpotType.Text = "SpotName";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(3, 53);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(333, 171);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.ForestGreen;
            panel1.Location = new System.Drawing.Point(3, 103);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(356, 10);
            panel1.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblTimer.ForeColor = System.Drawing.Color.ForestGreen;
            lblTimer.Location = new System.Drawing.Point(219, 55);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new System.Drawing.Size(125, 34);
            lblTimer.TabIndex = 7;
            lblTimer.Text = "00:00:00";
            // 
            // lblSpotName
            // 
            lblSpotName.AutoSize = true;
            lblSpotName.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSpotName.ForeColor = System.Drawing.Color.White;
            lblSpotName.Location = new System.Drawing.Point(259, 0);
            lblSpotName.Name = "lblSpotName";
            lblSpotName.Size = new System.Drawing.Size(51, 34);
            lblSpotName.TabIndex = 9;
            lblSpotName.Text = "01";
            // 
            // lblDot
            // 
            lblDot.AutoSize = true;
            lblDot.Font = new System.Drawing.Font("Tahoma", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDot.ForeColor = System.Drawing.Color.ForestGreen;
            lblDot.Location = new System.Drawing.Point(301, -6);
            lblDot.Name = "lblDot";
            lblDot.Size = new System.Drawing.Size(40, 41);
            lblDot.TabIndex = 13;
            lblDot.Text = "•";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            panel2.Controls.Add(lblDot);
            panel2.Controls.Add(lblSpotType);
            panel2.Controls.Add(lblSpotName);
            panel2.Location = new System.Drawing.Point(-8, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(356, 46);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            panel3.Controls.Add(lblPlayerName);
            panel3.Controls.Add(lblPrice);
            panel3.Controls.Add(btnDetatils);
            panel3.Controls.Add(lblTimer);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(btnEnd);
            panel3.Controls.Add(lblStarted);
            panel3.Controls.Add(lblStatus);
            panel3.Controls.Add(btnStart);
            panel3.Controls.Add(btnPause);
            panel3.Location = new System.Drawing.Point(-8, 231);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(356, 138);
            panel3.TabIndex = 15;
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPlayerName.ForeColor = System.Drawing.Color.White;
            lblPlayerName.Location = new System.Drawing.Point(194, 0);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new System.Drawing.Size(131, 28);
            lblPlayerName.TabIndex = 18;
            lblPlayerName.Text = "Muhammad";
            lblPlayerName.Visible = false;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPrice.ForeColor = System.Drawing.Color.White;
            lblPrice.Location = new System.Drawing.Point(219, 32);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(91, 23);
            lblPrice.TabIndex = 10;
            lblPrice.Text = "5.00 / hour";
            // 
            // btnDetatils
            // 
            btnDetatils.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnDetatils.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            btnDetatils.Image = (System.Drawing.Image)resources.GetObject("btnDetatils.Image");
            btnDetatils.Location = new System.Drawing.Point(158, 56);
            btnDetatils.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDetatils.Name = "btnDetatils";
            btnDetatils.Size = new System.Drawing.Size(55, 40);
            btnDetatils.TabIndex = 8;
            btnDetatils.UseVisualStyleBackColor = false;
            btnDetatils.Click += btnDetatils_Click;
            // 
            // lblStarted
            // 
            lblStarted.AutoSize = true;
            lblStarted.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblStarted.ForeColor = System.Drawing.Color.White;
            lblStarted.Location = new System.Drawing.Point(8, 30);
            lblStarted.Name = "lblStarted";
            lblStarted.Size = new System.Drawing.Size(148, 23);
            lblStarted.TabIndex = 16;
            lblStarted.Text = "05/11/2026 3:00pm";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblStatus.ForeColor = System.Drawing.Color.ForestGreen;
            lblStatus.Location = new System.Drawing.Point(8, -4);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(124, 34);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Available";
            // 
            // btnPause
            // 
            btnPause.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnPause.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            btnPause.Image = (System.Drawing.Image)resources.GetObject("btnPause.Image");
            btnPause.Location = new System.Drawing.Point(14, 56);
            btnPause.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPause.Name = "btnPause";
            btnPause.Size = new System.Drawing.Size(55, 40);
            btnPause.TabIndex = 17;
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += btnPause_Click;
            // 
            // lblOutOfOrder
            // 
            lblOutOfOrder.AutoSize = true;
            lblOutOfOrder.BackColor = System.Drawing.Color.Transparent;
            lblOutOfOrder.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblOutOfOrder.ForeColor = System.Drawing.Color.FromArgb(220, 70, 70);
            lblOutOfOrder.Location = new System.Drawing.Point(49, -9);
            lblOutOfOrder.Name = "lblOutOfOrder";
            lblOutOfOrder.Size = new System.Drawing.Size(244, 54);
            lblOutOfOrder.TabIndex = 19;
            lblOutOfOrder.Text = "Out of order";
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            panel4.Controls.Add(lblOutOfOrder);
            panel4.Location = new System.Drawing.Point(0, 120);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(344, 45);
            panel4.TabIndex = 20;
            panel4.Visible = false;
            // 
            // ctrlSpot
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Controls.Add(panel4);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ctrlSpot";
            Size = new System.Drawing.Size(339, 352);
            Load += ctrlSpot_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblSpotType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblSpotName;
        private System.Windows.Forms.Label lblDot;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnDetatils;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStarted;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblOutOfOrder;
        private System.Windows.Forms.Panel panel4;
    }
}
