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
        private CurrencyManager _cm;

        public frmListVendors()
        {
            InitializeComponent();
        }

        private void frmListVendors_Load(object sender, EventArgs e)
        {
            List<Vendor> vendors = VendorDB.GetAllVendors();
            vendorBindingSource.DataSource = vendors;

            _cm = (CurrencyManager)
                    vendorDataGridView.BindingContext[vendors];
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

        private void mnuModifyVendor_Click(object sender, EventArgs e)
        {
            // retrieve the current Vendor
            Vendor vendor = (Vendor)vendorBindingSource.Current;

            // display vendor form
            frmAddModifyVendor frmChild = new frmAddModifyVendor();
            frmChild.vendor = vendor;
            this.AddOwnedForm(frmChild);
            if (frmChild.ShowDialog() == DialogResult.OK)
            {
                vendorBindingSource.DataSource = VendorDB.GetAllVendors();
            }
        }

        private void mnuAddNewVendor_Click(object sender, EventArgs e)
        {
            frmAddModifyVendor frmChild = new frmAddModifyVendor();
            this.AddOwnedForm(frmChild);
            if (frmChild.ShowDialog() == DialogResult.OK)
            {
                vendorBindingSource.DataSource = VendorDB.GetAllVendors();
            }
        }
    }
}
