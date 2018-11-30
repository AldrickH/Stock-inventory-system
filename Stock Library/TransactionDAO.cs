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

        public void AddTransaction(List<Transaction> _listTrans)
        {
            try
            {
                _trans = _conn.BeginTransaction();

                foreach (Transaction transItem in _listTrans)
                {
                    using (SqlCommand cmd = new SqlCommand(@"insert into Trans values (@transactionNumber, @transactionID, @transactionDate, @itemID, @qtyBefore, @qtyTrans_IN, @qtyTrans_OUT, @qtyAfter)", _conn, _trans))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@transactionNumber", transItem.transactionNumber);
                        cmd.Parameters.AddWithValue("@transactionID", transItem.transactionID);
                        cmd.Parameters.AddWithValue("@transactionDate", transItem.transactionDate);
                        cmd.Parameters.AddWithValue("@itemID", transItem.itemData.itemID);
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

        public void Dispose()
        {
            if (_conn != null) _conn.Close();
        }
    }
}
