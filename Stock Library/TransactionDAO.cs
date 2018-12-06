using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stock_Library
{
    public class TransactionDAO : IDisposable
    {
        SqlConnection _conn = null;
        SqlTransaction _trans = null;

        public List<Transaction> listTrans { get; set; }

        public TransactionDAO(string connectionString)
        {
            try
            {
                _conn = new SqlConnection(connectionString);
                _conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Transaction> GetAllTransactionData(bool itemOUT)
        {
            string sqlString = "";
            try
            {
                if (this.listTrans == null)
                {
                    if (itemOUT) sqlString = @"select i.itemName, i.qty, s.suppName, s.suppAddress, t.* from Trans t join Item i on t.itemID = i.itemID join Supplier s on t.suppID = s.suppID where t.transactionID like @transactionID";
                    else sqlString = "select i.itemName, i.qty, c.custName, c.custAddress, t.* from Trans t join Item i on t.itemID = i.itemID join Customer c on t.custID = c.custID where t.transactionID like @transactionID";
                    using (SqlCommand cmd = new SqlCommand(sqlString, _conn))
                    {
                        cmd.Parameters.Clear();

                        if (itemOUT) cmd.Parameters.AddWithValue("@transactionID", $"%{"OUT"}%");
                        else cmd.Parameters.AddWithValue("@transactionID", $"%{"IN"}%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            listTrans = new List<Transaction>();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (itemOUT)
                                    {
                                        listTrans.Add(new Transaction
                                        {
                                            transactionNumber = reader["transactionNumber"].ToString(),
                                            transactionID = reader["transactionID"].ToString(),
                                            transactionDate = reader["transactionDate"].ToString(),
                                            itemData = new Item { itemID = reader["itemID"].ToString(), itemName = reader["itemName"].ToString(), qty = Convert.ToInt32(reader["qty"]) },
                                            suppData = null,
                                            custData = new Customer { custID = reader["custID"].ToString(), custName = reader["custName"].ToString(), custAddress = reader["custAddress"].ToString() },
                                            qtyBefore = Convert.ToInt32(reader["qtyBefore"]),
                                            qtyTrans_IN = Convert.ToInt32(reader["qtyTrans_IN"]),
                                            qtyTrans_OUT = Convert.ToInt32(reader["qtyTrans_OUT"]),
                                            qtyAfter = Convert.ToInt32(reader["qtyAfter"])
                                        });
                                    }
                                    else
                                    {
                                        listTrans.Add(new Transaction
                                        {
                                            transactionNumber = reader["transactionNumber"].ToString(),
                                            transactionID = reader["transactionID"].ToString(),
                                            transactionDate = reader["transactionDate"].ToString(),
                                            itemData = new Item { itemID = reader["itemID"].ToString(), itemName = reader["itemName"].ToString(), qty = Convert.ToInt32(reader["qty"]) },
                                            suppData = new Supplier { suppID = reader["suppID"].ToString(), suppName = reader["suppName"].ToString(), suppAddress = reader["suppAddress"].ToString() },
                                            custData = null,
                                            qtyBefore = Convert.ToInt32(reader["qtyBefore"]),
                                            qtyTrans_IN = Convert.ToInt32(reader["qtyTrans_IN"]),
                                            qtyTrans_OUT = Convert.ToInt32(reader["qtyTrans_OUT"]),
                                            qtyAfter = Convert.ToInt32(reader["qtyAfter"])
                                        });
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listTrans;
        }

        public void AddTransaction(List<Transaction> _listTrans)
        {
            try
            {
                _trans = _conn.BeginTransaction();

                foreach (Transaction transItem in _listTrans)
                {
                    using (SqlCommand cmd = new SqlCommand(@"insert into Trans values (@transactionNumber, @transactionID, @transactionDate, @itemID, @suppID, @custID, @qtyBefore, @qtyTrans_IN, @qtyTrans_OUT, @qtyAfter)", _conn, _trans))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@transactionNumber", transItem.transactionNumber);
                        cmd.Parameters.AddWithValue("@transactionID", transItem.transactionID);
                        cmd.Parameters.AddWithValue("@transactionDate", transItem.transactionDate);
                        cmd.Parameters.AddWithValue("@itemID", transItem.itemData.itemID);
                        if (transItem.suppData == null) cmd.Parameters.AddWithValue("@suppID", DBNull.Value);
                        else cmd.Parameters.AddWithValue("@suppID", transItem.suppData.suppID);
                        if (transItem.custData == null) cmd.Parameters.AddWithValue("@custID", DBNull.Value);
                        else cmd.Parameters.AddWithValue("@custID", transItem.custData.custID);
                        cmd.Parameters.AddWithValue("@qtyBefore", transItem.qtyBefore);
                        cmd.Parameters.AddWithValue("@qtyTrans_IN", transItem.qtyTrans_IN);
                        cmd.Parameters.AddWithValue("@qtyTrans_OUT", transItem.qtyTrans_OUT);
                        cmd.Parameters.AddWithValue("@qtyAfter", transItem.qtyAfter);
                        cmd.ExecuteNonQuery();
                    }
                }

                _trans.Commit();
            }
            catch (Exception ex)
            {
                if (_trans != null) _trans.Rollback();
                throw ex;
            }
            finally
            {
                if (_trans != null) _trans.Dispose();
            }
        }

        public string GetTransactionNumberNext()
        {
            string result = "";
            try
            {
                using (SqlCommand cmd = new SqlCommand(@"Select Top 1 transactionNumber from Trans order by transactionNumber desc", _conn))
                {
                    cmd.Parameters.Clear();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                result = reader["transactionNumber"].ToString();
                            }
                        }
                    }
                }

                if (result.Equals(""))
                {
                    result = "00001";
                }
                else
                {
                    result = $"{(int.Parse(result) + 1).ToString("00000")}";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public string GetTransactionIDNext(bool itemOUT)
        {
            string result = "";
            try
            {
                if (itemOUT)
                {
                    if (listTrans?.Count > 0)
                    {
                        var res = this.listTrans.Last();
                        result = "OUT" + (Convert.ToInt32(res.transactionID.Substring(3, 4)) + 1).ToString("0000");
                    }
                    else
                    {
                        result = "OUT0001";
                    }
                }
                else
                {
                    if (listTrans?.Count > 0)
                    {
                        var res = this.listTrans.Last();
                        result = "IN" + (Convert.ToInt32(res.transactionID.Substring(2, 4)) + 1).ToString("0000");
                    }
                    else
                    {
                        result = "IN0001";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public void Dispose()
        {
            if (_conn != null) _conn.Close();
        }
    }
}
