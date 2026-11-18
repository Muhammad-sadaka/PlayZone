namespace PlayZone
{
    partial class frmArchives
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArchives));
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            dgvArchive = new System.Windows.Forms.DataGridView();
            cmbDeviceType = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            btnShowAll = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvArchive).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(340, 46);
            label1.TabIndex = 21;
            label1.Text = "Reservations Archive";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(12, 111);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(155, 31);
            label3.TabIndex = 30;
            label3.Text = "Filter by Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(64, 64, 64);
            dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new System.Drawing.Point(173, 116);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(371, 34);
            dateTimePicker1.TabIndex = 29;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dgvArchive
            // 
            dgvArchive.AllowUserToAddRows = false;
            dgvArchive.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dgvArchive.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvArchive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvArchive.BackgroundColor = System.Drawing.Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvArchive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvArchive.DefaultCellStyle = dataGridViewCellStyle3;
            dgvArchive.EnableHeadersVisualStyles = false;
            dgvArchive.GridColor = System.Drawing.SystemColors.ScrollBar;
            dgvArchive.Location = new System.Drawing.Point(12, 176);
            dgvArchive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvArchive.Name = "dgvArchive";
            dgvArchive.ReadOnly = true;
            dgvArchive.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvArchive.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvArchive.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            dgvArchive.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvArchive.RowTemplate.Height = 26;
            dgvArchive.Size = new System.Drawing.Size(1400, 559);
            dgvArchive.TabIndex = 31;
            // 
            // cmbDeviceType
            // 
            cmbDeviceType.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            cmbDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbDeviceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbDeviceType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmbDeviceType.ForeColor = System.Drawing.Color.White;
            cmbDeviceType.FormattingEnabled = true;
            cmbDeviceType.Location = new System.Drawing.Point(847, 116);
            cmbDeviceType.Name = "cmbDeviceType";
            cmbDeviceType.Size = new System.Drawing.Size(371, 39);
            cmbDeviceType.TabIndex = 32;
            cmbDeviceType.SelectedIndexChanged += cmbDeviceType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(612, 116);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(229, 31);
            label2.TabIndex = 33;
            label2.Text = "Filter by Device Type:";
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = System.Drawing.Color.FromArgb(50, 131, 255);
            btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShowAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnShowAll.ForeColor = System.Drawing.Color.White;
            btnShowAll.Location = new System.Drawing.Point(1281, 116);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new System.Drawing.Size(131, 39);
            btnShowAll.TabIndex = 34;
            btnShowAll.Text = "Show all";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(1281, 742);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(131, 39);
            btnClose.TabIndex = 35;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(12, 55);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(287, 28);
            label4.TabIndex = 36;
            label4.Text = " History of all completed sessions";
            // 
            // frmArchives
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            ClientSize = new System.Drawing.Size(1424, 791);
            Controls.Add(label4);
            Controls.Add(btnClose);
            Controls.Add(btnShowAll);
            Controls.Add(label2);
            Controls.Add(cmbDeviceType);
            Controls.Add(dgvArchive);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmArchives";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Reservations Archive";
            Load += frmArchives_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArchive).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvArchive;
        private System.Windows.Forms.ComboBox cmbDeviceType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
    }
}