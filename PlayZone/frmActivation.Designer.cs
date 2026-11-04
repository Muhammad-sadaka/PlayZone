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
            lblMachineId = new System.Windows.Forms.Label();
            txtMachineId = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtEnterKey = new System.Windows.Forms.TextBox();
            btnActivate = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblMachineId
            // 
            lblMachineId.AutoSize = true;
            lblMachineId.Location = new System.Drawing.Point(139, 72);
            lblMachineId.Name = "lblMachineId";
            lblMachineId.Size = new System.Drawing.Size(50, 20);
            lblMachineId.TabIndex = 0;
            lblMachineId.Text = "label1";
            // 
            // txtMachineId
            // 
            txtMachineId.Location = new System.Drawing.Point(263, 72);
            txtMachineId.Multiline = true;
            txtMachineId.Name = "txtMachineId";
            txtMachineId.ReadOnly = true;
            txtMachineId.Size = new System.Drawing.Size(394, 34);
            txtMachineId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(139, 135);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // txtEnterKey
            // 
            txtEnterKey.Location = new System.Drawing.Point(263, 154);
            txtEnterKey.Name = "txtEnterKey";
            txtEnterKey.Size = new System.Drawing.Size(394, 27);
            txtEnterKey.TabIndex = 3;
            // 
            // btnActivate
            // 
            btnActivate.Location = new System.Drawing.Point(646, 286);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new System.Drawing.Size(110, 35);
            btnActivate.TabIndex = 4;
            btnActivate.Text = "Activate";
            btnActivate.UseVisualStyleBackColor = true;
            btnActivate.Click += btnActivate_Click;
            // 
            // frmActivation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(927, 367);
            Controls.Add(btnActivate);
            Controls.Add(txtEnterKey);
            Controls.Add(label2);
            Controls.Add(txtMachineId);
            Controls.Add(lblMachineId);
            Name = "frmActivation";
            Text = "frmActivation";
            Load += frmActivation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMachineId;
        private System.Windows.Forms.TextBox txtMachineId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnterKey;
        private System.Windows.Forms.Button btnActivate;
    }
}