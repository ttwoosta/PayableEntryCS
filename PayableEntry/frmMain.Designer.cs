namespace PayableEntry
{
    partial class frmMain
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVendor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindVendor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddModifyVendor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVendorInvoices = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListVendors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuInvoice,
            this.mnuVendor});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 27);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(41, 23);
            this.mnuFile.Text = "&File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(202, 24);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuInvoice
            // 
            this.mnuInvoice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVendorInvoices,
            this.mnuAddInvoice});
            this.mnuInvoice.Name = "mnuInvoice";
            this.mnuInvoice.Size = new System.Drawing.Size(64, 23);
            this.mnuInvoice.Text = "&Invoice";
            // 
            // mnuVendor
            // 
            this.mnuVendor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFindVendor,
            this.mnuAddModifyVendor,
            this.toolStripSeparator1,
            this.mnuListVendors});
            this.mnuVendor.Name = "mnuVendor";
            this.mnuVendor.Size = new System.Drawing.Size(65, 23);
            this.mnuVendor.Text = "&Vendor";
            // 
            // mnuFindVendor
            // 
            this.mnuFindVendor.Name = "mnuFindVendor";
            this.mnuFindVendor.Size = new System.Drawing.Size(226, 24);
            this.mnuFindVendor.Text = "Find a Vendor by &Name";
            this.mnuFindVendor.Click += new System.EventHandler(this.mnuFindVendor_Click);
            // 
            // mnuAddModifyVendor
            // 
            this.mnuAddModifyVendor.Name = "mnuAddModifyVendor";
            this.mnuAddModifyVendor.Size = new System.Drawing.Size(226, 24);
            this.mnuAddModifyVendor.Text = "Add or Modify Vendor";
            this.mnuAddModifyVendor.Click += new System.EventHandler(this.mnuAddModifyVendor_Click);
            // 
            // mnuVendorInvoices
            // 
            this.mnuVendorInvoices.Name = "mnuVendorInvoices";
            this.mnuVendorInvoices.Size = new System.Drawing.Size(248, 24);
            this.mnuVendorInvoices.Text = "Search Invoice by VendorId";
            this.mnuVendorInvoices.Click += new System.EventHandler(this.mnuVendorInvoices_Click);
            // 
            // mnuAddInvoice
            // 
            this.mnuAddInvoice.Name = "mnuAddInvoice";
            this.mnuAddInvoice.Size = new System.Drawing.Size(248, 24);
            this.mnuAddInvoice.Text = "Add New Invoice";
            this.mnuAddInvoice.Click += new System.EventHandler(this.mnuAddInvoice_Click);
            // 
            // mnuListVendors
            // 
            this.mnuListVendors.Name = "mnuListVendors";
            this.mnuListVendors.Size = new System.Drawing.Size(226, 24);
            this.mnuListVendors.Text = "List Vendors";
            this.mnuListVendors.Click += new System.EventHandler(this.mnuListVendors_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payable Entry";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuInvoice;
        private System.Windows.Forms.ToolStripMenuItem mnuVendor;
        private System.Windows.Forms.ToolStripMenuItem mnuFindVendor;
        private System.Windows.Forms.ToolStripMenuItem mnuVendorInvoices;
        private System.Windows.Forms.ToolStripMenuItem mnuAddInvoice;
        private System.Windows.Forms.ToolStripMenuItem mnuAddModifyVendor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuListVendors;
    }
}