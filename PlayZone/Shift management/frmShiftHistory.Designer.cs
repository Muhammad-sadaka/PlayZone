namespace PlayZone
{
    partial class frmShiftHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            lblTitle = new System.Windows.Forms.Label();
            cmbCashier = new System.Windows.Forms.ComboBox();
            dgvShiftHistory = new System.Windows.Forms.DataGridView();
            btnShowAll = new System.Windows.Forms.Button();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvShiftHistory).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(16, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(214, 46);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Shift History";
            // 
            // cmbCashier
            // 
            cmbCashier.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            cmbCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbCashier.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmbCashier.ForeColor = System.Drawing.Color.White;
            cmbCashier.FormattingEnabled = true;
            cmbCashier.Location = new System.Drawing.Point(817, 115);
            cmbCashier.Name = "cmbCashier";
            cmbCashier.Size = new System.Drawing.Size(371, 39);
            cmbCashier.TabIndex = 22;
            cmbCashier.SelectedIndexChanged += cmbCashier_SelectedIndexChanged;
            // 
            // dgvShiftHistory
            // 
            dgvShiftHistory.AllowUserToAddRows = false;
            dgvShiftHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dgvShiftHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvShiftHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvShiftHistory.BackgroundColor = System.Drawing.Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvShiftHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvShiftHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvShiftHistory.DefaultCellStyle = dataGridViewCellStyle13;
            dgvShiftHistory.EnableHeadersVisualStyles = false;
            dgvShiftHistory.GridColor = System.Drawing.SystemColors.ScrollBar;
            dgvShiftHistory.Location = new System.Drawing.Point(12, 174);
            dgvShiftHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvShiftHistory.Name = "dgvShiftHistory";
            dgvShiftHistory.ReadOnly = true;
            dgvShiftHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvShiftHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvShiftHistory.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            dgvShiftHistory.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgvShiftHistory.RowTemplate.Height = 26;
            dgvShiftHistory.Size = new System.Drawing.Size(1404, 559);
            dgvShiftHistory.TabIndex = 32;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = System.Drawing.Color.FromArgb(50, 131, 255);
            btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShowAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnShowAll.ForeColor = System.Drawing.Color.White;
            btnShowAll.Location = new System.Drawing.Point(1285, 118);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new System.Drawing.Size(131, 39);
            btnShowAll.TabIndex = 34;
            btnShowAll.Text = "Show all";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(64, 64, 64);
            dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new System.Drawing.Point(173, 118);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(371, 34);
            dateTimePicker1.TabIndex = 33;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(12, 115);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(155, 31);
            label3.TabIndex = 35;
            label3.Text = "Filtre by Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(629, 118);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(182, 31);
            label2.TabIndex = 36;
            label2.Text = "Filter by Cashier:";
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(1285, 745);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(131, 39);
            btnClose.TabIndex = 37;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmShiftHistory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            ClientSize = new System.Drawing.Size(1428, 796);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnShowAll);
            Controls.Add(dateTimePicker1);
            Controls.Add(dgvShiftHistory);
            Controls.Add(cmbCashier);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmShiftHistory";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Shift History";
            Load += frmShiftHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShiftHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbCashier;
        private System.Windows.Forms.DataGridView dgvShiftHistory;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
    }
}