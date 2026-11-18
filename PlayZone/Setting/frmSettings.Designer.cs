namespace PlayZone
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            panel1 = new System.Windows.Forms.Panel();
            Phone = new System.Windows.Forms.LinkLabel();
            label12 = new System.Windows.Forms.Label();
            klblLinkedIn = new System.Windows.Forms.LinkLabel();
            label11 = new System.Windows.Forms.Label();
            klblGitHub = new System.Windows.Forms.LinkLabel();
            klblEmail = new System.Windows.Forms.LinkLabel();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            panel1.Controls.Add(Phone);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(klblLinkedIn);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(klblGitHub);
            panel1.Controls.Add(klblEmail);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(668, 263);
            panel1.TabIndex = 16;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Font = new System.Drawing.Font("Tahoma", 13.8F);
            Phone.LinkColor = System.Drawing.Color.FromArgb(91, 180, 255);
            Phone.Location = new System.Drawing.Point(82, 154);
            Phone.Name = "Phone";
            Phone.Size = new System.Drawing.Size(220, 28);
            Phone.TabIndex = 206;
            Phone.TabStop = true;
            Phone.Text = "Phone: 0983873645";
            Phone.LinkClicked += Phone_LinkClicked;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            label12.ForeColor = System.Drawing.Color.White;
            label12.Location = new System.Drawing.Point(47, 68);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(192, 31);
            label12.TabIndex = 202;
            label12.Text = "Developer Info:";
            // 
            // klblLinkedIn
            // 
            klblLinkedIn.AutoSize = true;
            klblLinkedIn.Font = new System.Drawing.Font("Tahoma", 13.8F);
            klblLinkedIn.LinkColor = System.Drawing.Color.FromArgb(91, 180, 255);
            klblLinkedIn.Location = new System.Drawing.Point(389, 196);
            klblLinkedIn.Name = "klblLinkedIn";
            klblLinkedIn.Size = new System.Drawing.Size(168, 28);
            klblLinkedIn.TabIndex = 205;
            klblLinkedIn.TabStop = true;
            klblLinkedIn.Text = "LinkedIn Profile";
            klblLinkedIn.LinkClicked += klblLinkedIn_LinkClicked;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Tahoma", 13.8F);
            label11.ForeColor = System.Drawing.Color.White;
            label11.Location = new System.Drawing.Point(188, 112);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(238, 28);
            label11.TabIndex = 201;
            label11.Text = "Muhammad Al-Sadaka";
            // 
            // klblGitHub
            // 
            klblGitHub.AutoSize = true;
            klblGitHub.Font = new System.Drawing.Font("Tahoma", 13.8F);
            klblGitHub.LinkColor = System.Drawing.Color.FromArgb(91, 180, 255);
            klblGitHub.Location = new System.Drawing.Point(389, 154);
            klblGitHub.Name = "klblGitHub";
            klblGitHub.Size = new System.Drawing.Size(194, 28);
            klblGitHub.TabIndex = 204;
            klblGitHub.TabStop = true;
            klblGitHub.Text = "GitHub Repository";
            klblGitHub.LinkClicked += klblGitHub_LinkClicked;
            // 
            // klblEmail
            // 
            klblEmail.AutoSize = true;
            klblEmail.Font = new System.Drawing.Font("Tahoma", 13.8F);
            klblEmail.LinkColor = System.Drawing.Color.FromArgb(91, 180, 255);
            klblEmail.Location = new System.Drawing.Point(82, 196);
            klblEmail.Name = "klblEmail";
            klblEmail.Size = new System.Drawing.Size(103, 28);
            klblEmail.TabIndex = 203;
            klblEmail.TabStop = true;
            klblEmail.Text = "Email Me";
            klblEmail.LinkClicked += klblEmail_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(3, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 46);
            label1.TabIndex = 1;
            label1.Text = "About";
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            ClientSize = new System.Drawing.Size(695, 810);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmSettings";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += frmSettings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel Phone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel klblLinkedIn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel klblGitHub;
        private System.Windows.Forms.LinkLabel klblEmail;
        private System.Windows.Forms.Label label1;
    }
}