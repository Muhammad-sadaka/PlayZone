namespace PlayZone
{
    partial class frmAddUpdateType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateType));
            lblTitle = new System.Windows.Forms.Label();
            txtTypeName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtPricePerHour = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBoxDeviceImage = new System.Windows.Forms.PictureBox();
            btnBrowse = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeviceImage).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(24, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(243, 46);
            lblTitle.TabIndex = 27;
            lblTitle.Text = "Add New Type";
            // 
            // txtTypeName
            // 
            txtTypeName.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            txtTypeName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtTypeName.ForeColor = System.Drawing.Color.Silver;
            txtTypeName.Location = new System.Drawing.Point(24, 144);
            txtTypeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Size = new System.Drawing.Size(458, 35);
            txtTypeName.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(24, 97);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(129, 31);
            label3.TabIndex = 29;
            label3.Text = "Type Name";
            // 
            // txtPricePerHour
            // 
            txtPricePerHour.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            txtPricePerHour.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPricePerHour.ForeColor = System.Drawing.Color.Silver;
            txtPricePerHour.Location = new System.Drawing.Point(283, 208);
            txtPricePerHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPricePerHour.Name = "txtPricePerHour";
            txtPricePerHour.Size = new System.Drawing.Size(197, 35);
            txtPricePerHour.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(24, 208);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 31);
            label1.TabIndex = 31;
            label1.Text = "Price Per Hour";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(24, 267);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(152, 31);
            label2.TabIndex = 32;
            label2.Text = "Device Image";
            // 
            // pictureBoxDeviceImage
            // 
            pictureBoxDeviceImage.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
            pictureBoxDeviceImage.Location = new System.Drawing.Point(24, 310);
            pictureBoxDeviceImage.Name = "pictureBoxDeviceImage";
            pictureBoxDeviceImage.Size = new System.Drawing.Size(333, 171);
            pictureBoxDeviceImage.TabIndex = 33;
            pictureBoxDeviceImage.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBrowse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnBrowse.ForeColor = System.Drawing.Color.White;
            btnBrowse.Location = new System.Drawing.Point(363, 446);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(119, 35);
            btnBrowse.TabIndex = 34;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(50, 131, 255);
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(40, 509);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(210, 41);
            btnSave.TabIndex = 36;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(256, 509);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(210, 41);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddUpdateType
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            ClientSize = new System.Drawing.Size(503, 562);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnBrowse);
            Controls.Add(pictureBoxDeviceImage);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPricePerHour);
            Controls.Add(label3);
            Controls.Add(txtTypeName);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmAddUpdateType";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Add/Update Type";
            Load += frmAddUpdateType_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeviceImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPricePerHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxDeviceImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}