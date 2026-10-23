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
            components = new System.ComponentModel.Container();
            btnStart = new System.Windows.Forms.Button();
            btnEnd = new System.Windows.Forms.Button();
            lblSpotName = new System.Windows.Forms.Label();
            cbSpotTypes = new System.Windows.Forms.ComboBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTimer = new System.Windows.Forms.Label();
            lblSpotNumber = new System.Windows.Forms.Label();
            lblOutOfOrder = new System.Windows.Forms.Label();
            btnONOFF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            btnStart.Location = new System.Drawing.Point(3, 292);
            btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(89, 32);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnEnd
            // 
            btnEnd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            btnEnd.Location = new System.Drawing.Point(129, 292);
            btnEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new System.Drawing.Size(89, 32);
            btnEnd.TabIndex = 2;
            btnEnd.Text = "End";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // lblSpotName
            // 
            lblSpotName.AutoSize = true;
            lblSpotName.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSpotName.ForeColor = System.Drawing.Color.White;
            lblSpotName.Location = new System.Drawing.Point(3, 4);
            lblSpotName.Name = "lblSpotName";
            lblSpotName.Size = new System.Drawing.Size(205, 34);
            lblSpotName.TabIndex = 3;
            lblSpotName.Text = "Un Used Spot";
            // 
            // cbSpotTypes
            // 
            cbSpotTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbSpotTypes.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cbSpotTypes.FormattingEnabled = true;
            cbSpotTypes.Location = new System.Drawing.Point(3, 258);
            cbSpotTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbSpotTypes.Name = "cbSpotTypes";
            cbSpotTypes.Size = new System.Drawing.Size(135, 29);
            cbSpotTypes.TabIndex = 4;
            cbSpotTypes.SelectedIndexChanged += cbSpotTypes_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(3, 48);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(329, 202);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Red;
            panel1.Location = new System.Drawing.Point(3, 332);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(329, 11);
            panel1.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTimer.ForeColor = System.Drawing.Color.White;
            lblTimer.Location = new System.Drawing.Point(189, 254);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new System.Drawing.Size(143, 34);
            lblTimer.TabIndex = 7;
            lblTimer.Text = "00:00:00";
            // 
            // lblSpotNumber
            // 
            lblSpotNumber.AutoSize = true;
            lblSpotNumber.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSpotNumber.ForeColor = System.Drawing.Color.White;
            lblSpotNumber.Location = new System.Drawing.Point(288, 4);
            lblSpotNumber.Name = "lblSpotNumber";
            lblSpotNumber.Size = new System.Drawing.Size(51, 34);
            lblSpotNumber.TabIndex = 9;
            lblSpotNumber.Text = "01";
            // 
            // lblOutOfOrder
            // 
            lblOutOfOrder.AutoSize = true;
            lblOutOfOrder.BackColor = System.Drawing.Color.Black;
            lblOutOfOrder.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            lblOutOfOrder.ForeColor = System.Drawing.Color.Red;
            lblOutOfOrder.Location = new System.Drawing.Point(3, 288);
            lblOutOfOrder.Name = "lblOutOfOrder";
            lblOutOfOrder.Size = new System.Drawing.Size(225, 36);
            lblOutOfOrder.TabIndex = 11;
            lblOutOfOrder.Text = "Out  Of  Order";
            lblOutOfOrder.Visible = false;
            // 
            // btnONOFF
            // 
            btnONOFF.BackColor = System.Drawing.Color.Green;
            btnONOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnONOFF.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnONOFF.Location = new System.Drawing.Point(243, 292);
            btnONOFF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnONOFF.Name = "btnONOFF";
            btnONOFF.Size = new System.Drawing.Size(89, 32);
            btnONOFF.TabIndex = 12;
            btnONOFF.Text = "ON/OFF";
            btnONOFF.UseVisualStyleBackColor = false;
            btnONOFF.Click += btnONOFF_Click;
            // 
            // ctrlSpot
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Controls.Add(btnONOFF);
            Controls.Add(lblOutOfOrder);
            Controls.Add(lblSpotNumber);
            Controls.Add(lblTimer);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblSpotName);
            Controls.Add(cbSpotTypes);
            Controls.Add(btnEnd);
            Controls.Add(btnStart);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ctrlSpot";
            Size = new System.Drawing.Size(339, 352);
            Load += ctrlSpot_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.Label lblSpotNumber;
        private System.Windows.Forms.Label lblOutOfOrder;
        private System.Windows.Forms.Button btnONOFF;
    }
}
