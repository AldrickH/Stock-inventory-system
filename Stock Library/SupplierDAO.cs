using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stock_Library
{
    public class SupplierDAO : IDisposable
    {
        SqlConnection _conn = null;
        SqlTransaction _trans = null;

        public List<Supplier> listData { get; set; }

        public SupplierDAO(string connectionString)
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

        public List<Supplier> GetAllSupplierData()
        {
            try
            {
                if (this.listData == null)
                {
                    using (SqlCommand cmd = new SqlCommand(@"select * from Supplier order by suppID", _conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            listData = new List<Supplier>();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    listData.Add(new Supplier
                                    {
                                        suppID = reader["suppID"].ToString(),
                                        suppName = reader["suppName"].ToString(),
                                        suppAddress = reader["suppAddress"].ToString()
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

        public void AddNewSupplier(Supplier _supp)
        {
            try
            {
                listData.Add(_supp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditSupplier(Supplier _supp_NEW, Supplier _supp_OLD)
        {
            try
            {
                foreach (Supplier supp in listData)
                {
                    if (supp.suppID.Equals(_supp_OLD.suppID))
                    {
                        supp.suppID = _supp_NEW.suppID;
                        supp.suppName = _supp_NEW.suppName;
                        supp.suppAddress = _supp_NEW.suppAddress;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteSupplier(string _suppID)
        {
            try
            {
                foreach (Supplier supp in listData)
                {
                    if (supp.suppID.Equals(_suppID))
                    {
                        listData.Remove(supp);
                        break;
                    }
                }

                using (SqlCommand cmd = new SqlCommand(@"delete Supplier where suppID = @suppID", _conn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@suppID", _suppID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateAllSupplier()
        {
            try
            {
                _trans = _conn.BeginTransaction();

                foreach (Supplier supp in listData)
                {
                    if (!CheckSupplierByID(supp.suppID))
                    {
                        using (SqlCommand cmd = new SqlCommand(@"insert into Supplier values (@suppID, @suppName, @suppAddress)", _conn, _trans))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@suppID", supp.suppID);
                            cmd.Parameters.AddWithValue("@suppName", supp.suppName);
                            cmd.Parameters.AddWithValue("@suppAddress", supp.suppAddress);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand(@"update Supplier set suppName = @suppName, suppAddress = @suppAddress where suppID = @suppID", _conn, _trans))
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@suppID", supp.suppID);
                            cmd.Parameters.AddWithValue("@suppName", supp.suppName);
                            cmd.Parameters.AddWithValue("@suppAddress", supp.suppAddress);
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

        public string GetSuppIDNext()
        {
            string result = "";
            try
            {
                if (listData.Count > 0)
                {
                    var res = this.listData.Last();
                    result = "SUP" + (Convert.ToInt32(res.suppID.Substring(3, 4)) + 1).ToString("0000");
                }
                else
                {
                    result = "SUP0001";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool CheckSupplierByID(string _suppID)
        { 
            bool result = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand(@"select * from Supplier where suppID = @suppID", _conn, _trans))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@suppID", _suppID);

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

        public Supplier GetSupplierByID(string _suppID)
        {
            Supplier result = null;
            try
            {
                foreach (Supplier supp in listData)
                {
                    if (supp.suppID.Equals(_suppID))
                    {
                        result = supp;
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
