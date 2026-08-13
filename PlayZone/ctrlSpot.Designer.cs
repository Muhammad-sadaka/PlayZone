namespace PlayZone
{
    partial class ctrlSpot
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblSpotName = new System.Windows.Forms.Label();
            this.cbSpotTypes = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.lblSpotNumber = new System.Windows.Forms.Label();
            this.lblOutOfOrder = new System.Windows.Forms.Label();
            this.btnONOFF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(343, 119);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(343, 173);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(85, 30);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lblSpotName
            // 
            this.lblSpotName.AutoSize = true;
            this.lblSpotName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpotName.ForeColor = System.Drawing.Color.White;
            this.lblSpotName.Location = new System.Drawing.Point(3, 3);
            this.lblSpotName.Name = "lblSpotName";
            this.lblSpotName.Size = new System.Drawing.Size(217, 36);
            this.lblSpotName.TabIndex = 3;
            this.lblSpotName.Text = "Un Used Spot";
            // 
            // cbSpotTypes
            // 
            this.cbSpotTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpotTypes.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpotTypes.FormattingEnabled = true;
            this.cbSpotTypes.Location = new System.Drawing.Point(309, 3);
            this.cbSpotTypes.Name = "cbSpotTypes";
            this.cbSpotTypes.Size = new System.Drawing.Size(119, 30);
            this.cbSpotTypes.TabIndex = 4;
            this.cbSpotTypes.SelectedIndexChanged += new System.EventHandler(this.cbSpotTypes_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(3, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 10);
            this.panel1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(148, 260);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(143, 34);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "00:00:00";
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(343, 227);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(85, 30);
            this.btnDetails.TabIndex = 8;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // lblSpotNumber
            // 
            this.lblSpotNumber.AutoSize = true;
            this.lblSpotNumber.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpotNumber.ForeColor = System.Drawing.Color.White;
            this.lblSpotNumber.Location = new System.Drawing.Point(360, 59);
            this.lblSpotNumber.Name = "lblSpotNumber";
            this.lblSpotNumber.Size = new System.Drawing.Size(53, 36);
            this.lblSpotNumber.TabIndex = 9;
            this.lblSpotNumber.Text = "01";
            // 
            // lblOutOfOrder
            // 
            this.lblOutOfOrder.AutoSize = true;
            this.lblOutOfOrder.BackColor = System.Drawing.Color.Black;
            this.lblOutOfOrder.Font = new System.Drawing.Font("Tahoma", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutOfOrder.ForeColor = System.Drawing.Color.Red;
            this.lblOutOfOrder.Location = new System.Drawing.Point(6, 119);
            this.lblOutOfOrder.Name = "lblOutOfOrder";
            this.lblOutOfOrder.Size = new System.Drawing.Size(452, 72);
            this.lblOutOfOrder.TabIndex = 11;
            this.lblOutOfOrder.Text = "Out  Of  Order";
            this.lblOutOfOrder.Visible = false;
            // 
            // btnONOFF
            // 
            this.btnONOFF.BackColor = System.Drawing.Color.Green;
            this.btnONOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnONOFF.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnONOFF.Location = new System.Drawing.Point(3, 260);
            this.btnONOFF.Name = "btnONOFF";
            this.btnONOFF.Size = new System.Drawing.Size(75, 28);
            this.btnONOFF.TabIndex = 12;
            this.btnONOFF.Text = "ON/OFF";
            this.btnONOFF.UseVisualStyleBackColor = false;
            this.btnONOFF.Click += new System.EventHandler(this.btnONOFF_Click);
            // 
            // ctrlSpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnONOFF);
            this.Controls.Add(this.lblOutOfOrder);
            this.Controls.Add(this.lblSpotNumber);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSpotName);
            this.Controls.Add(this.cbSpotTypes);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Name = "ctrlSpot";
            this.Size = new System.Drawing.Size(436, 310);
            this.Load += new System.EventHandler(this.ctrlSpot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblSpotName;
        private System.Windows.Forms.ComboBox cbSpotTypes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label lblSpotNumber;
        private System.Windows.Forms.Label lblOutOfOrder;
        private System.Windows.Forms.Button btnONOFF;
    }
}
