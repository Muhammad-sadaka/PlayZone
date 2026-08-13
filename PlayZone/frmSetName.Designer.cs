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
            this.btnOK = new System.Windows.Forms.Button();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.lblSpotName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(398, 49);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 32);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPlayerName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayerName.Location = new System.Drawing.Point(12, 49);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(380, 32);
            this.tbPlayerName.TabIndex = 0;
            // 
            // lblSpotName
            // 
            this.lblSpotName.AutoSize = true;
            this.lblSpotName.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpotName.ForeColor = System.Drawing.Color.Black;
            this.lblSpotName.Location = new System.Drawing.Point(12, 10);
            this.lblSpotName.Name = "lblSpotName";
            this.lblSpotName.Size = new System.Drawing.Size(243, 34);
            this.lblSpotName.TabIndex = 4;
            this.lblSpotName.Text = "Set Player Name ?";
            // 
            // frmSetName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(501, 93);
            this.Controls.Add(this.lblSpotName);
            this.Controls.Add(this.tbPlayerName);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSetName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Player Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Label lblSpotName;
    }
}