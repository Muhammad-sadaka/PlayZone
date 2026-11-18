namespace PlayZone
{
    partial class frmSetName
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetName));
            btnStartSession = new System.Windows.Forms.Button();
            tbPlayerName = new System.Windows.Forms.TextBox();
            lblSpotName = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            label2 = new System.Windows.Forms.Label();
            lblSpotInfo = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            lblPrice = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pnlTimed = new System.Windows.Forms.Panel();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            nudMinutes = new System.Windows.Forms.NumericUpDown();
            nudHours = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            rbOpenTime = new System.Windows.Forms.RadioButton();
            rbTimed = new System.Windows.Forms.RadioButton();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            pnlTimed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnStartSession
            // 
            btnStartSession.BackColor = System.Drawing.Color.FromArgb(50, 131, 255);
            btnStartSession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnStartSession.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnStartSession.ForeColor = System.Drawing.Color.Black;
            btnStartSession.Location = new System.Drawing.Point(12, 385);
            btnStartSession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnStartSession.Name = "btnStartSession";
            btnStartSession.Size = new System.Drawing.Size(322, 40);
            btnStartSession.TabIndex = 1;
            btnStartSession.Text = "Start Session";
            btnStartSession.UseVisualStyleBackColor = false;
            btnStartSession.Click += btnStartSession_Click;
            // 
            // tbPlayerName
            // 
            tbPlayerName.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbPlayerName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tbPlayerName.ForeColor = System.Drawing.Color.White;
            tbPlayerName.Location = new System.Drawing.Point(65, 206);
            tbPlayerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbPlayerName.Name = "tbPlayerName";
            tbPlayerName.Size = new System.Drawing.Size(381, 32);
            tbPlayerName.TabIndex = 0;
            tbPlayerName.Validating += tbPlayerName_Validating;
            // 
            // lblSpotName
            // 
            lblSpotName.AutoSize = true;
            lblSpotName.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSpotName.ForeColor = System.Drawing.Color.Black;
            lblSpotName.Location = new System.Drawing.Point(12, 137);
            lblSpotName.Name = "lblSpotName";
            lblSpotName.Size = new System.Drawing.Size(194, 34);
            lblSpotName.TabIndex = 4;
            lblSpotName.Text = "Player Name ?";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(342, 385);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(104, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(12, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(298, 46);
            label2.TabIndex = 9;
            label2.Text = "Start New Session";
            // 
            // lblSpotInfo
            // 
            lblSpotInfo.AutoSize = true;
            lblSpotInfo.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSpotInfo.ForeColor = System.Drawing.Color.White;
            lblSpotInfo.Location = new System.Drawing.Point(21, 55);
            lblSpotInfo.Name = "lblSpotInfo";
            lblSpotInfo.Size = new System.Drawing.Size(210, 31);
            lblSpotInfo.TabIndex = 10;
            lblSpotInfo.Text = "PlayStation - Spot 01";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(label4);
            panel1.Location = new System.Drawing.Point(12, 105);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(434, 49);
            panel1.TabIndex = 11;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPrice.ForeColor = System.Drawing.Color.White;
            lblPrice.Location = new System.Drawing.Point(182, 9);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(123, 31);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "5.00 / hour";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(15, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 31);
            label4.TabIndex = 3;
            label4.Text = "Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 171);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 31);
            label1.TabIndex = 12;
            label1.Text = "Customer Name";
            // 
            // pnlTimed
            // 
            pnlTimed.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            pnlTimed.Controls.Add(label8);
            pnlTimed.Controls.Add(label7);
            pnlTimed.Controls.Add(nudMinutes);
            pnlTimed.Controls.Add(nudHours);
            pnlTimed.Location = new System.Drawing.Point(12, 300);
            pnlTimed.Name = "pnlTimed";
            pnlTimed.Size = new System.Drawing.Size(434, 69);
            pnlTimed.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(214, 14);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(97, 31);
            label8.TabIndex = 20;
            label8.Text = "Minutes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(15, 12);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(74, 31);
            label7.TabIndex = 19;
            label7.Text = "Hours";
            // 
            // nudMinutes
            // 
            nudMinutes.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            nudMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            nudMinutes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudMinutes.ForeColor = System.Drawing.Color.White;
            nudMinutes.Location = new System.Drawing.Point(321, 15);
            nudMinutes.Name = "nudMinutes";
            nudMinutes.Size = new System.Drawing.Size(74, 34);
            nudMinutes.TabIndex = 18;
            // 
            // nudHours
            // 
            nudHours.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            nudHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            nudHours.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudHours.ForeColor = System.Drawing.Color.White;
            nudHours.Location = new System.Drawing.Point(95, 15);
            nudHours.Name = "nudHours";
            nudHours.Size = new System.Drawing.Size(74, 34);
            nudHours.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(12, 259);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(149, 31);
            label6.TabIndex = 14;
            label6.Text = "Session Type:";
            // 
            // rbOpenTime
            // 
            rbOpenTime.AutoSize = true;
            rbOpenTime.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            rbOpenTime.ForeColor = System.Drawing.Color.White;
            rbOpenTime.Location = new System.Drawing.Point(187, 259);
            rbOpenTime.Name = "rbOpenTime";
            rbOpenTime.Size = new System.Drawing.Size(147, 35);
            rbOpenTime.TabIndex = 15;
            rbOpenTime.Text = "Open Time";
            rbOpenTime.UseVisualStyleBackColor = true;
            // 
            // rbTimed
            // 
            rbTimed.AutoSize = true;
            rbTimed.Checked = true;
            rbTimed.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            rbTimed.ForeColor = System.Drawing.Color.White;
            rbTimed.Location = new System.Drawing.Point(343, 259);
            rbTimed.Name = "rbTimed";
            rbTimed.Size = new System.Drawing.Size(99, 35);
            rbTimed.TabIndex = 16;
            rbTimed.TabStop = true;
            rbTimed.Text = "Timed";
            rbTimed.UseVisualStyleBackColor = true;
            rbTimed.CheckedChanged += rbTimed_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(21, 206);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(38, 32);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // frmSetName
            // 
            AcceptButton = btnStartSession;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(12, 12, 12);
            ClientSize = new System.Drawing.Size(458, 436);
            Controls.Add(pictureBox2);
            Controls.Add(rbTimed);
            Controls.Add(rbOpenTime);
            Controls.Add(label6);
            Controls.Add(pnlTimed);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(lblSpotInfo);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(lblSpotName);
            Controls.Add(tbPlayerName);
            Controls.Add(btnStartSession);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmSetName";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Load += frmSetName_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlTimed.ResumeLayout(false);
            pnlTimed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartSession;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Label lblSpotName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSpotInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlTimed;
        private System.Windows.Forms.RadioButton rbTimed;
        private System.Windows.Forms.RadioButton rbOpenTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}