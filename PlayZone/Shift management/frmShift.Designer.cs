namespace PlayZone
{
    partial class frmShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShift));
            panel1 = new System.Windows.Forms.Panel();
            lblDateTimeValue = new System.Windows.Forms.Label();
            lblUsernameValue = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtStartingCash = new System.Windows.Forms.TextBox();
            btnCancel = new System.Windows.Forms.Button();
            btnOpenShift = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            panel1.Controls.Add(lblDateTimeValue);
            panel1.Controls.Add(lblUsernameValue);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new System.Drawing.Point(29, 219);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(493, 126);
            panel1.TabIndex = 0;
            // 
            // lblDateTimeValue
            // 
            lblDateTimeValue.AutoSize = true;
            lblDateTimeValue.ForeColor = System.Drawing.Color.White;
            lblDateTimeValue.Location = new System.Drawing.Point(189, 68);
            lblDateTimeValue.Name = "lblDateTimeValue";
            lblDateTimeValue.Size = new System.Drawing.Size(62, 31);
            lblDateTimeValue.TabIndex = 6;
            lblDateTimeValue.Text = "Date";
            // 
            // lblUsernameValue
            // 
            lblUsernameValue.AutoSize = true;
            lblUsernameValue.ForeColor = System.Drawing.Color.White;
            lblUsernameValue.Location = new System.Drawing.Point(189, 19);
            lblUsernameValue.Name = "lblUsernameValue";
            lblUsernameValue.Size = new System.Drawing.Size(117, 31);
            lblUsernameValue.TabIndex = 5;
            lblUsernameValue.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(18, 68);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(122, 31);
            label4.TabIndex = 4;
            label4.Text = "Start Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(18, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 31);
            label3.TabIndex = 3;
            label3.Text = "Cashier:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(139, 122);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(265, 46);
            label1.TabIndex = 1;
            label1.Text = "Open New Shift";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(73, 168);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(406, 31);
            label2.TabIndex = 2;
            label2.Text = "Enter the opening cash to start your shift";
            // 
            // txtStartingCash
            // 
            txtStartingCash.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            txtStartingCash.ForeColor = System.Drawing.Color.White;
            txtStartingCash.Location = new System.Drawing.Point(73, 405);
            txtStartingCash.Name = "txtStartingCash";
            txtStartingCash.Size = new System.Drawing.Size(449, 38);
            txtStartingCash.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(29, 551);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(493, 42);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOpenShift
            // 
            btnOpenShift.BackColor = System.Drawing.Color.FromArgb(50, 131, 255);
            btnOpenShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenShift.ForeColor = System.Drawing.Color.White;
            btnOpenShift.Location = new System.Drawing.Point(29, 492);
            btnOpenShift.Name = "btnOpenShift";
            btnOpenShift.Size = new System.Drawing.Size(493, 42);
            btnOpenShift.TabIndex = 11;
            btnOpenShift.Text = "Open Shift";
            btnOpenShift.UseVisualStyleBackColor = false;
            btnOpenShift.Click += btnOpenShift_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(17, 611);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(510, 23);
            label8.TabIndex = 13;
            label8.Text = " Opening cash must be entered accurately to balance the register";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(222, 634);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(105, 23);
            label9.TabIndex = 14;
            label9.Text = "at shift close";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = System.Drawing.Color.White;
            label10.Location = new System.Drawing.Point(29, 362);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(149, 31);
            label10.TabIndex = 15;
            label10.Text = "Starting Cash";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(238, 42);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(89, 76);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(29, 405);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(38, 38);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // frmShift
            // 
            AcceptButton = btnOpenShift;
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(552, 676);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnCancel);
            Controls.Add(btnOpenShift);
            Controls.Add(txtStartingCash);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5);
            Name = "frmShift";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmShift";
            Load += frmShift_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartingCash;
        private System.Windows.Forms.Label lblDateTimeValue;
        private System.Windows.Forms.Label lblUsernameValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOpenShift;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}