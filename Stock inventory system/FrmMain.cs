using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_inventory_system
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            FrmCustData frm = new FrmCustData();
            frm.ShowDialog();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            FrmSuppData frm = new FrmSuppData();
            frm.ShowDialog();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            FrmItemData frm = new FrmItemData();
            frm.ShowDialog();
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            FrmTransaction frm = new FrmTransaction(false);
            frm.ShowDialog();
        }

        private void btnOUT_Click(object sender, EventArgs e)
        {
            FrmTransaction frm = new FrmTransaction(true);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReport_IN_Click(object sender, EventArgs e)
        {
            FrmReportIN frm = new FrmReportIN();
            frm.ShowDialog();
        }

        private void btnReport_OUT_Click(object sender, EventArgs e)
        {
            FrmReportOUT frm = new FrmReportOUT();
            frm.ShowDialog();
        }

        private void btnReport_Stock_Click(object sender, EventArgs e)
        {
            FrmReportStock frm = new FrmReportStock();
            frm.ShowDialog();
        }
    }
}
