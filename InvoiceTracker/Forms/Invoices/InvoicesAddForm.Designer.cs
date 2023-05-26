namespace InvoiceTracker.Forms.Invoices
{
    partial class InvoicesAddForm
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
            label2 = new Label();
            addInvoiceTabDescription = new TabPage();
            descriptionTextBox = new TextBox();
            addInvoiceTabData = new TabPage();
            cancelEditItemButton = new Button();
            itemVatPNumericUpDown = new NumericUpDown();
            itemPriceNumericUpDown = new NumericUpDown();
            itemQuantityNumericUpDown = new NumericUpDown();
            comboBox1 = new ComboBox();
            invoiceTypeLabel = new Label();
            vendorCountryLabel = new Label();
            vendorCountryTextBox = new TextBox();
            customerCountryLabel = new Label();
            customerCountryTextBox = new TextBox();
            addItemButton = new Button();
            saveItemButton = new Button();
            itemCurrencyLabel = new Label();
            itemVATLabel = new Label();
            itemPriceLabel = new Label();
            itemQuantityLabel = new Label();
            itemNameLabel = new Label();
            itemNameTextBox = new TextBox();
            currencyComboBox = new ComboBox();
            invoiceItemsGridView = new DataGridView();
            currencyLabel = new Label();
            numberLabel = new Label();
            numberTextBox = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            vendorZipCodeTextBox = new TextBox();
            vendorCityTextBox = new TextBox();
            vendorAddressTextBox = new TextBox();
            vendorNIPTextBox = new TextBox();
            vendorNameTextBox = new TextBox();
            label12 = new Label();
            vendorComboBox = new ComboBox();
            customerZipCodeLabel = new Label();
            customerCityLabel = new Label();
            customerAddressLabel = new Label();
            customerNIPLabel = new Label();
            customerNameLabel = new Label();
            customerZipCodeTextBox = new TextBox();
            customerCityTextBox = new TextBox();
            customerAddressTextBox = new TextBox();
            customerNIPTextBox = new TextBox();
            customerNameTextBox = new TextBox();
            customerLabel = new Label();
            customerComboBox = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            grossTotalAmountLabel = new Label();
            grossTotalLabel = new Label();
            netTotalAmountLabel = new Label();
            netTotalLabel = new Label();
            saveButton = new Button();
            addInvoiceTabDescription.SuspendLayout();
            addInvoiceTabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemVatPNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemPriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemQuantityNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invoiceItemsGridView).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(316, 9);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 3;
            label2.Text = "INVOICE";
            // 
            // addInvoiceTabDescription
            // 
            addInvoiceTabDescription.Controls.Add(descriptionTextBox);
            addInvoiceTabDescription.Location = new Point(4, 24);
            addInvoiceTabDescription.Name = "addInvoiceTabDescription";
            addInvoiceTabDescription.Padding = new Padding(3);
            addInvoiceTabDescription.Size = new Size(726, 695);
            addInvoiceTabDescription.TabIndex = 1;
            addInvoiceTabDescription.Text = "Description";
            addInvoiceTabDescription.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Dock = DockStyle.Fill;
            descriptionTextBox.Location = new Point(3, 3);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(720, 689);
            descriptionTextBox.TabIndex = 0;
            // 
            // addInvoiceTabData
            // 
            addInvoiceTabData.Controls.Add(cancelEditItemButton);
            addInvoiceTabData.Controls.Add(itemVatPNumericUpDown);
            addInvoiceTabData.Controls.Add(itemPriceNumericUpDown);
            addInvoiceTabData.Controls.Add(itemQuantityNumericUpDown);
            addInvoiceTabData.Controls.Add(comboBox1);
            addInvoiceTabData.Controls.Add(invoiceTypeLabel);
            addInvoiceTabData.Controls.Add(vendorCountryLabel);
            addInvoiceTabData.Controls.Add(vendorCountryTextBox);
            addInvoiceTabData.Controls.Add(customerCountryLabel);
            addInvoiceTabData.Controls.Add(customerCountryTextBox);
            addInvoiceTabData.Controls.Add(addItemButton);
            addInvoiceTabData.Controls.Add(saveItemButton);
            addInvoiceTabData.Controls.Add(itemCurrencyLabel);
            addInvoiceTabData.Controls.Add(itemVATLabel);
            addInvoiceTabData.Controls.Add(itemPriceLabel);
            addInvoiceTabData.Controls.Add(itemQuantityLabel);
            addInvoiceTabData.Controls.Add(itemNameLabel);
            addInvoiceTabData.Controls.Add(itemNameTextBox);
            addInvoiceTabData.Controls.Add(currencyComboBox);
            addInvoiceTabData.Controls.Add(invoiceItemsGridView);
            addInvoiceTabData.Controls.Add(currencyLabel);
            addInvoiceTabData.Controls.Add(numberLabel);
            addInvoiceTabData.Controls.Add(numberTextBox);
            addInvoiceTabData.Controls.Add(dateTimePicker2);
            addInvoiceTabData.Controls.Add(label3);
            addInvoiceTabData.Controls.Add(dateTimePicker1);
            addInvoiceTabData.Controls.Add(label1);
            addInvoiceTabData.Controls.Add(label7);
            addInvoiceTabData.Controls.Add(label8);
            addInvoiceTabData.Controls.Add(label9);
            addInvoiceTabData.Controls.Add(label10);
            addInvoiceTabData.Controls.Add(label11);
            addInvoiceTabData.Controls.Add(vendorZipCodeTextBox);
            addInvoiceTabData.Controls.Add(vendorCityTextBox);
            addInvoiceTabData.Controls.Add(vendorAddressTextBox);
            addInvoiceTabData.Controls.Add(vendorNIPTextBox);
            addInvoiceTabData.Controls.Add(vendorNameTextBox);
            addInvoiceTabData.Controls.Add(label12);
            addInvoiceTabData.Controls.Add(vendorComboBox);
            addInvoiceTabData.Controls.Add(customerZipCodeLabel);
            addInvoiceTabData.Controls.Add(customerCityLabel);
            addInvoiceTabData.Controls.Add(customerAddressLabel);
            addInvoiceTabData.Controls.Add(customerNIPLabel);
            addInvoiceTabData.Controls.Add(customerNameLabel);
            addInvoiceTabData.Controls.Add(customerZipCodeTextBox);
            addInvoiceTabData.Controls.Add(customerCityTextBox);
            addInvoiceTabData.Controls.Add(customerAddressTextBox);
            addInvoiceTabData.Controls.Add(customerNIPTextBox);
            addInvoiceTabData.Controls.Add(customerNameTextBox);
            addInvoiceTabData.Controls.Add(customerLabel);
            addInvoiceTabData.Controls.Add(customerComboBox);
            addInvoiceTabData.Location = new Point(4, 24);
            addInvoiceTabData.Name = "addInvoiceTabData";
            addInvoiceTabData.Padding = new Padding(3);
            addInvoiceTabData.Size = new Size(726, 695);
            addInvoiceTabData.TabIndex = 0;
            addInvoiceTabData.Text = "Data";
            addInvoiceTabData.UseVisualStyleBackColor = true;
            // 
            // cancelEditItemButton
            // 
            cancelEditItemButton.Location = new Point(560, 656);
            cancelEditItemButton.Name = "cancelEditItemButton";
            cancelEditItemButton.Size = new Size(78, 23);
            cancelEditItemButton.TabIndex = 106;
            cancelEditItemButton.Text = "Cancel";
            cancelEditItemButton.UseVisualStyleBackColor = true;
            cancelEditItemButton.Click += cancelEditItemButton_Click;
            // 
            // itemVatPNumericUpDown
            // 
            itemVatPNumericUpDown.Location = new Point(460, 656);
            itemVatPNumericUpDown.Name = "itemVatPNumericUpDown";
            itemVatPNumericUpDown.Size = new Size(67, 23);
            itemVatPNumericUpDown.TabIndex = 104;
            itemVatPNumericUpDown.Value = new decimal(new int[] { 23, 0, 0, 0 });
            itemVatPNumericUpDown.Enter += NumericUpDown_SelectAllOnEnter;
            // 
            // itemPriceNumericUpDown
            // 
            itemPriceNumericUpDown.Location = new Point(289, 656);
            itemPriceNumericUpDown.Name = "itemPriceNumericUpDown";
            itemPriceNumericUpDown.Size = new Size(67, 23);
            itemPriceNumericUpDown.TabIndex = 103;
            itemPriceNumericUpDown.Enter += NumericUpDown_SelectAllOnEnter;
            // 
            // itemQuantityNumericUpDown
            // 
            itemQuantityNumericUpDown.Location = new Point(97, 656);
            itemQuantityNumericUpDown.Name = "itemQuantityNumericUpDown";
            itemQuantityNumericUpDown.Size = new Size(67, 23);
            itemQuantityNumericUpDown.TabIndex = 102;
            itemQuantityNumericUpDown.Enter += NumericUpDown_SelectAllOnEnter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(97, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 23);
            comboBox1.TabIndex = 81;
            // 
            // invoiceTypeLabel
            // 
            invoiceTypeLabel.AutoSize = true;
            invoiceTypeLabel.Location = new Point(8, 9);
            invoiceTypeLabel.Name = "invoiceTypeLabel";
            invoiceTypeLabel.Size = new Size(34, 15);
            invoiceTypeLabel.TabIndex = 80;
            invoiceTypeLabel.Text = "Type:";
            // 
            // vendorCountryLabel
            // 
            vendorCountryLabel.AutoSize = true;
            vendorCountryLabel.Location = new Point(401, 343);
            vendorCountryLabel.Name = "vendorCountryLabel";
            vendorCountryLabel.Size = new Size(53, 15);
            vendorCountryLabel.TabIndex = 79;
            vendorCountryLabel.Text = "Country:";
            // 
            // vendorCountryTextBox
            // 
            vendorCountryTextBox.Location = new Point(490, 340);
            vendorCountryTextBox.Name = "vendorCountryTextBox";
            vendorCountryTextBox.Size = new Size(229, 23);
            vendorCountryTextBox.TabIndex = 78;
            // 
            // customerCountryLabel
            // 
            customerCountryLabel.AutoSize = true;
            customerCountryLabel.Location = new Point(8, 343);
            customerCountryLabel.Name = "customerCountryLabel";
            customerCountryLabel.Size = new Size(53, 15);
            customerCountryLabel.TabIndex = 77;
            customerCountryLabel.Text = "Country:";
            // 
            // customerCountryTextBox
            // 
            customerCountryTextBox.Location = new Point(97, 340);
            customerCountryTextBox.Name = "customerCountryTextBox";
            customerCountryTextBox.Size = new Size(229, 23);
            customerCountryTextBox.TabIndex = 76;
            // 
            // addItemButton
            // 
            addItemButton.Location = new Point(641, 620);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(78, 23);
            addItemButton.TabIndex = 75;
            addItemButton.Text = "Add item";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += addItemButton_Click;
            // 
            // saveItemButton
            // 
            saveItemButton.Location = new Point(641, 656);
            saveItemButton.Name = "saveItemButton";
            saveItemButton.Size = new Size(78, 23);
            saveItemButton.TabIndex = 105;
            saveItemButton.Text = "Save item";
            saveItemButton.UseVisualStyleBackColor = true;
            saveItemButton.Click += saveItemButton_Click;
            // 
            // itemCurrencyLabel
            // 
            itemCurrencyLabel.AutoSize = true;
            itemCurrencyLabel.Location = new Point(362, 660);
            itemCurrencyLabel.Name = "itemCurrencyLabel";
            itemCurrencyLabel.Size = new Size(0, 15);
            itemCurrencyLabel.TabIndex = 72;
            // 
            // itemVATLabel
            // 
            itemVATLabel.AutoSize = true;
            itemVATLabel.Location = new Point(411, 660);
            itemVATLabel.Name = "itemVATLabel";
            itemVATLabel.Size = new Size(50, 15);
            itemVATLabel.TabIndex = 70;
            itemVATLabel.Text = "VAT [%]:";
            // 
            // itemPriceLabel
            // 
            itemPriceLabel.AutoSize = true;
            itemPriceLabel.Location = new Point(248, 660);
            itemPriceLabel.Name = "itemPriceLabel";
            itemPriceLabel.Size = new Size(36, 15);
            itemPriceLabel.TabIndex = 68;
            itemPriceLabel.Text = "Price:";
            // 
            // itemQuantityLabel
            // 
            itemQuantityLabel.AutoSize = true;
            itemQuantityLabel.Location = new Point(8, 660);
            itemQuantityLabel.Name = "itemQuantityLabel";
            itemQuantityLabel.Size = new Size(56, 15);
            itemQuantityLabel.TabIndex = 66;
            itemQuantityLabel.Text = "Quantity:";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new Point(8, 628);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(67, 15);
            itemNameLabel.TabIndex = 64;
            itemNameLabel.Text = "Item name:";
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(97, 625);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(430, 23);
            itemNameTextBox.TabIndex = 101;
            // 
            // currencyComboBox
            // 
            currencyComboBox.FormattingEnabled = true;
            currencyComboBox.Location = new Point(97, 72);
            currencyComboBox.Name = "currencyComboBox";
            currencyComboBox.Size = new Size(229, 23);
            currencyComboBox.TabIndex = 62;
            // 
            // invoiceItemsGridView
            // 
            invoiceItemsGridView.AllowUserToAddRows = false;
            invoiceItemsGridView.AllowUserToDeleteRows = false;
            invoiceItemsGridView.AllowUserToResizeRows = false;
            invoiceItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            invoiceItemsGridView.Location = new Point(11, 380);
            invoiceItemsGridView.Name = "invoiceItemsGridView";
            invoiceItemsGridView.ReadOnly = true;
            invoiceItemsGridView.RowHeadersVisible = false;
            invoiceItemsGridView.RowTemplate.Height = 25;
            invoiceItemsGridView.Size = new Size(708, 234);
            invoiceItemsGridView.TabIndex = 61;
            invoiceItemsGridView.CellClick += invoiceItemsGridView_CellClick;
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new Point(8, 76);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new Size(58, 15);
            currencyLabel.TabIndex = 60;
            currencyLabel.Text = "Currency:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new Point(8, 44);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(54, 15);
            numberLabel.TabIndex = 59;
            numberLabel.Text = "Number:";
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(97, 40);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(229, 23);
            numberTextBox.TabIndex = 57;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(490, 72);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(229, 23);
            dateTimePicker2.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 76);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 55;
            label3.Text = "Date delivered:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(490, 40);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 23);
            dateTimePicker1.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 44);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 53;
            label1.Text = "Date of issue:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(401, 314);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 52;
            label7.Text = "Zip code:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(401, 285);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 51;
            label8.Text = "City:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(401, 256);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 50;
            label9.Text = "Address:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(401, 227);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 49;
            label10.Text = "NIP:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(401, 198);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 48;
            label11.Text = "Name:";
            // 
            // vendorZipCodeTextBox
            // 
            vendorZipCodeTextBox.Location = new Point(490, 311);
            vendorZipCodeTextBox.Name = "vendorZipCodeTextBox";
            vendorZipCodeTextBox.Size = new Size(229, 23);
            vendorZipCodeTextBox.TabIndex = 47;
            // 
            // vendorCityTextBox
            // 
            vendorCityTextBox.Location = new Point(490, 282);
            vendorCityTextBox.Name = "vendorCityTextBox";
            vendorCityTextBox.Size = new Size(229, 23);
            vendorCityTextBox.TabIndex = 46;
            // 
            // vendorAddressTextBox
            // 
            vendorAddressTextBox.Location = new Point(490, 253);
            vendorAddressTextBox.Name = "vendorAddressTextBox";
            vendorAddressTextBox.Size = new Size(229, 23);
            vendorAddressTextBox.TabIndex = 45;
            // 
            // vendorNIPTextBox
            // 
            vendorNIPTextBox.Location = new Point(490, 224);
            vendorNIPTextBox.Name = "vendorNIPTextBox";
            vendorNIPTextBox.Size = new Size(229, 23);
            vendorNIPTextBox.TabIndex = 44;
            // 
            // vendorNameTextBox
            // 
            vendorNameTextBox.Location = new Point(490, 195);
            vendorNameTextBox.Name = "vendorNameTextBox";
            vendorNameTextBox.Size = new Size(229, 23);
            vendorNameTextBox.TabIndex = 43;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(585, 139);
            label12.Name = "label12";
            label12.Size = new Size(53, 15);
            label12.TabIndex = 42;
            label12.Text = "VENDOR";
            // 
            // vendorComboBox
            // 
            vendorComboBox.FormattingEnabled = true;
            vendorComboBox.Location = new Point(490, 166);
            vendorComboBox.Name = "vendorComboBox";
            vendorComboBox.Size = new Size(229, 23);
            vendorComboBox.TabIndex = 41;
            // 
            // customerZipCodeLabel
            // 
            customerZipCodeLabel.AutoSize = true;
            customerZipCodeLabel.Location = new Point(8, 314);
            customerZipCodeLabel.Name = "customerZipCodeLabel";
            customerZipCodeLabel.Size = new Size(56, 15);
            customerZipCodeLabel.TabIndex = 40;
            customerZipCodeLabel.Text = "Zip code:";
            // 
            // customerCityLabel
            // 
            customerCityLabel.AutoSize = true;
            customerCityLabel.Location = new Point(8, 285);
            customerCityLabel.Name = "customerCityLabel";
            customerCityLabel.Size = new Size(31, 15);
            customerCityLabel.TabIndex = 39;
            customerCityLabel.Text = "City:";
            // 
            // customerAddressLabel
            // 
            customerAddressLabel.AutoSize = true;
            customerAddressLabel.Location = new Point(8, 256);
            customerAddressLabel.Name = "customerAddressLabel";
            customerAddressLabel.Size = new Size(52, 15);
            customerAddressLabel.TabIndex = 38;
            customerAddressLabel.Text = "Address:";
            // 
            // customerNIPLabel
            // 
            customerNIPLabel.AutoSize = true;
            customerNIPLabel.Location = new Point(8, 227);
            customerNIPLabel.Name = "customerNIPLabel";
            customerNIPLabel.Size = new Size(29, 15);
            customerNIPLabel.TabIndex = 37;
            customerNIPLabel.Text = "NIP:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new Point(8, 198);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(42, 15);
            customerNameLabel.TabIndex = 36;
            customerNameLabel.Text = "Name:";
            // 
            // customerZipCodeTextBox
            // 
            customerZipCodeTextBox.Location = new Point(97, 311);
            customerZipCodeTextBox.Name = "customerZipCodeTextBox";
            customerZipCodeTextBox.Size = new Size(229, 23);
            customerZipCodeTextBox.TabIndex = 35;
            // 
            // customerCityTextBox
            // 
            customerCityTextBox.Location = new Point(97, 282);
            customerCityTextBox.Name = "customerCityTextBox";
            customerCityTextBox.Size = new Size(229, 23);
            customerCityTextBox.TabIndex = 34;
            // 
            // customerAddressTextBox
            // 
            customerAddressTextBox.Location = new Point(97, 253);
            customerAddressTextBox.Name = "customerAddressTextBox";
            customerAddressTextBox.Size = new Size(229, 23);
            customerAddressTextBox.TabIndex = 33;
            // 
            // customerNIPTextBox
            // 
            customerNIPTextBox.Location = new Point(97, 224);
            customerNIPTextBox.Name = "customerNIPTextBox";
            customerNIPTextBox.Size = new Size(229, 23);
            customerNIPTextBox.TabIndex = 32;
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Location = new Point(97, 195);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new Size(229, 23);
            customerNameTextBox.TabIndex = 31;
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Location = new Point(176, 139);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(67, 15);
            customerLabel.TabIndex = 30;
            customerLabel.Text = "CUSTOMER";
            // 
            // customerComboBox
            // 
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(97, 166);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(229, 23);
            customerComboBox.TabIndex = 29;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(addInvoiceTabData);
            tabControl1.Controls.Add(addInvoiceTabDescription);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 54);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(734, 723);
            tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(726, 695);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Payments";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 346);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 0;
            label4.Text = "TODO";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(734, 48);
            panel3.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.Controls.Add(grossTotalAmountLabel);
            panel1.Controls.Add(grossTotalLabel);
            panel1.Controls.Add(netTotalAmountLabel);
            panel1.Controls.Add(netTotalLabel);
            panel1.Controls.Add(saveButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 763);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 48);
            panel1.TabIndex = 30;
            // 
            // grossTotalAmountLabel
            // 
            grossTotalAmountLabel.AutoSize = true;
            grossTotalAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grossTotalAmountLabel.Location = new Point(321, 18);
            grossTotalAmountLabel.Name = "grossTotalAmountLabel";
            grossTotalAmountLabel.Size = new Size(14, 15);
            grossTotalAmountLabel.TabIndex = 6;
            grossTotalAmountLabel.Text = "0";
            // 
            // grossTotalLabel
            // 
            grossTotalLabel.AutoSize = true;
            grossTotalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grossTotalLabel.Location = new Point(252, 18);
            grossTotalLabel.Name = "grossTotalLabel";
            grossTotalLabel.Size = new Size(67, 15);
            grossTotalLabel.TabIndex = 5;
            grossTotalLabel.Text = "Gross Total:";
            // 
            // netTotalAmountLabel
            // 
            netTotalAmountLabel.AutoSize = true;
            netTotalAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            netTotalAmountLabel.Location = new Point(72, 18);
            netTotalAmountLabel.Name = "netTotalAmountLabel";
            netTotalAmountLabel.Size = new Size(14, 15);
            netTotalAmountLabel.TabIndex = 4;
            netTotalAmountLabel.Text = "0";
            // 
            // netTotalLabel
            // 
            netTotalLabel.AutoSize = true;
            netTotalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            netTotalLabel.Location = new Point(12, 18);
            netTotalLabel.Name = "netTotalLabel";
            netTotalLabel.Size = new Size(57, 15);
            netTotalLabel.TabIndex = 3;
            netTotalLabel.Text = "Net Total:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(604, 13);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(118, 23);
            saveButton.TabIndex = 2;
            saveButton.Text = "CREATE INVOICE";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += createInvoiceButton_Click;
            // 
            // InvoicesAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 811);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            MaximumSize = new Size(750, 850);
            MinimumSize = new Size(750, 850);
            Name = "InvoicesAddForm";
            Text = "Add new invoice";
            FormClosing += InvoicesAddForm_FormClosing;
            Load += InvoicesAddForm_Load;
            addInvoiceTabDescription.ResumeLayout(false);
            addInvoiceTabDescription.PerformLayout();
            addInvoiceTabData.ResumeLayout(false);
            addInvoiceTabData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemVatPNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemPriceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemQuantityNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)invoiceItemsGridView).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private TabPage addInvoiceTabDescription;
        private TextBox descriptionTextBox;
        private TabPage addInvoiceTabData;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox vendorZipCodeTextBox;
        private TextBox vendorCityTextBox;
        private TextBox vendorAddressTextBox;
        private TextBox vendorNIPTextBox;
        private TextBox vendorNameTextBox;
        private Label label12;
        private ComboBox vendorComboBox;
        private Label customerZipCodeLabel;
        private Label customerCityLabel;
        private Label customerAddressLabel;
        private Label customerNIPLabel;
        private Label customerNameLabel;
        private TextBox customerZipCodeTextBox;
        private TextBox customerCityTextBox;
        private TextBox customerAddressTextBox;
        private TextBox customerNIPTextBox;
        private TextBox customerNameTextBox;
        private Label customerLabel;
        private ComboBox customerComboBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label4;
        private Panel panel3;
        private DataGridView invoiceItemsGridView;
        private Label currencyLabel;
        private Label numberLabel;
        private TextBox numberTextBox;
        private ComboBox currencyComboBox;
        private Panel panel1;
        private Button saveButton;
        private Label itemVATLabel;
        private Label itemPriceLabel;
        private Label itemQuantityLabel;
        private Label itemNameLabel;
        private TextBox itemNameTextBox;
        private Label itemCurrencyLabel;
        private Button saveItemButton;
        private Button addItemButton;
        private Label vendorCountryLabel;
        private TextBox vendorCountryTextBox;
        private Label customerCountryLabel;
        private TextBox customerCountryTextBox;
        private ComboBox comboBox1;
        private Label invoiceTypeLabel;
        private NumericUpDown itemVatPNumericUpDown;
        private NumericUpDown itemPriceNumericUpDown;
        private NumericUpDown itemQuantityNumericUpDown;
        private Button cancelEditItemButton;
        private Label netTotalAmountLabel;
        private Label netTotalLabel;
        private Label grossTotalAmountLabel;
        private Label grossTotalLabel;
    }
}