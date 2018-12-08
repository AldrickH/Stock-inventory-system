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
    public partial class FrmReportIN : Form
    {
        SupplierDAO _suppDAO = null;
        TransactionDAO _transDAO = null;

        public FrmReportIN()
        {
            InitializeComponent();

            _suppDAO = new SupplierDAO(Setting.GetConnectionString());
            _transDAO = new TransactionDAO(Setting.GetConnectionString());
        }

        private void FrmReportIN_Load(object sender, EventArgs e)
        {
            this.listBoxSuppID.DataSource = _suppDAO.GetAllSupplierData();
            this.listBoxSuppID.DisplayMember = nameof(Supplier.suppID);

            this.listBoxSuppID.ClearSelected();
            this.listBoxSuppID.SelectedValueChanged += new EventHandler(listBoxSuppID_SelectedValueChanged);

            foreach (Transaction trans in _transDAO.GetAllTransactionData(false))
            {
                if (!listBoxTransID.Items.Contains(trans.transactionID)) this.listBoxTransID.Items.Add(trans.transactionID);
            }
            this.listBoxTransID.DisplayMember = nameof(Transaction.transactionID);

            this.listBoxTransID.ClearSelected();
            this.listBoxTransID.SelectedValueChanged += new EventHandler(listBoxTransID_SelectedValueChanged);
        }

        private void listBoxTransID_SelectedValueChanged(object sender, EventArgs e)
        {
            DSTransaction ds = new DSTransaction();

            foreach (Transaction trans in _transDAO.listTrans)
            {
                if (trans.transactionID.Equals(this.listBoxTransID.Text))
                {
                    var row = ds.Transaction.NewTransactionRow();
                    row.transactionID = trans.transactionID;
                    row.transactionDate = trans.transactionDate;
                    row.suppID = trans.suppData.suppID;
                    row.suppName = trans.suppData.suppName;
                    row.suppAddress = trans.suppData.suppAddress;
                    row.itemID = trans.itemData.itemID;
                    row.itemName = trans.itemData.itemName;
                    row.qtyTrans_IN = trans.qtyTrans_IN.ToString();

                    ds.Transaction.AddTransactionRow(row);
                }
            }

            RptItemIN rpt = new RptItemIN();
            rpt.SetDataSource(ds);
            this.RptViewerIN.ReportSource = rpt;
        }

        private void listBoxSuppID_SelectedValueChanged(object sender, EventArgs e)
        {
            DSTransaction ds = new DSTransaction();

            foreach (Transaction trans in _transDAO.listTrans)
            {
                if (trans.suppData.suppID.Equals(this.listBoxSuppID.Text))
                {
                    var row = ds.Transaction.NewTransactionRow();
                    row.transactionID = trans.transactionID;
                    row.transactionDate = trans.transactionDate;
                    row.suppID = trans.suppData.suppID;
                    row.suppName = trans.suppData.suppName;
                    row.suppAddress = trans.suppData.suppAddress;
                    row.itemID = trans.itemData.itemID;
                    row.itemName = trans.itemData.itemName;
                    row.qtyTrans_IN = trans.qtyTrans_IN.ToString();

                    ds.Transaction.AddTransactionRow(row);
                }
            }

            RptItemIN rpt = new RptItemIN();
            rpt.SetDataSource(ds);
            this.RptViewerIN.ReportSource = rpt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
