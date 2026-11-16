namespace PlayZone
{
    partial class frmActivation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivation));
            lblMachineId = new System.Windows.Forms.Label();
            txtMachineId = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtEnterKey = new System.Windows.Forms.TextBox();
            btnActivate = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            btnExit = new System.Windows.Forms.Button();
            btnCopy = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblMachineId
            // 
            lblMachineId.AutoSize = true;
            lblMachineId.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            lblMachineId.ForeColor = System.Drawing.Color.White;
            lblMachineId.Location = new System.Drawing.Point(22, 122);
            lblMachineId.Name = "lblMachineId";
            lblMachineId.Size = new System.Drawing.Size(130, 31);
            lblMachineId.TabIndex = 0;
            lblMachineId.Text = "Machine ID";
            // 
            // txtMachineId
            // 
            txtMachineId.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            txtMachineId.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            txtMachineId.ForeColor = System.Drawing.Color.White;
            txtMachineId.Location = new System.Drawing.Point(31, 165);
            txtMachineId.Multiline = true;
            txtMachineId.Name = "txtMachineId";
            txtMachineId.ReadOnly = true;
            txtMachineId.Size = new System.Drawing.Size(596, 40);
            txtMachineId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(22, 229);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(159, 31);
            label2.TabIndex = 2;
            label2.Text = "Activation Key";
            // 
            // txtEnterKey
            // 
            txtEnterKey.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            txtEnterKey.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            txtEnterKey.ForeColor = System.Drawing.Color.White;
            txtEnterKey.Location = new System.Drawing.Point(75, 274);
            txtEnterKey.Name = "txtEnterKey";
            txtEnterKey.Size = new System.Drawing.Size(662, 38);
            txtEnterKey.TabIndex = 3;
            // 
            // btnActivate
            // 
            btnActivate.BackColor = System.Drawing.Color.FromArgb(50, 131, 255);
            btnActivate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnActivate.ForeColor = System.Drawing.Color.White;
            btnActivate.Location = new System.Drawing.Point(471, 369);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new System.Drawing.Size(134, 44);
            btnActivate.TabIndex = 4;
            btnActivate.Text = "Activate";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnCopy);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnActivate);
            panel1.Controls.Add(txtEnterKey);
            panel1.Controls.Add(txtMachineId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblMachineId);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(771, 429);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(22, 23);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(57, 53);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(31, 274);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(38, 38);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnExit.ForeColor = System.Drawing.Color.White;
            btnExit.Location = new System.Drawing.Point(611, 369);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(134, 44);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCopy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCopy.ForeColor = System.Drawing.Color.White;
            btnCopy.Image = (System.Drawing.Image)resources.GetObject("btnCopy.Image");
            btnCopy.Location = new System.Drawing.Point(633, 162);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new System.Drawing.Size(104, 43);
            btnCopy.TabIndex = 7;
            btnCopy.Text = "Copy";
            btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(85, 69);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(640, 31);
            label3.TabIndex = 6;
            label3.Text = "Send your Machine ID to the provider to receive an activation key";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(85, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(291, 46);
            label1.TabIndex = 5;
            label1.Text = "Activate Software";
            // 
            // frmActivation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(12, 12, 12);
            ClientSize = new System.Drawing.Size(795, 456);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmActivation";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmActivation";
            Load += frmActivation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblMachineId;
        private System.Windows.Forms.TextBox txtMachineId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnterKey;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}