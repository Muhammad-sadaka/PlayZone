namespace PlayZone
{
    partial class frmProductsManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductsManagement));
            dgvProducts = new System.Windows.Forms.DataGridView();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            restockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblTitle = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            btnAddProduct = new System.Windows.Forms.Button();
            lblProducts = new System.Windows.Forms.Label();
            lblLowStock = new System.Windows.Forms.Label();
            lblOutOfStock = new System.Windows.Forms.Label();
            tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = System.Drawing.SystemColors.ScrollBar;
            dgvProducts.Location = new System.Drawing.Point(12, 150);
            dgvProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProducts.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvProducts.RowTemplate.Height = 26;
            dgvProducts.Size = new System.Drawing.Size(882, 518);
            dgvProducts.TabIndex = 32;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { addNewToolStripMenuItem, editToolStripMenuItem, restockToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(167, 132);
            // 
            // addNewToolStripMenuItem
            // 
            addNewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            addNewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            addNewToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("addNewToolStripMenuItem.Image");
            addNewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            addNewToolStripMenuItem.Size = new System.Drawing.Size(166, 32);
            addNewToolStripMenuItem.Text = "Add New";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            editToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(166, 32);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // restockToolStripMenuItem
            // 
            restockToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            restockToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            restockToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("restockToolStripMenuItem.Image");
            restockToolStripMenuItem.Name = "restockToolStripMenuItem";
            restockToolStripMenuItem.Size = new System.Drawing.Size(166, 32);
            restockToolStripMenuItem.Text = "Restock";
            restockToolStripMenuItem.Click += restockToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            deleteToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new System.Drawing.Size(166, 32);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(22, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(370, 46);
            lblTitle.TabIndex = 33;
            lblTitle.Text = "Products Management";
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(747, 687);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(147, 41);
            btnClose.TabIndex = 36;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = System.Drawing.Color.FromArgb(50, 131, 255);
            btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = System.Drawing.Color.White;
            btnAddProduct.Location = new System.Drawing.Point(740, 102);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new System.Drawing.Size(154, 41);
            btnAddProduct.TabIndex = 42;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblProducts.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            lblProducts.Location = new System.Drawing.Point(12, 687);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new System.Drawing.Size(127, 31);
            lblProducts.TabIndex = 43;
            lblProducts.Text = "Products: 8";
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblLowStock.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            lblLowStock.Location = new System.Drawing.Point(244, 687);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new System.Drawing.Size(137, 31);
            lblLowStock.TabIndex = 44;
            lblLowStock.Text = "Low stock: 1";
            // 
            // lblOutOfStock
            // 
            lblOutOfStock.AutoSize = true;
            lblOutOfStock.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblOutOfStock.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            lblOutOfStock.Location = new System.Drawing.Point(486, 687);
            lblOutOfStock.Name = "lblOutOfStock";
            lblOutOfStock.Size = new System.Drawing.Size(160, 31);
            lblOutOfStock.TabIndex = 45;
            lblOutOfStock.Text = "Out of stock: 1";
            // 
            // tbSearch
            // 
            tbSearch.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbSearch.ForeColor = System.Drawing.Color.White;
            tbSearch.Location = new System.Drawing.Point(22, 104);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new System.Drawing.Size(478, 38);
            tbSearch.TabIndex = 47;
            tbSearch.Text = "Search";
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // frmProductsManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            ClientSize = new System.Drawing.Size(906, 740);
            Controls.Add(tbSearch);
            Controls.Add(lblOutOfStock);
            Controls.Add(lblLowStock);
            Controls.Add(lblProducts);
            Controls.Add(btnAddProduct);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Controls.Add(dgvProducts);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmProductsManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Products Management";
            Load += frmProductsManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label lblOutOfStock;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSearch;
    }
}