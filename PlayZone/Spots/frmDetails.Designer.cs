namespace PlayZone
{
    partial class frmDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetails));
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label44 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            lblPricePerHour = new System.Windows.Forms.Label();
            lblElapsed = new System.Windows.Forms.Label();
            lblStarted = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblCustomer = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblSpotInfo = new System.Windows.Forms.Label();
            dgvOrders = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            tbPrice = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            nudQuantity = new System.Windows.Forms.NumericUpDown();
            label12 = new System.Windows.Forms.Label();
            tcAddProduct = new System.Windows.Forms.TabControl();
            tpMenu = new System.Windows.Forms.TabPage();
            cbProducts = new System.Windows.Forms.ComboBox();
            label13 = new System.Windows.Forms.Label();
            tpCustom = new System.Windows.Forms.TabPage();
            tbProductName = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            lblProductsTotal = new System.Windows.Forms.Label();
            lblGrandTotal = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            lblPlayingCost = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            tcAddProduct.SuspendLayout();
            tpMenu.SuspendLayout();
            tpCustom.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(23, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 46);
            label1.TabIndex = 28;
            label1.Text = "Details";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            panel1.Controls.Add(label44);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblPricePerHour);
            panel1.Controls.Add(lblElapsed);
            panel1.Controls.Add(lblStarted);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblCustomer);
            panel1.Controls.Add(label3);
            panel1.Location = new System.Drawing.Point(23, 120);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(805, 112);
            panel1.TabIndex = 29;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label44.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label44.Location = new System.Drawing.Point(413, 11);
            label44.Name = "label44";
            label44.Size = new System.Drawing.Size(163, 31);
            label44.TabIndex = 17;
            label44.Text = "Price Per Hour:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label8.Location = new System.Drawing.Point(413, 60);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(155, 31);
            label8.TabIndex = 16;
            label8.Text = "Elapsed Time:";
            // 
            // lblPricePerHour
            // 
            lblPricePerHour.AutoSize = true;
            lblPricePerHour.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPricePerHour.ForeColor = System.Drawing.Color.White;
            lblPricePerHour.Location = new System.Drawing.Point(582, 11);
            lblPricePerHour.Name = "lblPricePerHour";
            lblPricePerHour.Size = new System.Drawing.Size(55, 31);
            lblPricePerHour.TabIndex = 15;
            lblPricePerHour.Text = "7.00";
            // 
            // lblElapsed
            // 
            lblElapsed.AutoSize = true;
            lblElapsed.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblElapsed.ForeColor = System.Drawing.Color.FromArgb(50, 131, 255);
            lblElapsed.Location = new System.Drawing.Point(582, 60);
            lblElapsed.Name = "lblElapsed";
            lblElapsed.Size = new System.Drawing.Size(84, 31);
            lblElapsed.TabIndex = 14;
            lblElapsed.Text = "1:24:36";
            // 
            // lblStarted
            // 
            lblStarted.AutoSize = true;
            lblStarted.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblStarted.ForeColor = System.Drawing.Color.White;
            lblStarted.Location = new System.Drawing.Point(123, 60);
            lblStarted.Name = "lblStarted";
            lblStarted.Size = new System.Drawing.Size(62, 31);
            lblStarted.TabIndex = 13;
            lblStarted.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label4.Location = new System.Drawing.Point(16, 60);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(92, 31);
            label4.TabIndex = 12;
            label4.Text = "Started:";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCustomer.ForeColor = System.Drawing.Color.White;
            lblCustomer.Location = new System.Drawing.Point(132, 11);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new System.Drawing.Size(84, 31);
            lblCustomer.TabIndex = 11;
            lblCustomer.Text = "Khaled";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label3.Location = new System.Drawing.Point(16, 11);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(117, 31);
            label3.TabIndex = 10;
            label3.Text = "Customer:";
            // 
            // lblSpotInfo
            // 
            lblSpotInfo.AutoSize = true;
            lblSpotInfo.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSpotInfo.ForeColor = System.Drawing.Color.White;
            lblSpotInfo.Location = new System.Drawing.Point(23, 65);
            lblSpotInfo.Name = "lblSpotInfo";
            lblSpotInfo.Size = new System.Drawing.Size(216, 31);
            lblSpotInfo.TabIndex = 30;
            lblSpotInfo.Text = " PlayStation - Spot 01";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle3;
            dgvOrders.EnableHeadersVisualStyles = false;
            dgvOrders.GridColor = System.Drawing.SystemColors.ScrollBar;
            dgvOrders.Location = new System.Drawing.Point(23, 280);
            dgvOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            dgvOrders.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvOrders.RowTemplate.Height = 26;
            dgvOrders.Size = new System.Drawing.Size(805, 186);
            dgvOrders.TabIndex = 31;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(23, 245);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(165, 31);
            label2.TabIndex = 32;
            label2.Text = "Current Orders";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            panel2.Controls.Add(tbPrice);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(nudQuantity);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(tcAddProduct);
            panel2.Location = new System.Drawing.Point(23, 486);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(805, 177);
            panel2.TabIndex = 33;
            // 
            // tbPrice
            // 
            tbPrice.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbPrice.ForeColor = System.Drawing.Color.White;
            tbPrice.Location = new System.Drawing.Point(418, 94);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new System.Drawing.Size(132, 38);
            tbPrice.TabIndex = 38;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.FromArgb(50, 131, 255);
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(702, 94);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(101, 39);
            btnAdd.TabIndex = 50;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label7.Location = new System.Drawing.Point(421, 63);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(64, 31);
            label7.TabIndex = 39;
            label7.Text = "Price";
            // 
            // nudQuantity
            // 
            nudQuantity.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            nudQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nudQuantity.ForeColor = System.Drawing.Color.White;
            nudQuantity.Location = new System.Drawing.Point(560, 98);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new System.Drawing.Size(136, 34);
            nudQuantity.TabIndex = 48;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label12.Location = new System.Drawing.Point(563, 63);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(102, 31);
            label12.TabIndex = 49;
            label12.Text = "Quantity";
            // 
            // tcAddProduct
            // 
            tcAddProduct.Controls.Add(tpMenu);
            tcAddProduct.Controls.Add(tpCustom);
            tcAddProduct.Location = new System.Drawing.Point(0, 0);
            tcAddProduct.Name = "tcAddProduct";
            tcAddProduct.SelectedIndex = 0;
            tcAddProduct.Size = new System.Drawing.Size(412, 174);
            tcAddProduct.TabIndex = 35;
            tcAddProduct.SelectedIndexChanged += tcAddProduct_SelectedIndexChanged;
            // 
            // tpMenu
            // 
            tpMenu.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            tpMenu.Controls.Add(cbProducts);
            tpMenu.Controls.Add(label13);
            tpMenu.Location = new System.Drawing.Point(4, 29);
            tpMenu.Name = "tpMenu";
            tpMenu.Padding = new System.Windows.Forms.Padding(3);
            tpMenu.Size = new System.Drawing.Size(404, 141);
            tpMenu.TabIndex = 1;
            tpMenu.Text = "From Menu";
            // 
            // cbProducts
            // 
            cbProducts.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            cbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbProducts.ForeColor = System.Drawing.Color.White;
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new System.Drawing.Point(15, 65);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new System.Drawing.Size(383, 36);
            cbProducts.TabIndex = 46;
            cbProducts.SelectedIndexChanged += cbProducts_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label13.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label13.Location = new System.Drawing.Point(18, 34);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(161, 31);
            label13.TabIndex = 43;
            label13.Text = "Product Name";
            // 
            // tpCustom
            // 
            tpCustom.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            tpCustom.Controls.Add(tbProductName);
            tpCustom.Controls.Add(label5);
            tpCustom.Location = new System.Drawing.Point(4, 29);
            tpCustom.Name = "tpCustom";
            tpCustom.Padding = new System.Windows.Forms.Padding(3);
            tpCustom.Size = new System.Drawing.Size(404, 141);
            tpCustom.TabIndex = 0;
            tpCustom.Text = "Custom Product ";
            // 
            // tbProductName
            // 
            tbProductName.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            tbProductName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbProductName.ForeColor = System.Drawing.Color.White;
            tbProductName.Location = new System.Drawing.Point(15, 65);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new System.Drawing.Size(383, 38);
            tbProductName.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label5.Location = new System.Drawing.Point(18, 34);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(161, 31);
            label5.TabIndex = 36;
            label5.Text = "Product Name";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            panel3.Controls.Add(lblProductsTotal);
            panel3.Controls.Add(lblGrandTotal);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(lblPlayingCost);
            panel3.Location = new System.Drawing.Point(23, 669);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(805, 120);
            panel3.TabIndex = 34;
            // 
            // lblProductsTotal
            // 
            lblProductsTotal.AutoSize = true;
            lblProductsTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblProductsTotal.ForeColor = System.Drawing.Color.White;
            lblProductsTotal.Location = new System.Drawing.Point(671, 43);
            lblProductsTotal.Name = "lblProductsTotal";
            lblProductsTotal.Size = new System.Drawing.Size(55, 31);
            lblProductsTotal.TabIndex = 20;
            lblProductsTotal.Text = "5.50";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(50, 131, 255);
            lblGrandTotal.Location = new System.Drawing.Point(671, 74);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new System.Drawing.Size(83, 38);
            lblGrandTotal.TabIndex = 19;
            lblGrandTotal.Text = "12.50";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label16.ForeColor = System.Drawing.Color.FromArgb(50, 131, 255);
            label16.Location = new System.Drawing.Point(501, 74);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(171, 38);
            label16.TabIndex = 18;
            label16.Text = "Grand Total:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label14.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label14.Location = new System.Drawing.Point(501, 43);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(164, 31);
            label14.TabIndex = 17;
            label14.Text = "Products Total:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label15.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label15.Location = new System.Drawing.Point(520, 12);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(145, 31);
            label15.TabIndex = 16;
            label15.Text = "Playing Cost:";
            // 
            // lblPlayingCost
            // 
            lblPlayingCost.AutoSize = true;
            lblPlayingCost.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPlayingCost.ForeColor = System.Drawing.Color.White;
            lblPlayingCost.Location = new System.Drawing.Point(671, 12);
            lblPlayingCost.Name = "lblPlayingCost";
            lblPlayingCost.Size = new System.Drawing.Size(55, 31);
            lblPlayingCost.TabIndex = 14;
            lblPlayingCost.Text = "7.00";
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(681, 804);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(147, 41);
            btnClose.TabIndex = 35;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // frmDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            ClientSize = new System.Drawing.Size(849, 857);
            Controls.Add(btnClose);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(dgvOrders);
            Controls.Add(lblSpotInfo);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmDetails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Details";
            Load += frmDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            tcAddProduct.ResumeLayout(false);
            tpMenu.ResumeLayout(false);
            tpMenu.PerformLayout();
            tpCustom.ResumeLayout(false);
            tpCustom.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPricePerHour;
        private System.Windows.Forms.Label lblElapsed;
        private System.Windows.Forms.Label lblStarted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSpotInfo;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblPlayingCost;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblProductsTotal;
        private System.Windows.Forms.TabControl tcAddProduct;
        private System.Windows.Forms.TabPage tpMenu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tpCustom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label12;
    }
}