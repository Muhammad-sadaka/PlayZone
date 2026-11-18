namespace PlayZone
{
    partial class frmCloseShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCloseShift));
            lblTitle = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            lblClosing = new System.Windows.Forms.Label();
            lblShiftNumber = new System.Windows.Forms.Label();
            lblOpened = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblCashier = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            lblExpectedCash = new System.Windows.Forms.Label();
            lblStartingCash = new System.Windows.Forms.Label();
            lblTotalSales = new System.Windows.Forms.Label();
            lblCafeteriaRevenue = new System.Windows.Forms.Label();
            lblSessionsRevenue = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            label10 = new System.Windows.Forms.Label();
            tbClosingCash = new System.Windows.Forms.TextBox();
            btnCloseShift = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(23, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(311, 46);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Close Current Shift";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(23, 66);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(535, 31);
            label2.TabIndex = 12;
            label2.Text = "Review the summary and count the cash in the drawer";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblClosing);
            panel1.Controls.Add(lblShiftNumber);
            panel1.Controls.Add(lblOpened);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblCashier);
            panel1.Controls.Add(label3);
            panel1.Location = new System.Drawing.Point(23, 123);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(805, 112);
            panel1.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label9.Location = new System.Drawing.Point(416, 60);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(95, 31);
            label9.TabIndex = 17;
            label9.Text = "Closing:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label8.Location = new System.Drawing.Point(416, 11);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(85, 31);
            label8.TabIndex = 16;
            label8.Text = "Shift #:";
            // 
            // lblClosing
            // 
            lblClosing.AutoSize = true;
            lblClosing.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblClosing.ForeColor = System.Drawing.Color.White;
            lblClosing.Location = new System.Drawing.Point(517, 60);
            lblClosing.Name = "lblClosing";
            lblClosing.Size = new System.Drawing.Size(62, 31);
            lblClosing.TabIndex = 15;
            lblClosing.Text = "Date";
            // 
            // lblShiftNumber
            // 
            lblShiftNumber.AutoSize = true;
            lblShiftNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblShiftNumber.ForeColor = System.Drawing.Color.White;
            lblShiftNumber.Location = new System.Drawing.Point(517, 11);
            lblShiftNumber.Name = "lblShiftNumber";
            lblShiftNumber.Size = new System.Drawing.Size(38, 31);
            lblShiftNumber.TabIndex = 14;
            lblShiftNumber.Text = "12";
            // 
            // lblOpened
            // 
            lblOpened.AutoSize = true;
            lblOpened.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblOpened.ForeColor = System.Drawing.Color.White;
            lblOpened.Location = new System.Drawing.Point(123, 60);
            lblOpened.Name = "lblOpened";
            lblOpened.Size = new System.Drawing.Size(62, 31);
            lblOpened.TabIndex = 13;
            lblOpened.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label4.Location = new System.Drawing.Point(16, 60);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(101, 31);
            label4.TabIndex = 12;
            label4.Text = "Opened:";
            // 
            // lblCashier
            // 
            lblCashier.AutoSize = true;
            lblCashier.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCashier.ForeColor = System.Drawing.Color.White;
            lblCashier.Location = new System.Drawing.Point(123, 11);
            lblCashier.Name = "lblCashier";
            lblCashier.Size = new System.Drawing.Size(84, 31);
            lblCashier.TabIndex = 11;
            lblCashier.Text = "Khaled";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label3.Location = new System.Drawing.Point(16, 11);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 31);
            label3.TabIndex = 10;
            label3.Text = "Cashier:";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            panel2.Controls.Add(lblExpectedCash);
            panel2.Controls.Add(lblStartingCash);
            panel2.Controls.Add(lblTotalSales);
            panel2.Controls.Add(lblCafeteriaRevenue);
            panel2.Controls.Add(lblSessionsRevenue);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Location = new System.Drawing.Point(23, 251);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(805, 250);
            panel2.TabIndex = 14;
            // 
            // lblExpectedCash
            // 
            lblExpectedCash.AutoSize = true;
            lblExpectedCash.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblExpectedCash.ForeColor = System.Drawing.Color.FromArgb(50, 131, 255);
            lblExpectedCash.Location = new System.Drawing.Point(416, 208);
            lblExpectedCash.Name = "lblExpectedCash";
            lblExpectedCash.Size = new System.Drawing.Size(67, 31);
            lblExpectedCash.TabIndex = 21;
            lblExpectedCash.Text = "00.00";
            // 
            // lblStartingCash
            // 
            lblStartingCash.AutoSize = true;
            lblStartingCash.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblStartingCash.ForeColor = System.Drawing.Color.White;
            lblStartingCash.Location = new System.Drawing.Point(416, 161);
            lblStartingCash.Name = "lblStartingCash";
            lblStartingCash.Size = new System.Drawing.Size(67, 31);
            lblStartingCash.TabIndex = 20;
            lblStartingCash.Text = "00.00";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalSales.ForeColor = System.Drawing.Color.White;
            lblTotalSales.Location = new System.Drawing.Point(416, 114);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new System.Drawing.Size(72, 31);
            lblTotalSales.TabIndex = 19;
            lblTotalSales.Text = "00.00";
            // 
            // lblCafeteriaRevenue
            // 
            lblCafeteriaRevenue.AutoSize = true;
            lblCafeteriaRevenue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCafeteriaRevenue.ForeColor = System.Drawing.Color.White;
            lblCafeteriaRevenue.Location = new System.Drawing.Point(416, 67);
            lblCafeteriaRevenue.Name = "lblCafeteriaRevenue";
            lblCafeteriaRevenue.Size = new System.Drawing.Size(67, 31);
            lblCafeteriaRevenue.TabIndex = 18;
            lblCafeteriaRevenue.Text = "00.00";
            // 
            // lblSessionsRevenue
            // 
            lblSessionsRevenue.AutoSize = true;
            lblSessionsRevenue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSessionsRevenue.ForeColor = System.Drawing.Color.White;
            lblSessionsRevenue.Location = new System.Drawing.Point(416, 20);
            lblSessionsRevenue.Name = "lblSessionsRevenue";
            lblSessionsRevenue.Size = new System.Drawing.Size(67, 31);
            lblSessionsRevenue.TabIndex = 17;
            lblSessionsRevenue.Text = "00.00";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label15.ForeColor = System.Drawing.Color.FromArgb(50, 131, 255);
            label15.Location = new System.Drawing.Point(16, 208);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(267, 31);
            label15.TabIndex = 16;
            label15.Text = "Expected Cash in Drawer";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label14.ForeColor = System.Drawing.Color.White;
            label14.Location = new System.Drawing.Point(16, 161);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(149, 31);
            label14.TabIndex = 15;
            label14.Text = "Starting Cash";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label13.ForeColor = System.Drawing.Color.White;
            label13.Location = new System.Drawing.Point(16, 114);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(127, 31);
            label13.TabIndex = 14;
            label13.Text = "Total Sales";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.White;
            label12.Location = new System.Drawing.Point(16, 67);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(197, 31);
            label12.TabIndex = 13;
            label12.Text = "Cafeteria Revenue";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.White;
            label11.Location = new System.Drawing.Point(16, 20);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(192, 31);
            label11.TabIndex = 12;
            label11.Text = "Sessions Revenue";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(tbClosingCash);
            panel3.Location = new System.Drawing.Point(23, 521);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(805, 103);
            panel3.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.White;
            label10.Location = new System.Drawing.Point(16, 13);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(414, 31);
            label10.TabIndex = 14;
            label10.Text = "Closing Cash (actual amount in drawer)";
            // 
            // tbClosingCash
            // 
            tbClosingCash.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            tbClosingCash.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbClosingCash.ForeColor = System.Drawing.Color.White;
            tbClosingCash.Location = new System.Drawing.Point(16, 47);
            tbClosingCash.Name = "tbClosingCash";
            tbClosingCash.Size = new System.Drawing.Size(770, 38);
            tbClosingCash.TabIndex = 9;
            // 
            // btnCloseShift
            // 
            btnCloseShift.BackColor = System.Drawing.Color.FromArgb(50, 131, 255);
            btnCloseShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseShift.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCloseShift.ForeColor = System.Drawing.Color.White;
            btnCloseShift.Location = new System.Drawing.Point(534, 644);
            btnCloseShift.Name = "btnCloseShift";
            btnCloseShift.Size = new System.Drawing.Size(147, 41);
            btnCloseShift.TabIndex = 21;
            btnCloseShift.Text = "Close Shift";
            btnCloseShift.UseVisualStyleBackColor = false;
            btnCloseShift.Click += btnCloseShift_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(687, 644);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(147, 41);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmCloseShift
            // 
            AcceptButton = btnCloseShift;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            ClientSize = new System.Drawing.Size(846, 697);
            Controls.Add(btnCloseShift);
            Controls.Add(btnCancel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmCloseShift";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Close Shift";
            Load += frmCloseShift_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblClosing;
        private System.Windows.Forms.Label lblShiftNumber;
        private System.Windows.Forms.Label lblOpened;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCloseShift;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbClosingCash;
        private System.Windows.Forms.Label lblExpectedCash;
        private System.Windows.Forms.Label lblStartingCash;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblCafeteriaRevenue;
        private System.Windows.Forms.Label lblSessionsRevenue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}