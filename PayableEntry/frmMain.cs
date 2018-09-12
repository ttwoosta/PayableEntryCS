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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayMdiForm(Form child)
        {
            child.MdiParent = this;
            child.Show();
        }

        private void mnuVendorInvoices_Click(object sender, EventArgs e)
        {
            DisplayMdiForm(new frmVendorInvoices());
        }

        private void mnuAddInvoice_Click(object sender, EventArgs e)
        {
            //DisplayMdiForm(new frmAddInvoice());
        }

        private void mnuFindVendor_Click(object sender, EventArgs e)
        {
            DisplayMdiForm(new frmFindVendor());
        }

        private void mnuAddModifyVendor_Click(object sender, EventArgs e)
        {
            DisplayMdiForm(new frmAddModifyVendor());
        }

        private void mnuListVendors_Click(object sender, EventArgs e)
        {
            DisplayMdiForm(new frmListVendors());
        }
    }
}
