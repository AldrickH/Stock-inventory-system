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
    public partial class FrmSuppData : Form
    {
        SupplierDAO dao = null;

        public FrmSuppData()
        {
            InitializeComponent();

            dao = new SupplierDAO(Setting.GetConnectionString());
            this.dgvSuppData.AutoGenerateColumns = false;
        }

        private void FrmSuppData_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvSuppData.DataSource = null;
                this.dgvSuppData.DataSource = dao.GetAllSupplierData();
                this.dgvSuppData.Columns[0].DataPropertyName = nameof(Supplier.suppID);
                this.dgvSuppData.Columns[1].DataPropertyName = nameof(Supplier.suppName);
                this.dgvSuppData.Columns[2].DataPropertyName = nameof(Supplier.suppAddress);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            FrmSuppDescription frm = new FrmSuppDescription(dao, false);
            frm.ShowDialog();

            ReloadDGVData();
        }

        private void btnEditSupp_Click(object sender, EventArgs e)
        {
            if (this.dgvSuppData.Rows.Count >= 1)
            {
                FrmSuppDescription frm = new FrmSuppDescription(dao, true, dao.GetSupplierByID(dgvSuppData.SelectedRows[0].Cells[0].Value.ToString()));
                frm.ShowDialog();

                ReloadDGVData();
            }
            else
            {
                MessageBox.Show("Maaf, masih tidak ada data.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSupp_Click(object sender, EventArgs e)
        {
            if (this.dgvSuppData.Rows.Count >= 1)
            {
                if (MessageBox.Show("Delete this Supplier ? \n Supplier Id : " + this.dgvSuppData.SelectedRows[0].Cells[0].Value.ToString() + "\n Supplier Name : " + this.dgvSuppData.SelectedRows[0].Cells[1].Value.ToString(), this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dao.DeleteSupplier(this.dgvSuppData.SelectedRows[0].Cells[0].Value.ToString());

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

        private void FrmSuppData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to save changes data ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dao.UpdateAllSupplier();
            }
        }

        private void ReloadDGVData()
        {
            this.dgvSuppData.DataSource = null;
            this.dgvSuppData.Rows.Clear();
            foreach (Supplier supp in dao.listData)
            {
                this.dgvSuppData.Rows.Add(new string[] { supp.suppID, supp.suppName, supp.suppAddress });
            }
        }
    }
}
