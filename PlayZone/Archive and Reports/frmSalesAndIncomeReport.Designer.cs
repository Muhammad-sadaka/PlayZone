namespace PlayZone
{
    partial class frmSalesAndIncomeReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            label1 = new System.Windows.Forms.Label();
            dgvReports = new System.Windows.Forms.DataGridView();
            btnClose = new System.Windows.Forms.Button();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            btnShowAll = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            lblSessionsRevenue = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            lblCafeteriaRevenue = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            lblTotalIncome = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(368, 46);
            label1.TabIndex = 12;
            label1.Text = "Sales && Income Report";
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dgvReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReports.BackgroundColor = System.Drawing.Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvReports.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReports.EnableHeadersVisualStyles = false;
            dgvReports.GridColor = System.Drawing.SystemColors.ScrollBar;
            dgvReports.Location = new System.Drawing.Point(12, 300);
            dgvReports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvReports.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvReports.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            dgvReports.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvReports.RowTemplate.Height = 26;
            dgvReports.Size = new System.Drawing.Size(1173, 578);
            dgvReports.TabIndex = 24;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(1054, 886);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(131, 39);
            btnClose.TabIndex = 25;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(64, 64, 64);
            dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new System.Drawing.Point(173, 109);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(371, 34);
            dateTimePicker1.TabIndex = 26;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = System.Drawing.Color.FromArgb(50, 131, 255);
            btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShowAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnShowAll.ForeColor = System.Drawing.Color.White;
            btnShowAll.Location = new System.Drawing.Point(1054, 104);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new System.Drawing.Size(131, 39);
            btnShowAll.TabIndex = 27;
            btnShowAll.Text = "Show all";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(12, 104);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(155, 31);
            label3.TabIndex = 28;
            label3.Text = "Filtre by Date:";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            panel1.Controls.Add(lblSessionsRevenue);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(24, 163);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(303, 117);
            panel1.TabIndex = 29;
            // 
            // lblSessionsRevenue
            // 
            lblSessionsRevenue.AutoSize = true;
            lblSessionsRevenue.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSessionsRevenue.ForeColor = System.Drawing.Color.White;
            lblSessionsRevenue.Location = new System.Drawing.Point(17, 59);
            lblSessionsRevenue.Name = "lblSessionsRevenue";
            lblSessionsRevenue.Size = new System.Drawing.Size(149, 46);
            lblSessionsRevenue.TabIndex = 30;
            lblSessionsRevenue.Text = "1850.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(17, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(183, 31);
            label2.TabIndex = 29;
            label2.Text = "Sessions Revenue";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            panel2.Controls.Add(lblCafeteriaRevenue);
            panel2.Controls.Add(label6);
            panel2.Location = new System.Drawing.Point(442, 163);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(303, 117);
            panel2.TabIndex = 31;
            // 
            // lblCafeteriaRevenue
            // 
            lblCafeteriaRevenue.AutoSize = true;
            lblCafeteriaRevenue.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCafeteriaRevenue.ForeColor = System.Drawing.Color.White;
            lblCafeteriaRevenue.Location = new System.Drawing.Point(17, 59);
            lblCafeteriaRevenue.Name = "lblCafeteriaRevenue";
            lblCafeteriaRevenue.Size = new System.Drawing.Size(129, 46);
            lblCafeteriaRevenue.TabIndex = 30;
            lblCafeteriaRevenue.Text = "640.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(17, 16);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(189, 31);
            label6.TabIndex = 29;
            label6.Text = "Cafeteria Revenue";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            panel3.Controls.Add(lblTotalIncome);
            panel3.Controls.Add(label8);
            panel3.Location = new System.Drawing.Point(860, 163);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(303, 117);
            panel3.TabIndex = 31;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalIncome.ForeColor = System.Drawing.Color.FromArgb(50, 131, 255);
            lblTotalIncome.Location = new System.Drawing.Point(17, 59);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new System.Drawing.Size(149, 46);
            lblTotalIncome.TabIndex = 30;
            lblTotalIncome.Text = "2490.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(17, 16);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(135, 31);
            label8.TabIndex = 29;
            label8.Text = "Total Income";
            // 
            // frmSalesAndIncomeReport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            ClientSize = new System.Drawing.Size(1197, 937);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(btnShowAll);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnClose);
            Controls.Add(dgvReports);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmSalesAndIncomeReport";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sales & Income Report";
            Load += frmSalesAndIncomeReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSessionsRevenue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCafeteriaRevenue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label label8;
    }
}