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
    public partial class FrmReportOUT : Form
    {
        CustomerDAO _custDAO = null;
        TransactionDAO _transDAO = null;

        public FrmReportOUT()
        {
            InitializeComponent();

            _custDAO = new CustomerDAO(Setting.GetConnectionString());
            _transDAO = new TransactionDAO(Setting.GetConnectionString());
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            this.listBoxCustID.DataSource = _custDAO.GetAllCustomerData();
            this.listBoxCustID.DisplayMember = nameof(Customer.custID);

            this.listBoxCustID.ClearSelected();
            this.listBoxCustID.SelectedValueChanged += new EventHandler(listBoxCustID_SelectedValueChanged);

            foreach (Transaction trans in _transDAO.GetAllTransactionData(true))
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
                    row.custID = trans.custData.custID;
                    row.custName = trans.custData.custName;
                    row.itemID = trans.itemData.itemID;
                    row.itemName = trans.itemData.itemName;
                    row.qtyTrans_OUT = trans.qtyTrans_OUT.ToString();

                    ds.Transaction.AddTransactionRow(row);
                }
            }

            RptItemOUT rpt = new RptItemOUT();
            rpt.SetDataSource(ds);
            this.RptViewerOUT.ReportSource = rpt;
        }

        private void listBoxCustID_SelectedValueChanged(object sender, EventArgs e)
        {
            DSTransaction ds = new DSTransaction();

            foreach (Transaction trans in _transDAO.listTrans)
            {
                if (trans.custData.custID.Equals(this.listBoxCustID.Text))
                {
                    var row = ds.Transaction.NewTransactionRow();
                    row.transactionID = trans.transactionID;
                    row.transactionDate = trans.transactionDate;
                    row.custID = trans.custData.custID;
                    row.custName = trans.custData.custName;
                    row.itemID = trans.itemData.itemID;
                    row.itemName = trans.itemData.itemName;
                    row.qtyTrans_OUT = trans.qtyTrans_OUT.ToString();

                    ds.Transaction.AddTransactionRow(row);
                }
            }

            RptItemOUT rpt = new RptItemOUT();
            rpt.SetDataSource(ds);
            this.RptViewerOUT.ReportSource = rpt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
