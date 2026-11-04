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
            components = new System.ComponentModel.Container();
            btnOK = new System.Windows.Forms.Button();
            tbPlayerName = new System.Windows.Forms.TextBox();
            lblSpotName = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            tbPeriod = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.BackColor = System.Drawing.Color.Green;
            btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnOK.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnOK.ForeColor = System.Drawing.Color.White;
            btnOK.Location = new System.Drawing.Point(344, 184);
            btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(104, 40);
            btnOK.TabIndex = 1;
            btnOK.Text = "Ok";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // tbPlayerName
            // 
            tbPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbPlayerName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tbPlayerName.Location = new System.Drawing.Point(14, 50);
            tbPlayerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbPlayerName.Name = "tbPlayerName";
            tbPlayerName.Size = new System.Drawing.Size(434, 32);
            tbPlayerName.TabIndex = 0;
            tbPlayerName.Validating += tbPlayerName_Validating;
            // 
            // lblSpotName
            // 
            lblSpotName.AutoSize = true;
            lblSpotName.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSpotName.ForeColor = System.Drawing.Color.Black;
            lblSpotName.Location = new System.Drawing.Point(14, 12);
            lblSpotName.Name = "lblSpotName";
            lblSpotName.Size = new System.Drawing.Size(194, 34);
            lblSpotName.TabIndex = 4;
            lblSpotName.Text = "Player Name ?";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.Red;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(231, 184);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(104, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // tbPeriod
            // 
            tbPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbPeriod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tbPeriod.Location = new System.Drawing.Point(14, 135);
            tbPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbPeriod.Name = "tbPeriod";
            tbPeriod.Size = new System.Drawing.Size(434, 32);
            tbPeriod.TabIndex = 6;
            tbPeriod.KeyPress += tbPeriod_KeyPress;
            tbPeriod.Validating += tbPeriod_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(14, 97);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(327, 34);
            label1.TabIndex = 7;
            label1.Text = "Period Per Hour (Optinal)";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dateTimePicker1.Location = new System.Drawing.Point(85, 136);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(363, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // frmSetName
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Silver;
            ClientSize = new System.Drawing.Size(461, 237);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(tbPeriod);
            Controls.Add(btnCancel);
            Controls.Add(lblSpotName);
            Controls.Add(tbPlayerName);
            Controls.Add(btnOK);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmSetName";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Info";
            Load += frmSetName_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Label lblSpotName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}