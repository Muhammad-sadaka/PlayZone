namespace PlayZone
{
    partial class frmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateUser));
            tbUsername = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tbPassword = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            tbConfirmPassword = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            chkManageProducts = new CustomCheckBox();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            chkManageUsers = new CustomCheckBox();
            chkManageShifts = new CustomCheckBox();
            chkViewReports = new CustomCheckBox();
            chkManageSpotTypes = new CustomCheckBox();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            lblInfo = new System.Windows.Forms.Label();
            cmbRole = new System.Windows.Forms.ComboBox();
            panel1 = new System.Windows.Forms.Panel();
            label10 = new System.Windows.Forms.Label();
            chkIsActive = new CustomCheckBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbUsername.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbUsername.ForeColor = System.Drawing.Color.White;
            tbUsername.Location = new System.Drawing.Point(31, 118);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new System.Drawing.Size(478, 38);
            tbUsername.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(22, 84);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(117, 31);
            label3.TabIndex = 9;
            label3.Text = "Username";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(22, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(204, 46);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "User Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(22, 178);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 31);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbPassword.ForeColor = System.Drawing.Color.White;
            tbPassword.Location = new System.Drawing.Point(31, 212);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new System.Drawing.Size(478, 38);
            tbPassword.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(22, 272);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(197, 31);
            label4.TabIndex = 14;
            label4.Text = "Confirm Password";
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbConfirmPassword.ForeColor = System.Drawing.Color.White;
            tbConfirmPassword.Location = new System.Drawing.Point(31, 306);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new System.Drawing.Size(478, 38);
            tbConfirmPassword.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(22, 366);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(58, 31);
            label5.TabIndex = 16;
            label5.Text = "Role";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(chkManageProducts);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(chkManageUsers);
            groupBox1.Controls.Add(chkManageShifts);
            groupBox1.Controls.Add(chkViewReports);
            groupBox1.Controls.Add(chkManageSpotTypes);
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.ForeColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(31, 457);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(478, 187);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Permissions";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(55, 141);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(165, 28);
            label1.TabIndex = 31;
            label1.Text = "Manage Products";
            // 
            // chkManageProducts
            // 
            chkManageProducts.Enabled = false;
            chkManageProducts.FlatAppearance.BorderSize = 0;
            chkManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkManageProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkManageProducts.ForeColor = System.Drawing.Color.Lime;
            chkManageProducts.Location = new System.Drawing.Point(24, 144);
            chkManageProducts.Name = "chkManageProducts";
            chkManageProducts.Size = new System.Drawing.Size(25, 25);
            chkManageProducts.TabIndex = 30;
            chkManageProducts.Text = "customChecddkBox1";
            chkManageProducts.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(55, 96);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(184, 28);
            label9.TabIndex = 29;
            label9.Text = "Manage Spot Types";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(286, 96);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(135, 28);
            label8.TabIndex = 28;
            label8.Text = "Manage Users";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(286, 49);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(125, 28);
            label7.TabIndex = 27;
            label7.Text = "View Reports";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(55, 49);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(136, 28);
            label6.TabIndex = 26;
            label6.Text = "Manage Shifts";
            // 
            // chkManageUsers
            // 
            chkManageUsers.Enabled = false;
            chkManageUsers.FlatAppearance.BorderSize = 0;
            chkManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkManageUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkManageUsers.ForeColor = System.Drawing.Color.Lime;
            chkManageUsers.Location = new System.Drawing.Point(255, 99);
            chkManageUsers.Name = "chkManageUsers";
            chkManageUsers.Size = new System.Drawing.Size(25, 25);
            chkManageUsers.TabIndex = 25;
            chkManageUsers.Text = "customChecddkBox1";
            chkManageUsers.UseVisualStyleBackColor = true;
            // 
            // chkManageShifts
            // 
            chkManageShifts.Enabled = false;
            chkManageShifts.FlatAppearance.BorderSize = 0;
            chkManageShifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkManageShifts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkManageShifts.ForeColor = System.Drawing.Color.Lime;
            chkManageShifts.Location = new System.Drawing.Point(24, 52);
            chkManageShifts.Name = "chkManageShifts";
            chkManageShifts.Size = new System.Drawing.Size(25, 25);
            chkManageShifts.TabIndex = 24;
            chkManageShifts.Text = "customChecddkBox1";
            chkManageShifts.UseVisualStyleBackColor = true;
            // 
            // chkViewReports
            // 
            chkViewReports.Enabled = false;
            chkViewReports.FlatAppearance.BorderSize = 0;
            chkViewReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkViewReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkViewReports.ForeColor = System.Drawing.Color.Lime;
            chkViewReports.Location = new System.Drawing.Point(255, 52);
            chkViewReports.Name = "chkViewReports";
            chkViewReports.Size = new System.Drawing.Size(25, 25);
            chkViewReports.TabIndex = 23;
            chkViewReports.Text = "customChecddkBox1";
            chkViewReports.UseVisualStyleBackColor = true;
            // 
            // chkManageSpotTypes
            // 
            chkManageSpotTypes.Enabled = false;
            chkManageSpotTypes.FlatAppearance.BorderSize = 0;
            chkManageSpotTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkManageSpotTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkManageSpotTypes.ForeColor = System.Drawing.Color.Lime;
            chkManageSpotTypes.Location = new System.Drawing.Point(24, 99);
            chkManageSpotTypes.Name = "chkManageSpotTypes";
            chkManageSpotTypes.Size = new System.Drawing.Size(25, 25);
            chkManageSpotTypes.TabIndex = 22;
            chkManageSpotTypes.Text = "customChecddkBox1";
            chkManageSpotTypes.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(271, 745);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(210, 41);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(50, 131, 255);
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(55, 745);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(210, 41);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblInfo.ForeColor = System.Drawing.Color.Yellow;
            lblInfo.Location = new System.Drawing.Point(40, 699);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new System.Drawing.Size(469, 31);
            lblInfo.TabIndex = 20;
            lblInfo.Text = "Leave password empty to keep the current one";
            lblInfo.Visible = false;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbRole.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmbRole.ForeColor = System.Drawing.Color.White;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new System.Drawing.Point(31, 400);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new System.Drawing.Size(478, 39);
            cmbRole.TabIndex = 21;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(chkIsActive);
            panel1.Location = new System.Drawing.Point(31, 650);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(478, 37);
            panel1.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.White;
            label10.Location = new System.Drawing.Point(55, 3);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(99, 31);
            label10.TabIndex = 24;
            label10.Text = "Is Active";
            // 
            // chkIsActive
            // 
            chkIsActive.FlatAppearance.BorderSize = 0;
            chkIsActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkIsActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkIsActive.ForeColor = System.Drawing.Color.Lime;
            chkIsActive.Location = new System.Drawing.Point(16, 3);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new System.Drawing.Size(33, 28);
            chkIsActive.TabIndex = 23;
            chkIsActive.Text = "customChecddkBox1";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // frmAddUpdateUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            ClientSize = new System.Drawing.Size(544, 797);
            Controls.Add(panel1);
            Controls.Add(cmbRole);
            Controls.Add(lblInfo);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbConfirmPassword);
            Controls.Add(label2);
            Controls.Add(tbPassword);
            Controls.Add(lblTitle);
            Controls.Add(label3);
            Controls.Add(tbUsername);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmAddUpdateUser";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Add/Update User";
            Load += frmAddUpdateUser_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cmbRole;
        private CustomCheckBox chkManageSpotTypes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private CustomCheckBox chkManageUsers;
        private CustomCheckBox chkManageShifts;
        private CustomCheckBox chkViewReports;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private CustomCheckBox chkIsActive;
        private System.Windows.Forms.Label label1;
        private CustomCheckBox chkManageProducts;
    }
}