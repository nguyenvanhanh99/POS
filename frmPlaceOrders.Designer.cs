namespace Sales_and_Inventory_System__Gadgets_Shop_
{
    partial class frmPlaceOrders
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlaceOrders));
            this.Label13 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Button7 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtSaleQty = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtAvailableQty = new System.Windows.Forms.TextBox();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Panel2 = new System.Windows.Forms.Panel();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiscountPer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPaymentDue = new System.Windows.Forms.TextBox();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtTaxAmt = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.txtTaxPer = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.NewRecord = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.LightGray;
            this.Label13.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(33, 12);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(62, 22);
            this.Label13.TabIndex = 96;
            this.Label13.Text = "Orders";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(280, 9);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 17);
            this.Label4.TabIndex = 99;
            this.Label4.Text = "Order No.";
            this.Label4.Visible = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(34, 87);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 17);
            this.Label1.TabIndex = 97;
            this.Label1.Text = "Customer ID";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(35, 124);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(98, 17);
            this.Label2.TabIndex = 98;
            this.Label2.Text = "Customer Name";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(35, 54);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(70, 17);
            this.Label3.TabIndex = 100;
            this.Label3.Text = "Order Date";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(159, 121);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(353, 24);
            this.txtCustomerName.TabIndex = 104;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(354, 9);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(185, 24);
            this.txtInvoiceNo.TabIndex = 101;
            this.txtInvoiceNo.Visible = false;
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpInvoiceDate.Enabled = false;
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(159, 53);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(120, 24);
            this.dtpInvoiceDate.TabIndex = 102;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(159, 87);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(185, 24);
            this.txtCustomerID.TabIndex = 103;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtTotalAmount);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Button7);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtProductName);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.txtSaleQty);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.txtPrice);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.txtAvailableQty);
            this.GroupBox1.Location = new System.Drawing.Point(38, 169);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(651, 147);
            this.GroupBox1.TabIndex = 107;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Product Details";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(370, 103);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(132, 24);
            this.txtTotalAmount.TabIndex = 93;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(26, 106);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(57, 17);
            this.Label11.TabIndex = 89;
            this.Label11.Text = "Buy Qty.";
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.Location = new System.Drawing.Point(522, 27);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(87, 23);
            this.Button7.TabIndex = 6;
            this.Button7.Text = "&Add To Cart";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(26, 33);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(87, 17);
            this.Label5.TabIndex = 74;
            this.Label5.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(138, 28);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(364, 24);
            this.txtProductName.TabIndex = 1;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(26, 67);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(61, 17);
            this.Label12.TabIndex = 87;
            this.Label12.Text = "Unit Price";
            // 
            // txtSaleQty
            // 
            this.txtSaleQty.Location = new System.Drawing.Point(138, 99);
            this.txtSaleQty.Name = "txtSaleQty";
            this.txtSaleQty.Size = new System.Drawing.Size(89, 24);
            this.txtSaleQty.TabIndex = 4;
            this.txtSaleQty.TextChanged += new System.EventHandler(this.txtSaleQty_TextChanged);
            this.txtSaleQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaleQty_KeyPress);
            this.txtSaleQty.Validating += new System.ComponentModel.CancelEventHandler(this.txtSaleQty_Validating);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(271, 67);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(81, 17);
            this.Label9.TabIndex = 75;
            this.Label9.Text = "Available Qty";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(138, 64);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(89, 24);
            this.txtPrice.TabIndex = 3;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(271, 106);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(85, 17);
            this.Label10.TabIndex = 76;
            this.Label10.Text = "Total Amount";
            // 
            // txtAvailableQty
            // 
            this.txtAvailableQty.Location = new System.Drawing.Point(370, 64);
            this.txtAvailableQty.Name = "txtAvailableQty";
            this.txtAvailableQty.ReadOnly = true;
            this.txtAvailableQty.Size = new System.Drawing.Size(89, 24);
            this.txtAvailableQty.TabIndex = 5;
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.columnHeader6,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5});
            this.ListView1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(37, 333);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(651, 331);
            this.ListView1.TabIndex = 108;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Product ID";
            this.columnHeader6.Width = 80;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Product Name";
            this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader2.Width = 270;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Unit Price";
            this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader3.Width = 90;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Qty.";
            this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader4.Width = 85;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Total Amount";
            this.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader5.Width = 120;
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.cmbPaymentType);
            this.Panel2.Controls.Add(this.label18);
            this.Panel2.Controls.Add(this.txtDiscountAmount);
            this.Panel2.Controls.Add(this.label17);
            this.Panel2.Controls.Add(this.txtDiscountPer);
            this.Panel2.Controls.Add(this.label8);
            this.Panel2.Controls.Add(this.txtPaymentDue);
            this.Panel2.Controls.Add(this.txtTotalPayment);
            this.Panel2.Controls.Add(this.Label19);
            this.Panel2.Controls.Add(this.payment);
            this.Panel2.Controls.Add(this.txtTotal);
            this.Panel2.Controls.Add(this.Label16);
            this.Panel2.Controls.Add(this.txtTaxAmt);
            this.Panel2.Controls.Add(this.Label24);
            this.Panel2.Controls.Add(this.txtTaxPer);
            this.Panel2.Controls.Add(this.Label15);
            this.Panel2.Controls.Add(this.txtSubTotal);
            this.Panel2.Controls.Add(this.Label14);
            this.Panel2.Location = new System.Drawing.Point(695, 408);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(490, 221);
            this.Panel2.TabIndex = 109;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbPaymentType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "COD",
            "Debit Card",
            "Credit Card",
            "By Check",
            "By DD",
            "Online"});
            this.cmbPaymentType.Location = new System.Drawing.Point(341, 180);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(137, 25);
            this.cmbPaymentType.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(232, 183);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 17);
            this.label18.TabIndex = 120;
            this.label18.Text = "Payment Type";
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(220, 82);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(80, 24);
            this.txtDiscountAmount.TabIndex = 7;
            this.txtDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(174, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 21);
            this.label17.TabIndex = 101;
            this.label17.Text = "%";
            // 
            // txtDiscountPer
            // 
            this.txtDiscountPer.Location = new System.Drawing.Point(116, 83);
            this.txtDiscountPer.Name = "txtDiscountPer";
            this.txtDiscountPer.ReadOnly = true;
            this.txtDiscountPer.Size = new System.Drawing.Size(52, 24);
            this.txtDiscountPer.TabIndex = 1;
            this.txtDiscountPer.Text = "5.78";
            this.txtDiscountPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscountPer.TextChanged += new System.EventHandler(this.txtDiscountPer_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 99;
            this.label8.Text = "Discount";
            // 
            // txtPaymentDue
            // 
            this.txtPaymentDue.Location = new System.Drawing.Point(116, 183);
            this.txtPaymentDue.Name = "txtPaymentDue";
            this.txtPaymentDue.ReadOnly = true;
            this.txtPaymentDue.Size = new System.Drawing.Size(81, 24);
            this.txtPaymentDue.TabIndex = 8;
            this.txtPaymentDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Location = new System.Drawing.Point(116, 150);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.ReadOnly = true;
            this.txtTotalPayment.Size = new System.Drawing.Size(81, 24);
            this.txtTotalPayment.TabIndex = 2;
            this.txtTotalPayment.Text = "0.00";
            this.txtTotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalPayment.TextChanged += new System.EventHandler(this.txtTotalPayment_TextChanged);
            this.txtTotalPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalPayment_KeyPress);
            this.txtTotalPayment.Validating += new System.ComponentModel.CancelEventHandler(this.txtTotalPayment_Validating);
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(19, 183);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(83, 17);
            this.Label19.TabIndex = 96;
            this.Label19.Text = "Payment Due";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(19, 151);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(89, 17);
            this.payment.TabIndex = 95;
            this.payment.Text = "Total Payment";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(116, 117);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(81, 24);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(19, 117);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(75, 17);
            this.Label16.TabIndex = 94;
            this.Label16.Text = "Grand Total";
            // 
            // txtTaxAmt
            // 
            this.txtTaxAmt.Location = new System.Drawing.Point(220, 47);
            this.txtTaxAmt.Name = "txtTaxAmt";
            this.txtTaxAmt.ReadOnly = true;
            this.txtTaxAmt.Size = new System.Drawing.Size(80, 24);
            this.txtTaxAmt.TabIndex = 6;
            this.txtTaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.BackColor = System.Drawing.Color.White;
            this.Label24.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.ForeColor = System.Drawing.Color.Black;
            this.Label24.Location = new System.Drawing.Point(174, 47);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(23, 21);
            this.Label24.TabIndex = 92;
            this.Label24.Text = "%";
            // 
            // txtTaxPer
            // 
            this.txtTaxPer.Location = new System.Drawing.Point(116, 48);
            this.txtTaxPer.Name = "txtTaxPer";
            this.txtTaxPer.ReadOnly = true;
            this.txtTaxPer.Size = new System.Drawing.Size(52, 24);
            this.txtTaxPer.TabIndex = 0;
            this.txtTaxPer.Text = "10.00";
            this.txtTaxPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxPer.TextChanged += new System.EventHandler(this.txtTaxPer_TextChanged);
            this.txtTaxPer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxPer_KeyPress);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(20, 51);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(55, 17);
            this.Label15.TabIndex = 90;
            this.Label15.Text = "VAT+ST";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(116, 14);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(184, 24);
            this.txtSubTotal.TabIndex = 5;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(19, 16);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(61, 17);
            this.Label14.TabIndex = 77;
            this.Label14.Text = "Sub Total";
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(694, 635);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 29);
            this.btnRemove.TabIndex = 110;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(786, 635);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(99, 29);
            this.btnPrint.TabIndex = 111;
            this.btnPrint.Text = "&Print Receipt";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.NewRecord);
            this.Panel1.Controls.Add(this.Save);
            this.Panel1.Location = new System.Drawing.Point(544, 39);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(131, 124);
            this.Panel1.TabIndex = 112;
            // 
            // NewRecord
            // 
            this.NewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRecord.Location = new System.Drawing.Point(14, 8);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(98, 43);
            this.NewRecord.TabIndex = 0;
            this.NewRecord.Text = "&New";
            this.NewRecord.UseVisualStyleBackColor = true;
            this.NewRecord.Click += new System.EventHandler(this.NewRecord_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(14, 62);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(98, 43);
            this.Save.TabIndex = 1;
            this.Save.Text = "&Place Order";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(1037, 72);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 24);
            this.txtProductID.TabIndex = 114;
            this.txtProductID.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(695, 120);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(582, 282);
            this.dataGridView1.TabIndex = 115;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Product ID";
            this.Column8.Name = "Column8";
            this.Column8.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Features";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantity";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProduct);
            this.groupBox2.Location = new System.Drawing.Point(695, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 82);
            this.groupBox2.TabIndex = 116;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by Product Name";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(16, 40);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(284, 24);
            this.txtProduct.TabIndex = 0;
            this.txtProduct.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 117;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // frmPlaceOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1289, 676);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label13);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmPlaceOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtInvoiceNo;
        internal System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtTotalAmount;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtProductName;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtSaleQty;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtAvailableQty;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.TextBox txtPaymentDue;
        internal System.Windows.Forms.TextBox txtTotalPayment;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label payment;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox txtTaxAmt;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox txtTaxPer;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtSubTotal;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button NewRecord;
        internal System.Windows.Forms.Button Save;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        public System.Windows.Forms.TextBox txtCustomerName;
        public System.Windows.Forms.TextBox txtCustomerID;
        public System.Windows.Forms.TextBox txtProductID;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.TextBox txtDiscountAmount;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.TextBox txtDiscountPer;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.ComboBox cmbPaymentType;
    }
}