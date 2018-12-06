using Stock_Library;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_inventory_system
{
    public partial class FrmTransaction : Form
    {
        ItemDAO _itemDAO = null;
        SupplierDAO _suppDAO = null;
        TransactionDAO _transDAO = null;
        CustomerDAO _custDAO = null;

        bool _itemOUT = false;

        public FrmTransaction(bool itemOUT)
        {
            InitializeComponent();
            _itemDAO = new ItemDAO(Setting.GetConnectionString());
            _suppDAO = new SupplierDAO(Setting.GetConnectionString());
            _transDAO = new TransactionDAO(Setting.GetConnectionString());
            _custDAO = new CustomerDAO(Setting.GetConnectionString());

            this.dgvItemData.AutoGenerateColumns = false;

            _itemOUT = itemOUT;
        }

        private void FrmTransaction_IN_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvItemData.DataSource = null;
                this.dgvItemData.DataSource = _itemDAO.GetAllItemData();
                this.dgvItemData.Columns[0].DataPropertyName = nameof(Item.itemID);
                this.dgvItemData.Columns[1].DataPropertyName = nameof(Item.itemName);

                this.cBoxID.DataSource = null;
                if (_itemOUT)
                {
                    this.cBoxID.DataSource = _custDAO.GetAllCustomerData();
                    this.cBoxID.ValueMember = nameof(Customer.custID);
                }
                else
                {
                    this.cBoxID.DataSource = _suppDAO.GetAllSupplierData();
                    this.cBoxID.ValueMember = nameof(Supplier.suppID);
                }

                this.cBoxID.Text = "";
                this.lbl_GenerateName.Text = "";

                _transDAO.listTrans = _transDAO.GetAllTransactionData(_itemOUT);
                this.txtBox_TransID.Text = _transDAO.GetTransactionIDNext(_itemOUT);

                if (_itemOUT)
                {
                    this.lbl_Company.Text += " - ITEM OUT";
                    this.dgvTransaction.Columns[3].HeaderText = "OUT_Ammount";
                    this.lbl_Total.Text += " OUT :";
                    this.lbl_ID.Text = "Customer ID : ";
                    this.lbl_Name.Text = "Customer Name : ";
                }
                else
                {
                    this.lbl_Company.Text += " - ITEM IN";
                    this.lbl_Total.Text += " IN :";
                    this.lbl_ID.Text = "Supplier ID : ";
                    this.lbl_Name.Text = "Supplier Name : ";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cBoxID_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cBoxID.Text != "" && (_suppDAO.listData?.Count > 0 || _custDAO.listData?.Count > 0))
            {
                if (_itemOUT) this.lbl_GenerateName.Text = _custDAO.GetCustomerByID(this.cBoxID.Text).custName;
                else this.lbl_GenerateName.Text = _suppDAO.GetSupplierByID(this.cBoxID.Text).suppName;
            }
        }

        private void dgvItemData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!checkItemExist())
            {
                Item itm = _itemDAO.GetItemByID(this.dgvItemData.SelectedRows[0].Cells[0].Value.ToString());
                this.dgvTransaction.Rows.Add(new string[] { itm.itemID, itm.itemName, itm.qty.ToString() });

                int test = this.dgvTransaction.Rows.Count;
                this.dgvTransaction.CurrentCell = this.dgvTransaction.Rows[test - 1].Cells[3];
                this.dgvTransaction.BeginEdit(true);
            }
            else
            {
                foreach (DataGridViewRow row in this.dgvTransaction.Rows)
                {
                    if (this.dgvItemData.SelectedRows[0].Cells[0].Value.ToString() == row.Cells[0].Value.ToString())
                    {
                        this.dgvTransaction.CurrentCell = row.Cells[3];
                        this.dgvTransaction.BeginEdit(true);
                        break;
                    }
                }
            }
        }

        private void dgvTransaction_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowNo = this.dgvTransaction.CurrentCell.RowIndex;

            if (_itemOUT)
            {
                this.dgvTransaction.Rows[rowNo].Cells[4].Value = Convert.ToInt32(this.dgvTransaction.Rows[rowNo].Cells[2].Value) - Convert.ToInt32(this.dgvTransaction.Rows[rowNo].Cells[3].Value);
            }
            else
            {
                this.dgvTransaction.Rows[rowNo].Cells[4].Value = Convert.ToInt32(this.dgvTransaction.Rows[rowNo].Cells[2].Value) + Convert.ToInt32(this.dgvTransaction.Rows[rowNo].Cells[3].Value);
            }

            this.lbl_QuantityTotal.Text = GetQuantityTotal().ToString() + " pcs";
        }

        private void dgvTransaction_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvTransaction.Rows.Count > 0 && _itemOUT)
            {
                int rowNo = this.dgvTransaction.CurrentCell.RowIndex;
                if (Convert.ToInt32(this.dgvTransaction.Rows[rowNo].Cells[3].Value) > Convert.ToInt32(this.dgvTransaction.Rows[rowNo].Cells[2].Value))
                {
                    this.dgvTransaction.Rows[rowNo].Cells[3].Value = this.dgvTransaction.Rows[rowNo].Cells[2].Value;
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (_itemOUT == false && _suppDAO.CheckSupplierByID(this.cBoxID.Text) == false)
            {
                MessageBox.Show("Sorry, Supplier not found, please insert another supplier ID.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cBoxID.Focus();
            }
            else if (_itemOUT == true && _custDAO.CheckCustomerByID(this.cBoxID.Text) == false)
            {
                MessageBox.Show("Sorry, Customer not found, please insert another supplier ID.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cBoxID.Focus();
            }
            else
            {
                if (MessageBox.Show("Are you sure to add this data ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string transNumber = _transDAO.GetTransactionNumberNext();
                    List<Transaction> listTrans = new List<Transaction>();
                    foreach (DataGridViewRow row in this.dgvTransaction.Rows)
                    {
                        if (Convert.ToInt32(row.Cells[3].Value) > 0)
                        {
                            if (_itemOUT)
                            {
                                listTrans.Add(new Transaction
                                {
                                    transactionID = this.txtBox_TransID.Text,
                                    transactionNumber = transNumber,
                                    transactionDate = this.dtp_TransDate.Value.ToShortDateString(),
                                    itemData = _itemDAO.GetItemByID(row.Cells[0].Value.ToString()),
                                    suppData = null,
                                    custData = _custDAO.GetCustomerByID(this.cBoxID.Text),
                                    qtyBefore = Convert.ToInt32(row.Cells[2].Value),
                                    qtyTrans_IN = 0,
                                    qtyTrans_OUT = Convert.ToInt32(row.Cells[3].Value),
                                    qtyAfter = Convert.ToInt32(row.Cells[4].Value)
                                });
                            }
                            else
                            {
                                listTrans.Add(new Transaction
                                {
                                    transactionID = this.txtBox_TransID.Text,
                                    transactionNumber = transNumber,
                                    transactionDate = this.dtp_TransDate.Value.ToShortDateString(),
                                    itemData = _itemDAO.GetItemByID(row.Cells[0].Value.ToString()),
                                    suppData = _suppDAO.GetSupplierByID(this.cBoxID.Text),
                                    custData = null,
                                    qtyBefore = Convert.ToInt32(row.Cells[2].Value),
                                    qtyTrans_IN = Convert.ToInt32(row.Cells[3].Value),
                                    qtyTrans_OUT = 0,
                                    qtyAfter = Convert.ToInt32(row.Cells[4].Value)
                                });
                            }
                        }
                        transNumber = $"{(int.Parse(transNumber) + 1).ToString("00000")}";

                        _itemDAO.UpdateQuantity(row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[4].Value));
                    }
                    _transDAO.AddTransaction(listTrans);

                    _itemDAO.UpdateAllItem();

                    this.Close();
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTransaction_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Numeric_KeyPress);
            if (this.dgvTransaction.CurrentCell.ColumnIndex == 3)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Numeric_KeyPress);
                }
            }
        }

        private void Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private int GetQuantityTotal()
        {
            int result = 0;
            if (this.dgvTransaction.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in this.dgvTransaction.Rows)
                {
                    result += Convert.ToInt32(row.Cells[3].Value);
                }
            }
            return result;
        }

        private bool checkItemExist()
        {
            if (this.dgvTransaction.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in this.dgvTransaction.Rows)
                {
                    if (this.dgvItemData.SelectedRows[0].Cells[0].Value.ToString() == row.Cells[0].Value.ToString())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
