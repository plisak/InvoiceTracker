using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTracker.Forms.Invoices
{
    public partial class InvoicesAddForm : Form
    {
        public InvoicesAddForm()
        {
            InitializeComponent();
        }
        private void InvoicesAddForm_Load(object sender, EventArgs e)
        {
            ShowItemEditFields(false);
        }

        private void ShowItemEditFields(bool show)
        {
            addItemButton.Visible = !show;

            itemNameLabel.Visible = show;
            itemNameTextBox.Visible = show;

            itemQuantityLabel.Visible = show;
            itemQuantityTextBox.Visible = show;

            itemPriceLabel.Visible = show;
            itemPriceTextBox.Visible = show;
            itemCurrencyLabel.Visible = show;

            itemVATLabel.Visible = show;
            itemVATTextBox.Visible = show;
            itemVatPlabel.Visible = show;

            saveItemButton.Visible = show;
        }

        private void createInvoiceButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveItemButton_Click(object sender, EventArgs e)
        {
            ShowItemEditFields(false);
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            ShowItemEditFields(true);
        }

        private void InvoicesAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("Exit without saving?", "Warning", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
