namespace PlayZone
{
    partial class frmRestockProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestockProduct));
            label1 = new System.Windows.Forms.Label();
            lblProductName = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            lblPrice = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblCurrentStock = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lblNewStock = new System.Windows.Forms.Label();
            btnAddToStock = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            nudQuantity = new System.Windows.Forms.NumericUpDown();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(22, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(269, 46);
            label1.TabIndex = 13;
            label1.Text = "Restock Product";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblProductName.ForeColor = System.Drawing.Color.White;
            lblProductName.Location = new System.Drawing.Point(22, 65);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new System.Drawing.Size(63, 31);
            lblProductName.TabIndex = 14;
            lblProductName.Text = " Cola";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblCurrentStock);
            panel1.Controls.Add(label10);
            panel1.Location = new System.Drawing.Point(22, 128);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(485, 112);
            panel1.TabIndex = 15;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPrice.ForeColor = System.Drawing.Color.White;
            lblPrice.Location = new System.Drawing.Point(105, 64);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(55, 31);
            lblPrice.TabIndex = 13;
            lblPrice.Text = "2.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label4.Location = new System.Drawing.Point(30, 64);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 31);
            label4.TabIndex = 12;
            label4.Text = "Price:";
            // 
            // lblCurrentStock
            // 
            lblCurrentStock.AutoSize = true;
            lblCurrentStock.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentStock.ForeColor = System.Drawing.Color.White;
            lblCurrentStock.Location = new System.Drawing.Point(191, 15);
            lblCurrentStock.Name = "lblCurrentStock";
            lblCurrentStock.Size = new System.Drawing.Size(38, 31);
            lblCurrentStock.TabIndex = 11;
            lblCurrentStock.Text = "24";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label10.Location = new System.Drawing.Point(30, 15);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(155, 31);
            label10.TabIndex = 10;
            label10.Text = "Current Stock:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(22, 266);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(178, 31);
            label6.TabIndex = 16;
            label6.Text = "Quantity to Add";
            // 
            // lblNewStock
            // 
            lblNewStock.AutoSize = true;
            lblNewStock.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblNewStock.ForeColor = System.Drawing.Color.ForestGreen;
            lblNewStock.Location = new System.Drawing.Point(29, 337);
            lblNewStock.Name = "lblNewStock";
            lblNewStock.Size = new System.Drawing.Size(198, 38);
            lblNewStock.TabIndex = 18;
            lblNewStock.Text = "New Stock: 74";
            // 
            // btnAddToStock
            // 
            btnAddToStock.BackColor = System.Drawing.Color.ForestGreen;
            btnAddToStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddToStock.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAddToStock.ForeColor = System.Drawing.Color.White;
            btnAddToStock.Location = new System.Drawing.Point(198, 404);
            btnAddToStock.Name = "btnAddToStock";
            btnAddToStock.Size = new System.Drawing.Size(158, 41);
            btnAddToStock.TabIndex = 21;
            btnAddToStock.Text = "Add to Stock";
            btnAddToStock.UseVisualStyleBackColor = false;
            btnAddToStock.Click += btnAddToStock_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(362, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(158, 41);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            nudQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudQuantity.ForeColor = System.Drawing.Color.White;
            nudQuantity.Location = new System.Drawing.Point(317, 267);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new System.Drawing.Size(190, 34);
            nudQuantity.TabIndex = 38;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRestockProduct
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            ClientSize = new System.Drawing.Size(532, 457);
            Controls.Add(nudQuantity);
            Controls.Add(btnAddToStock);
            Controls.Add(btnCancel);
            Controls.Add(lblNewStock);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(lblProductName);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmRestockProduct";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Restock Product";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNewStock;
        private System.Windows.Forms.Button btnAddToStock;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}