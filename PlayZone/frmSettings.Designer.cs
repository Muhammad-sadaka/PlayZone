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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbSpotTypeName = new System.Windows.Forms.TextBox();
            this.lblSpotName = new System.Windows.Forms.Label();
            this.cbSpotTypes = new System.Windows.Forms.ComboBox();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSpotTypePrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 332);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tbSpotTypeName
            // 
            this.tbSpotTypeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbSpotTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSpotTypeName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpotTypeName.Location = new System.Drawing.Point(12, 119);
            this.tbSpotTypeName.Name = "tbSpotTypeName";
            this.tbSpotTypeName.Size = new System.Drawing.Size(335, 32);
            this.tbSpotTypeName.TabIndex = 7;
            // 
            // lblSpotName
            // 
            this.lblSpotName.AutoSize = true;
            this.lblSpotName.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpotName.ForeColor = System.Drawing.Color.White;
            this.lblSpotName.Location = new System.Drawing.Point(6, 295);
            this.lblSpotName.Name = "lblSpotName";
            this.lblSpotName.Size = new System.Drawing.Size(267, 34);
            this.lblSpotName.TabIndex = 8;
            this.lblSpotName.Text = "Spot Type Image:";
            // 
            // cbSpotTypes
            // 
            this.cbSpotTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbSpotTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpotTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSpotTypes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpotTypes.FormattingEnabled = true;
            this.cbSpotTypes.Location = new System.Drawing.Point(12, 12);
            this.cbSpotTypes.Name = "cbSpotTypes";
            this.cbSpotTypes.Size = new System.Drawing.Size(335, 32);
            this.cbSpotTypes.TabIndex = 9;
            this.cbSpotTypes.SelectedIndexChanged += new System.EventHandler(this.cbSpotTypes_SelectedIndexChanged);
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeImage.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeImage.Location = new System.Drawing.Point(255, 536);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(94, 33);
            this.btnChangeImage.TabIndex = 10;
            this.btnChangeImage.Text = "Change";
            this.btnChangeImage.UseVisualStyleBackColor = false;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Spot Type Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "Price Per Hour:";
            // 
            // tbSpotTypePrice
            // 
            this.tbSpotTypePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbSpotTypePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSpotTypePrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpotTypePrice.Location = new System.Drawing.Point(12, 226);
            this.tbSpotTypePrice.Name = "tbSpotTypePrice";
            this.tbSpotTypePrice.Size = new System.Drawing.Size(335, 32);
            this.tbSpotTypePrice.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(202, 599);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 41);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(69, 599);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 41);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(361, 648);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSpotTypePrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeImage);
            this.Controls.Add(this.cbSpotTypes);
            this.Controls.Add(this.lblSpotName);
            this.Controls.Add(this.tbSpotTypeName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbSpotTypeName;
        private System.Windows.Forms.Label lblSpotName;
        private System.Windows.Forms.ComboBox cbSpotTypes;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSpotTypePrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}