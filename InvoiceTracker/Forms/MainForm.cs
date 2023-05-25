using InvoiceTracker.Forms.Invoices;

namespace InvoiceTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void invoicesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var invoicesForm = new InvoicesForm();
            invoicesForm.MdiParent = this;
            invoicesForm.Show();
        }

        private void invoicesAddNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addInvoicesForm = new InvoicesAddForm();
            addInvoicesForm.MdiParent = this;
            addInvoicesForm.Show();
        }
    }
}