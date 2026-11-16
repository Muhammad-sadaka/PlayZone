namespace PlayZone
{
    partial class frmAddUpdateProduct
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
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tbProductName = new System.Windows.Forms.TextBox();
            tbPrice = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            tbQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(23, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(292, 46);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Add New Product";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = System.Drawing.Color.White;
            lblSubtitle.Location = new System.Drawing.Point(23, 65);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(190, 31);
            lblSubtitle.TabIndex = 15;
            lblSubtitle.Text = "Enter the product ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(23, 130);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(161, 31);
            label6.TabIndex = 17;
            label6.Text = "Product Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(23, 236);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 31);
            label1.TabIndex = 18;
            label1.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(23, 305);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(225, 31);
            label3.TabIndex = 19;
            label3.Text = "Initial Stock Quantity";
            // 
            // tbProductName
            // 
            tbProductName.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            tbProductName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbProductName.ForeColor = System.Drawing.Color.White;
            tbProductName.Location = new System.Drawing.Point(23, 164);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new System.Drawing.Size(480, 38);
            tbProductName.TabIndex = 20;
            // 
            // tbPrice
            // 
            tbPrice.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            tbPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbPrice.ForeColor = System.Drawing.Color.White;
            tbPrice.Location = new System.Drawing.Point(313, 233);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new System.Drawing.Size(190, 38);
            tbPrice.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(51, 131, 255);
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(197, 397);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(158, 41);
            btnSave.TabIndex = 24;
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
            btnCancel.Location = new System.Drawing.Point(361, 397);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(158, 41);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // tbQuantity
            // 
            tbQuantity.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbQuantity.ForeColor = System.Drawing.Color.White;
            tbQuantity.Location = new System.Drawing.Point(315, 302);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new System.Drawing.Size(188, 38);
            tbQuantity.TabIndex = 48;
            tbQuantity.Text = "0.00";
            // 
            // frmAddUpdateProduct
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            ClientSize = new System.Drawing.Size(531, 450);
            Controls.Add(tbQuantity);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(tbPrice);
            Controls.Add(tbProductName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "frmAddUpdateProduct";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Add/Edit Product";
            Load += frmAddUpdateProduct_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbQuantity;
    }
}