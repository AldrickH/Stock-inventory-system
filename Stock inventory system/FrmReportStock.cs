using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock_Library;

namespace Stock_inventory_system
{
    public partial class FrmReportStock : Form
    {
        ItemDAO _itmDAO = null;
        TransactionDAO _transDAO = null;

        public FrmReportStock()
        {
            InitializeComponent();

            _itmDAO = new ItemDAO(Setting.GetConnectionString());
            _transDAO = new TransactionDAO(Setting.GetConnectionString());
        }

        private void FrmReportStock_Load(object sender, EventArgs e)
        {
            this.listBoxItemID.DataSource = _itmDAO.GetAllItemData();
            this.listBoxItemID.DisplayMember = nameof(Item.itemID);

            this.listBoxItemID.ClearSelected();
            this.listBoxItemID.SelectedValueChanged += new EventHandler(listBoxItemID_SelectedValueChanged);
        }

        private void listBoxItemID_SelectedValueChanged(object sender, EventArgs e)
        {
            DSTransaction ds = new DSTransaction();

            foreach (Transaction trans in _transDAO.GetAllTransactionByItemID(this.listBoxItemID.Text))
            {
                var row = ds.Transaction.NewTransactionRow();
                row.transactionID = trans.transactionID;
                row.transactionDate = trans.transactionDate;
                row.itemID = trans.itemData.itemID;
                row.itemName = trans.itemData.itemName;
                row.qtyBefore = trans.qtyBefore.ToString();
                row.qtyTrans_IN = trans.qtyTrans_IN.ToString();
                row.qtyTrans_OUT = trans.qtyTrans_OUT.ToString();
                row.qtyAfter = trans.qtyAfter.ToString();

                ds.Transaction.AddTransactionRow(row);
            }

            RptItemStock rpt = new RptItemStock();
            rpt.SetDataSource(ds);
            this.RptViewerStock.ReportSource = rpt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
