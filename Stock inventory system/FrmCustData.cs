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
    public partial class FrmCustData : Form
    {
        CustomerDAO dao = null;

        public FrmCustData()
        {
            InitializeComponent();

            dao = new CustomerDAO(Setting.GetConnectionString());
            this.dgvCustData.AutoGenerateColumns = false;
        }

        private void FrmCustData_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvCustData.DataSource = null;
                this.dgvCustData.DataSource = dao.GetAllCustomerData();
                this.dgvCustData.Columns[0].DataPropertyName = nameof(Customer.custID);
                this.dgvCustData.Columns[1].DataPropertyName = nameof(Customer.custName);
                this.dgvCustData.Columns[2].DataPropertyName = nameof(Customer.custAddress);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            FrmCustDescription frm = new FrmCustDescription(dao, false);
            frm.ShowDialog();

            ReloadDGVData();
        }

        private void btnEditCust_Click(object sender, EventArgs e)
        {
            if (this.dgvCustData.Rows.Count >= 1)
            {
                FrmCustDescription frm = new FrmCustDescription(dao, true, dao.GetCustomerByID(dgvCustData.SelectedRows[0].Cells[0].Value.ToString()));
                frm.ShowDialog();

                ReloadDGVData();
            }
            else
            {
                MessageBox.Show("Maaf, masih tidak ada data.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            if (this.dgvCustData.Rows.Count >= 1)
            {
                if (MessageBox.Show("Delete this Supplier ? \n Supplier Id : " + this.dgvCustData.SelectedRows[0].Cells[0].Value.ToString() + "\n Supplier Name : " + this.dgvCustData.SelectedRows[0].Cells[1].Value.ToString(), this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dao.DeleteCustomer(this.dgvCustData.SelectedRows[0].Cells[0].Value.ToString());

                    ReloadDGVData();
                }
            }
            else
            {
                MessageBox.Show("Maaf, masih tidak ada data.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCustData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to save changes data ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dao.UpdateAllCustomer();
            }
        }

        private void ReloadDGVData()
        {
            this.dgvCustData.DataSource = null;
            this.dgvCustData.Rows.Clear();
            foreach (Customer cust in dao.listData)
            {
                this.dgvCustData.Rows.Add(new string[] { cust.custID, cust.custName, cust.custAddress });
            }
        }
    }
}
