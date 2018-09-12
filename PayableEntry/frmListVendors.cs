using PayablesData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PayableEntry
{
    public partial class frmListVendors : Form
    {
        public frmListVendors()
        {
            InitializeComponent();
        }

        private void frmListVendors_Load(object sender, EventArgs e)
        {
            List<Vendor> vendors = VendorDB.GetAllVendors();
            vendorBindingSource.DataSource = vendors;
        }

        private void addInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // retrieve the current Vendor
            Vendor vendor = (Vendor)vendorBindingSource.Current;

            // display add Invoice form
            frmAddInvoice frmChild = new frmAddInvoice();
            frmChild.vendor = vendor;
            this.AddOwnedForm(frmChild);
            frmChild.ShowDialog();
        }
    }
}
