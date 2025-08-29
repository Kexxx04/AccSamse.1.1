namespace AccSamse._1._1.Views
{
    partial class SaleForm
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
            this.groupBoxSaleForm = new System.Windows.Forms.GroupBox();
            this.groupBoxFinishSale = new System.Windows.Forms.GroupBox();
            this.buttonExitSale = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTotalSale = new System.Windows.Forms.TextBox();
            this.labelTotalSale = new System.Windows.Forms.Label();
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.textBoxAmountPayment = new System.Windows.Forms.TextBox();
            this.labelAmountPayment = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodeProduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtotalProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.comboBoxSaller = new System.Windows.Forms.ComboBox();
            this.labelSaller = new System.Windows.Forms.Label();
            this.dateTimePickerDateSale = new System.Windows.Forms.DateTimePicker();
            this.LabelDateSale = new System.Windows.Forms.Label();
            this.labelCodeSale = new System.Windows.Forms.Label();
            this.labelSaleNo = new System.Windows.Forms.Label();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.comboBoxSearchClient = new System.Windows.Forms.ComboBox();
            this.checkBoxMinorAmount = new System.Windows.Forms.CheckBox();
            this.labelClientSearch = new System.Windows.Forms.Label();
            this.groupBoxSaleForm.SuspendLayout();
            this.groupBoxFinishSale.SuspendLayout();
            this.groupBoxPayment.SuspendLayout();
            this.groupBoxProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSaleForm
            // 
            this.groupBoxSaleForm.Controls.Add(this.groupBoxFinishSale);
            this.groupBoxSaleForm.Controls.Add(this.groupBoxPayment);
            this.groupBoxSaleForm.Controls.Add(this.groupBoxProduct);
            this.groupBoxSaleForm.Controls.Add(this.groupBoxClient);
            this.groupBoxSaleForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSaleForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSaleForm.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSaleForm.Name = "groupBoxSaleForm";
            this.groupBoxSaleForm.Size = new System.Drawing.Size(800, 450);
            this.groupBoxSaleForm.TabIndex = 0;
            this.groupBoxSaleForm.TabStop = false;
            this.groupBoxSaleForm.Text = "Sale";
            this.groupBoxSaleForm.Enter += new System.EventHandler(this.groupBoxSaleForm_Enter);
            // 
            // groupBoxFinishSale
            // 
            this.groupBoxFinishSale.Controls.Add(this.buttonExitSale);
            this.groupBoxFinishSale.Controls.Add(this.button1);
            this.groupBoxFinishSale.Controls.Add(this.textBoxTotalSale);
            this.groupBoxFinishSale.Controls.Add(this.labelTotalSale);
            this.groupBoxFinishSale.Location = new System.Drawing.Point(647, 125);
            this.groupBoxFinishSale.Name = "groupBoxFinishSale";
            this.groupBoxFinishSale.Size = new System.Drawing.Size(141, 319);
            this.groupBoxFinishSale.TabIndex = 3;
            this.groupBoxFinishSale.TabStop = false;
            this.groupBoxFinishSale.Text = "FinishSale";
            // 
            // buttonExitSale
            // 
            this.buttonExitSale.Location = new System.Drawing.Point(9, 281);
            this.buttonExitSale.Name = "buttonExitSale";
            this.buttonExitSale.Size = new System.Drawing.Size(121, 26);
            this.buttonExitSale.TabIndex = 7;
            this.buttonExitSale.Text = "Exit";
            this.buttonExitSale.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Finish sale";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxTotalSale
            // 
            this.textBoxTotalSale.Enabled = false;
            this.textBoxTotalSale.Location = new System.Drawing.Point(6, 44);
            this.textBoxTotalSale.Name = "textBoxTotalSale";
            this.textBoxTotalSale.ReadOnly = true;
            this.textBoxTotalSale.Size = new System.Drawing.Size(129, 25);
            this.textBoxTotalSale.TabIndex = 2;
            // 
            // labelTotalSale
            // 
            this.labelTotalSale.AutoSize = true;
            this.labelTotalSale.Location = new System.Drawing.Point(6, 24);
            this.labelTotalSale.Name = "labelTotalSale";
            this.labelTotalSale.Size = new System.Drawing.Size(64, 17);
            this.labelTotalSale.TabIndex = 1;
            this.labelTotalSale.Text = "Total Sale";
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.textBoxAmountPayment);
            this.groupBoxPayment.Controls.Add(this.labelAmountPayment);
            this.groupBoxPayment.Controls.Add(this.comboBoxPaymentMethod);
            this.groupBoxPayment.Controls.Add(this.labelPaymentMethod);
            this.groupBoxPayment.Location = new System.Drawing.Point(13, 384);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(604, 60);
            this.groupBoxPayment.TabIndex = 2;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "Payment";
            // 
            // textBoxAmountPayment
            // 
            this.textBoxAmountPayment.Location = new System.Drawing.Point(334, 24);
            this.textBoxAmountPayment.Name = "textBoxAmountPayment";
            this.textBoxAmountPayment.Size = new System.Drawing.Size(156, 25);
            this.textBoxAmountPayment.TabIndex = 4;
            // 
            // labelAmountPayment
            // 
            this.labelAmountPayment.AutoSize = true;
            this.labelAmountPayment.Location = new System.Drawing.Point(275, 26);
            this.labelAmountPayment.Name = "labelAmountPayment";
            this.labelAmountPayment.Size = new System.Drawing.Size(53, 17);
            this.labelAmountPayment.TabIndex = 6;
            this.labelAmountPayment.Text = "Amount";
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(118, 23);
            this.comboBoxPaymentMethod.MaxDropDownItems = 100;
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(141, 25);
            this.comboBoxPaymentMethod.TabIndex = 5;
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Location = new System.Drawing.Point(6, 26);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(106, 17);
            this.labelPaymentMethod.TabIndex = 0;
            this.labelPaymentMethod.Text = "Payment method";
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Controls.Add(this.groupBox1);
            this.groupBoxProduct.Controls.Add(this.ButtonAddProduct);
            this.groupBoxProduct.Controls.Add(this.dataGridView1);
            this.groupBoxProduct.Controls.Add(this.textBox1);
            this.groupBoxProduct.Controls.Add(this.label1);
            this.groupBoxProduct.Location = new System.Drawing.Point(13, 125);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(604, 259);
            this.groupBoxProduct.TabIndex = 1;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Product";
            this.groupBoxProduct.Enter += new System.EventHandler(this.groupBoxProduct_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(628, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 198);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(324, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 25);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 23);
            this.comboBox1.MaxDropDownItems = 100;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 25);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Payment method";
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Location = new System.Drawing.Point(245, 18);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(28, 23);
            this.ButtonAddProduct.TabIndex = 3;
            this.ButtonAddProduct.Text = "+";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeProduc,
            this.ProductName,
            this.StockProduct,
            this.PriceProduct,
            this.SubtotalProduct,
            this.DeleteProduct});
            this.dataGridView1.Location = new System.Drawing.Point(6, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(593, 190);
            this.dataGridView1.TabIndex = 2;
            // 
            // CodeProduc
            // 
            this.CodeProduc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CodeProduc.HeaderText = "Code";
            this.CodeProduc.Name = "CodeProduc";
            this.CodeProduc.ReadOnly = true;
            this.CodeProduc.Width = 101;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // StockProduct
            // 
            this.StockProduct.HeaderText = "Stock";
            this.StockProduct.Name = "StockProduct";
            this.StockProduct.ReadOnly = true;
            // 
            // PriceProduct
            // 
            this.PriceProduct.HeaderText = "Price";
            this.PriceProduct.Name = "PriceProduct";
            this.PriceProduct.ReadOnly = true;
            // 
            // SubtotalProduct
            // 
            this.SubtotalProduct.HeaderText = "Subtotal";
            this.SubtotalProduct.Name = "SubtotalProduct";
            this.SubtotalProduct.ReadOnly = true;
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.HeaderText = "Delete";
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.ReadOnly = true;
            this.DeleteProduct.Text = "-";
            this.DeleteProduct.Width = 50;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search products";
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.comboBoxSaller);
            this.groupBoxClient.Controls.Add(this.labelSaller);
            this.groupBoxClient.Controls.Add(this.dateTimePickerDateSale);
            this.groupBoxClient.Controls.Add(this.LabelDateSale);
            this.groupBoxClient.Controls.Add(this.labelCodeSale);
            this.groupBoxClient.Controls.Add(this.labelSaleNo);
            this.groupBoxClient.Controls.Add(this.buttonNewClient);
            this.groupBoxClient.Controls.Add(this.comboBoxSearchClient);
            this.groupBoxClient.Controls.Add(this.checkBoxMinorAmount);
            this.groupBoxClient.Controls.Add(this.labelClientSearch);
            this.groupBoxClient.Location = new System.Drawing.Point(12, 19);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(776, 100);
            this.groupBoxClient.TabIndex = 0;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Client-Saller";
            // 
            // comboBoxSaller
            // 
            this.comboBoxSaller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSaller.FormattingEnabled = true;
            this.comboBoxSaller.Location = new System.Drawing.Point(131, 57);
            this.comboBoxSaller.MaxDropDownItems = 100;
            this.comboBoxSaller.Name = "comboBoxSaller";
            this.comboBoxSaller.Size = new System.Drawing.Size(309, 25);
            this.comboBoxSaller.TabIndex = 11;
            // 
            // labelSaller
            // 
            this.labelSaller.AutoSize = true;
            this.labelSaller.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaller.Location = new System.Drawing.Point(43, 59);
            this.labelSaller.Name = "labelSaller";
            this.labelSaller.Size = new System.Drawing.Size(82, 17);
            this.labelSaller.TabIndex = 10;
            this.labelSaller.Text = "Saller search";
            this.labelSaller.Click += new System.EventHandler(this.labelSaller_Click);
            // 
            // dateTimePickerDateSale
            // 
            this.dateTimePickerDateSale.Enabled = false;
            this.dateTimePickerDateSale.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateSale.Location = new System.Drawing.Point(635, 47);
            this.dateTimePickerDateSale.Name = "dateTimePickerDateSale";
            this.dateTimePickerDateSale.Size = new System.Drawing.Size(109, 25);
            this.dateTimePickerDateSale.TabIndex = 9;
            // 
            // LabelDateSale
            // 
            this.LabelDateSale.AutoSize = true;
            this.LabelDateSale.Location = new System.Drawing.Point(594, 51);
            this.LabelDateSale.Name = "LabelDateSale";
            this.LabelDateSale.Size = new System.Drawing.Size(35, 17);
            this.LabelDateSale.TabIndex = 8;
            this.LabelDateSale.Text = "Date";
            // 
            // labelCodeSale
            // 
            this.labelCodeSale.AutoSize = true;
            this.labelCodeSale.Location = new System.Drawing.Point(655, 26);
            this.labelCodeSale.Name = "labelCodeSale";
            this.labelCodeSale.Size = new System.Drawing.Size(62, 17);
            this.labelCodeSale.TabIndex = 7;
            this.labelCodeSale.Text = "S-000123";
            // 
            // labelSaleNo
            // 
            this.labelSaleNo.AutoSize = true;
            this.labelSaleNo.Location = new System.Drawing.Point(594, 26);
            this.labelSaleNo.Name = "labelSaleNo";
            this.labelSaleNo.Size = new System.Drawing.Size(54, 17);
            this.labelSaleNo.TabIndex = 6;
            this.labelSaleNo.Text = "Sale No";
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Location = new System.Drawing.Point(467, 18);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(121, 28);
            this.buttonNewClient.TabIndex = 5;
            this.buttonNewClient.Text = "New client";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            // 
            // comboBoxSearchClient
            // 
            this.comboBoxSearchClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchClient.FormattingEnabled = true;
            this.comboBoxSearchClient.Location = new System.Drawing.Point(131, 18);
            this.comboBoxSearchClient.MaxDropDownItems = 100;
            this.comboBoxSearchClient.Name = "comboBoxSearchClient";
            this.comboBoxSearchClient.Size = new System.Drawing.Size(309, 25);
            this.comboBoxSearchClient.TabIndex = 4;
            // 
            // checkBoxMinorAmount
            // 
            this.checkBoxMinorAmount.AutoSize = true;
            this.checkBoxMinorAmount.Location = new System.Drawing.Point(467, 59);
            this.checkBoxMinorAmount.Name = "checkBoxMinorAmount";
            this.checkBoxMinorAmount.Size = new System.Drawing.Size(110, 21);
            this.checkBoxMinorAmount.TabIndex = 3;
            this.checkBoxMinorAmount.Text = "Minor amount";
            this.checkBoxMinorAmount.UseVisualStyleBackColor = true;
            // 
            // labelClientSearch
            // 
            this.labelClientSearch.AutoSize = true;
            this.labelClientSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientSearch.Location = new System.Drawing.Point(43, 21);
            this.labelClientSearch.Name = "labelClientSearch";
            this.labelClientSearch.Size = new System.Drawing.Size(82, 17);
            this.labelClientSearch.TabIndex = 0;
            this.labelClientSearch.Text = "Client search";
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxSaleForm);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.groupBoxSaleForm.ResumeLayout(false);
            this.groupBoxFinishSale.ResumeLayout(false);
            this.groupBoxFinishSale.PerformLayout();
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSaleForm;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Label labelClientSearch;
        private System.Windows.Forms.CheckBox checkBoxMinorAmount;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.ComboBox comboBoxSearchClient;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateSale;
        private System.Windows.Forms.Label LabelDateSale;
        private System.Windows.Forms.Label labelCodeSale;
        private System.Windows.Forms.Label labelSaleNo;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.ComboBox comboBoxSaller;
        private System.Windows.Forms.Label labelSaller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.Button ButtonAddProduct;
        private System.Windows.Forms.TextBox textBoxAmountPayment;
        private System.Windows.Forms.Label labelAmountPayment;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeProduc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtotalProduct;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxFinishSale;
        private System.Windows.Forms.TextBox textBoxTotalSale;
        private System.Windows.Forms.Label labelTotalSale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonExitSale;
    }
}