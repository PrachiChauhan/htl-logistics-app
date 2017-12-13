namespace LogisticsApp
{
    partial class formMain
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
            this.invoiceNo = new System.Windows.Forms.Label();
            this.InvoiceNoText = new System.Windows.Forms.TextBox();
            this.taxPoint = new System.Windows.Forms.Label();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.vatRegNo = new System.Windows.Forms.Label();
            this.vatRegNoText = new System.Windows.Forms.TextBox();
            this.custList = new System.Windows.Forms.ComboBox();
            this.address = new System.Windows.Forms.Label();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.case1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.lblvat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvat = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnpdf = new System.Windows.Forms.Button();
            this.btncsv = new System.Windows.Forms.Button();
            this.btnaddcustomer = new System.Windows.Forms.Button();
            this.lblpercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceNo
            // 
            this.invoiceNo.AutoSize = true;
            this.invoiceNo.Location = new System.Drawing.Point(18, 20);
            this.invoiceNo.Name = "invoiceNo";
            this.invoiceNo.Size = new System.Drawing.Size(72, 13);
            this.invoiceNo.TabIndex = 0;
            this.invoiceNo.Text = "INVOICE NO:";
            // 
            // InvoiceNoText
            // 
            this.InvoiceNoText.Location = new System.Drawing.Point(200, 20);
            this.InvoiceNoText.Name = "InvoiceNoText";
            this.InvoiceNoText.Size = new System.Drawing.Size(200, 20);
            this.InvoiceNoText.TabIndex = 1;
            // 
            // taxPoint
            // 
            this.taxPoint.AutoSize = true;
            this.taxPoint.Location = new System.Drawing.Point(18, 55);
            this.taxPoint.Name = "taxPoint";
            this.taxPoint.Size = new System.Drawing.Size(67, 13);
            this.taxPoint.TabIndex = 2;
            this.taxPoint.Text = "TAX POINT:";
            // 
            // datepicker
            // 
            this.datepicker.Location = new System.Drawing.Point(200, 55);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(200, 20);
            this.datepicker.TabIndex = 3;
            this.datepicker.Value = new System.DateTime(2017, 11, 29, 16, 29, 49, 0);
            // 
            // vatRegNo
            // 
            this.vatRegNo.AutoSize = true;
            this.vatRegNo.Location = new System.Drawing.Point(18, 90);
            this.vatRegNo.Name = "vatRegNo";
            this.vatRegNo.Size = new System.Drawing.Size(134, 13);
            this.vatRegNo.TabIndex = 4;
            this.vatRegNo.Text = "VAT REGISTRATION NO:";
            // 
            // vatRegNoText
            // 
            this.vatRegNoText.Location = new System.Drawing.Point(200, 90);
            this.vatRegNoText.Name = "vatRegNoText";
            this.vatRegNoText.ReadOnly = true;
            this.vatRegNoText.Size = new System.Drawing.Size(200, 20);
            this.vatRegNoText.TabIndex = 5;
            // 
            // custList
            // 
            this.custList.FormattingEnabled = true;
            this.custList.Location = new System.Drawing.Point(18, 128);
            this.custList.Name = "custList";
            this.custList.Size = new System.Drawing.Size(121, 21);
            this.custList.TabIndex = 6;
            this.custList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(18, 152);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(44, 13);
            this.address.TabIndex = 7;
            this.address.Text = "address";
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Location = new System.Drawing.Point(380, 206);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(50, 13);
            this.lblInvoice.TabIndex = 8;
            this.lblInvoice.Text = "INVOICE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.date,
            this.qty,
            this.case1,
            this.price,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(12, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 221);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // item
            // 
            this.item.HeaderText = "";
            this.item.Items.AddRange(new object[] {
            "HANDLING W/E",
            "DISPATCH W/E",
            "STORAGE W/E",
            "WORKS ORDER",
            "CARRIAGE ERROR"});
            this.item.Name = "item";
            this.item.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // date
            // 
            this.date.HeaderText = "";
            this.date.Name = "date";
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // qty
            // 
            this.qty.HeaderText = "QTY";
            this.qty.Name = "qty";
            // 
            // case1
            // 
            this.case1.HeaderText = "";
            this.case1.Name = "case1";
            // 
            // price
            // 
            this.price.HeaderText = "PRICE";
            this.price.Name = "price";
            // 
            // Total
            // 
            this.Total.HeaderText = "TOTAL";
            this.Total.Name = "Total";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(600, 465);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(64, 13);
            this.lblSubtotal.TabIndex = 36;
            this.lblSubtotal.Text = "SUBTOTAL";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(740, 462);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(111, 20);
            this.txtsubtotal.TabIndex = 37;
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Location = new System.Drawing.Point(600, 487);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(28, 13);
            this.lblvat.TabIndex = 38;
            this.lblvat.Text = "VAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "20.00%";
            // 
            // txtvat
            // 
            this.txtvat.Location = new System.Drawing.Point(740, 484);
            this.txtvat.Name = "txtvat";
            this.txtvat.Size = new System.Drawing.Size(111, 20);
            this.txtvat.TabIndex = 40;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(602, 510);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(42, 13);
            this.lbltotal.TabIndex = 41;
            this.lbltotal.Text = "TOTAL";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(740, 507);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(111, 20);
            this.txttotal.TabIndex = 42;
            // 
            // btnpdf
            // 
            this.btnpdf.Location = new System.Drawing.Point(624, 555);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(93, 44);
            this.btnpdf.TabIndex = 43;
            this.btnpdf.Text = "CREATE PDF";
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // btncsv
            // 
            this.btncsv.Location = new System.Drawing.Point(740, 555);
            this.btncsv.Name = "btncsv";
            this.btncsv.Size = new System.Drawing.Size(93, 44);
            this.btncsv.TabIndex = 44;
            this.btncsv.Text = "CREATE CSV";
            this.btncsv.UseVisualStyleBackColor = true;
            this.btncsv.Click += new System.EventHandler(this.btncsv_Click);
            // 
            // btnaddcustomer
            // 
            this.btnaddcustomer.Location = new System.Drawing.Point(200, 131);
            this.btnaddcustomer.Name = "btnaddcustomer";
            this.btnaddcustomer.Size = new System.Drawing.Size(200, 23);
            this.btnaddcustomer.TabIndex = 45;
            this.btnaddcustomer.Text = "Add Customers";
            this.btnaddcustomer.UseVisualStyleBackColor = true;
            this.btnaddcustomer.Click += new System.EventHandler(this.btnaddcustomer_Click);
            // 
            // lblpercent
            // 
            this.lblpercent.AutoSize = true;
            this.lblpercent.Location = new System.Drawing.Point(161, 131);
            this.lblpercent.Name = "lblpercent";
            this.lblpercent.Size = new System.Drawing.Size(0, 13);
            this.lblpercent.TabIndex = 46;
            // 
            // formMain
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(863, 623);
            this.Controls.Add(this.lblpercent);
            this.Controls.Add(this.btnaddcustomer);
            this.Controls.Add(this.btncsv);
            this.Controls.Add(this.btnpdf);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txtvat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblvat);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblInvoice);
            this.Controls.Add(this.address);
            this.Controls.Add(this.custList);
            this.Controls.Add(this.vatRegNoText);
            this.Controls.Add(this.vatRegNo);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.taxPoint);
            this.Controls.Add(this.InvoiceNoText);
            this.Controls.Add(this.invoiceNo);
            this.Name = "formMain";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label invoiceNo;
        private System.Windows.Forms.TextBox InvoiceNoText;
        private System.Windows.Forms.Label taxPoint;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Label vatRegNo;
        private System.Windows.Forms.TextBox vatRegNoText;
        private System.Windows.Forms.ComboBox custList;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvat;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.DataGridViewComboBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn case1;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btncsv;
        private System.Windows.Forms.Button btnaddcustomer;
        private System.Windows.Forms.Label lblpercent;
    }
}

