using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stock_Library
{
    public class CustomerDAO : IDisposable
    {
        SqlConnection _conn = null;
        SqlTransaction _trans = null;

        public List<Customer> listData { get; set; }

        public CustomerDAO(string connectionString)
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

        public List<Customer> GetAllCustomerData()
        {
            try
            {
                if (this.listData == null)
                {
                    using (SqlCommand cmd = new SqlCommand(@"select * from Customer order by custID", _conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            listData = new List<Customer>();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    listData.Add(new Customer
                                    {
                                        custID = reader["custID"].ToString(),
                                        custName = reader["custName"].ToString(),
                                        custAddress = reader["custAddress"].ToString()
                                    });
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
            return listData;
        }

        public void AddNewCustomer(Customer _cust)
        {
            try
            {
                listData.Add(_cust);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditCustomer(Customer _cust_NEW, Customer _cust_OLD)
        {
            try
            {
                foreach (Customer cust in listData)
                {
                    if (cust.custID.Equals(_cust_OLD.custID))
                    {
                        cust.custID = _cust_NEW.custID;
                        cust.custName = _cust_NEW.custName;
                        cust.custAddress = _cust_NEW.custAddress;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteCustomer(string _custID)
        {
            try
            {
                foreach (Customer cust in listData)
                {
                    if (cust.custID.Equals(_custID))
                    {
                        listData.Remove(cust);
                        break;
                    }
                }

                using (SqlCommand cmd = new SqlCommand(@"delete Customer where custID = @custID", _conn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@custID", _custID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateAllCustomer()
        {
            try
            {
                _trans = _conn.BeginTransaction();

                foreach (Customer cust in listData)
                {
                    if (!CheckCustomerByID(cust.custID))
                    {
                        using (SqlCommand cmd = new SqlCommand(@"insert into Customer values (@custID, @custName, @custAddress)", _conn, _trans))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@custID", cust.custID);
                            cmd.Parameters.AddWithValue("@custName", cust.custName);
                            cmd.Parameters.AddWithValue("@custAddress", cust.custAddress);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand(@"update Customer set custName = @custName, custAddress = @custAddress where custID = @custID", _conn, _trans))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@custID", cust.custID);
                            cmd.Parameters.AddWithValue("@custName", cust.custName);
                            cmd.Parameters.AddWithValue("@custAddress", cust.custAddress);
                            cmd.ExecuteNonQuery();
                        }
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

        public string GetCustomerIDNext()
        {
            string result = "";
            try
            {
                if (listData.Count > 0)
                {
                    var res = this.listData.Last();
                    result = "CST" + (Convert.ToInt32(res.custID.Substring(3, 4)) + 1).ToString("0000");
                }
                else
                {
                    result = "CST0001";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool CheckCustomerByID(string _custID)
        {
            bool result = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand(@"select * from Customer where custID = @custID", _conn, _trans))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@custID", _custID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                result = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public Customer GetCustomerByID(string _custID)
        {
            Customer result = null;
            try
            {
                foreach (Customer cust in listData)
                {
                    if (cust.custID.Equals(_custID))
                    {
                        result = cust;
                        break;
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
