namespace PlayZone
{
    partial class frmSpotTypesManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpotTypesManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnAddNew = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            dgvSpotTypes = new System.Windows.Forms.DataGridView();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSpotTypes).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { addNewToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(167, 100);
            // 
            // addNewToolStripMenuItem
            // 
            addNewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            addNewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            addNewToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("addNewToolStripMenuItem.Image");
            addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            addNewToolStripMenuItem.Size = new System.Drawing.Size(166, 32);
            addNewToolStripMenuItem.Text = "Add New";
            addNewToolStripMenuItem.Click += addNewToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            updateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            updateToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("updateToolStripMenuItem.Image");
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new System.Drawing.Size(166, 32);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
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
            // btnAddNew
            // 
            btnAddNew.BackColor = System.Drawing.Color.FromArgb(50, 131, 255);
            btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddNew.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAddNew.ForeColor = System.Drawing.Color.White;
            btnAddNew.Location = new System.Drawing.Point(310, 112);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new System.Drawing.Size(243, 41);
            btnAddNew.TabIndex = 24;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(22, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(218, 46);
            label1.TabIndex = 26;
            label1.Text = "Device Types";
            // 
            // dgvSpotTypes
            // 
            dgvSpotTypes.AllowUserToAddRows = false;
            dgvSpotTypes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dgvSpotTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSpotTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSpotTypes.BackgroundColor = System.Drawing.Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvSpotTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSpotTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSpotTypes.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvSpotTypes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSpotTypes.EnableHeadersVisualStyles = false;
            dgvSpotTypes.GridColor = System.Drawing.SystemColors.ScrollBar;
            dgvSpotTypes.Location = new System.Drawing.Point(12, 169);
            dgvSpotTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvSpotTypes.Name = "dgvSpotTypes";
            dgvSpotTypes.ReadOnly = true;
            dgvSpotTypes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvSpotTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvSpotTypes.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            dgvSpotTypes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvSpotTypes.RowTemplate.Height = 26;
            dgvSpotTypes.Size = new System.Drawing.Size(541, 449);
            dgvSpotTypes.TabIndex = 27;
            dgvSpotTypes.CellContentClick += dgvSpotTypes_CellContentClick;
            // 
            // frmSpotTypesManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            ClientSize = new System.Drawing.Size(565, 631);
            Controls.Add(dgvSpotTypes);
            Controls.Add(label1);
            Controls.Add(btnAddNew);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmSpotTypesManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Spot Types Management";
            Load += frmSpotTypesManagement_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSpotTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvSpotTypes;
    }
}