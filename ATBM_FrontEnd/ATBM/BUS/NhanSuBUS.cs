using System;
using System.Data;
using System.Windows.Forms;
using ATBM.DTO;
using Oracle.ManagedDataAccess.Client;

namespace ATBM.BUS
{
    internal class NhanSuBUS
    {
        OracleConnection connection = new OracleConnection(Program.connectionString);
        public NhanSuDTO LayTTNhanSu(string pMANV)
        {
            string procedureName = "lay_thong_tin_nhan_su";
            NhanSuDTO nhanSu = new NhanSuDTO();
            try
            {
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    connection.Open();
                    OracleDataAdapter da = new OracleDataAdapter();
                    DataTable dataTable = new DataTable();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("pMANV", OracleDbType.Varchar2).Value = pMANV.Trim('\'').Trim('-');
                    command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    da.SelectCommand = command;
                    da.Fill(dataTable);
                    DataRow row = dataTable.Rows[0];
                    nhanSu.HOTEN = row["hoten"].ToString();
                    nhanSu.PHAI = row["phai"].ToString()=="M"?"Nam":"Nữ";
                    nhanSu.NGSINH = Convert.ToDateTime(row["ngsinh"]);
                    nhanSu.PHUCAP = Convert.ToInt32(row["phucap"]);
                    nhanSu.DT = row["dt"].ToString();
                    nhanSu.VAITRO = row["vaitro"].ToString();
                    nhanSu.TENDV = row["tendv"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return nhanSu;
        }
        public void CapNhatSDT(string pMANV,string sdt)
        {
            string procedureName = "cap_nhat_sdt_nhan_su";
            try
            {
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    connection.Open();
                    OracleDataAdapter da = new OracleDataAdapter();
                    DataTable dataTable = new DataTable();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("pMANV", OracleDbType.Varchar2).Value = pMANV;
                    command.Parameters.Add("sdt", OracleDbType.Varchar2).Value = sdt;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            MessageBox.Show("Đã cập nhật số điện thoại");
        }
    }
    /*internal class NhanSuBUS
    {
        readonly string connStr = ConfigurationManager.ConnectionStrings["YourNameHere"].ConnectionString;

        public IList<NhanSuDTO> layDSNhanSu()
        {
            List<NhanSuDTO> dsNhanSu = new List<NhanSuDTO>();
            using (OracleConnection connection = new OracleConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand("LayDSNhanSu", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (OracleDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                dsNhanSu.Add(new NhanSuDTO()
                                {
                                    PHUCAP = Convert.ToDouble(Reader["PHUCAP"]),
                                    NGSINH = DateTime.Parse(Reader["date"].ToString()),
                                    MANV = Reader["MANV"].ToString(),
                                    HOTEN = Reader["HOTEN"].ToString(),
                                    PHAI = Reader["PHAI"].ToString(),
                                    DT = Reader["DT"].ToString(),
                                    VAITRO = Reader["VAITRO"].ToString(),
                                    MADV = Reader["MADV"].ToString(),
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    MessageBox.Show("Error");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return dsNhanSu;
        }

        public IList<NhanSuDTO> locNhanVien_Ten(string name)
        {
            List<NhanSuDTO> dsNhanVien = new List<NhanSuDTO>();
            using (OracleConnection connection = new OracleConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand("select * from account_adst where name = @name", connection))
                    {
                        command.Parameters.Add(new OracleParameter("name", OracleDbType.VarChar)).Value = name;
                        using (OracleDataReader Reader = command.ExecuteReader())
                        {

                            while (Reader.Read())
                            {
                                NhanSuDTO nv = new NhanSuDTO();

                                nv.username = Reader.GetString(Reader.GetOrdinal("username"));
                                nv.password = Reader.GetString(Reader.GetOrdinal("password"));
                                nv.name = Reader.GetString(Reader.GetOrdinal("name"));
                                nv.phone = Reader.GetString(Reader.GetOrdinal("phone"));
                                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                                {
                                    nv.email = Reader.GetString(Reader.GetOrdinal("email"));
                                }
                                nv.address = Reader.GetString(Reader.GetOrdinal("address"));
                                nv.gender = Reader.GetBoolean(Reader.GetOrdinal("gender"));
                                nv.admin = Reader.GetBoolean(Reader.GetOrdinal("admin"));

                                dsNhanVien.Add(nv);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    MessageBox.Show("Error");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return dsNhanVien;
        }

        public IList<NhanSuDTO> locNhanVien_Loai(bool admin)
        {
            List<NhanSuDTO> dsNhanVien = new List<NhanSuDTO>();
            using (OracleConnection connection = new OracleConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand("select * from account_adst where admin = @admin", connection))
                    {
                        command.Parameters.Add(new OracleParameter("admin", OracleDbType.VarChar)).Value = admin;
                        using (OracleDataReader Reader = command.ExecuteReader())
                        {

                            while (Reader.Read())
                            {
                                NhanSuDTO nv = new NhanSuDTO();

                                nv.username = Reader.GetString(Reader.GetOrdinal("username"));
                                nv.password = Reader.GetString(Reader.GetOrdinal("password"));
                                nv.name = Reader.GetString(Reader.GetOrdinal("name"));
                                nv.phone = Reader.GetString(Reader.GetOrdinal("phone"));
                                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                                {
                                    nv.email = Reader.GetString(Reader.GetOrdinal("email"));
                                }
                                nv.address = Reader.GetString(Reader.GetOrdinal("address"));
                                nv.gender = Reader.GetBoolean(Reader.GetOrdinal("gender"));
                                nv.admin = Reader.GetBoolean(Reader.GetOrdinal("admin"));

                                dsNhanVien.Add(nv);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    MessageBox.Show("Error");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return dsNhanVien;
        }

        public NhanSuDTO timNhanVien(string username)
        {
            NhanSuDTO nv = new NhanSuDTO();
            using (OracleConnection connection = new OracleConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand("select * from account_adst where username = @username", connection))
                    {
                        command.Parameters.Add(new OracleParameter("username", OracleDbType.VarChar)).Value = username;
                        using (OracleDataReader Reader = command.ExecuteReader())
                        {

                            while (Reader.Read())
                            {
                                nv.username = Reader.GetString(Reader.GetOrdinal("username"));
                                nv.password = Reader.GetString(Reader.GetOrdinal("password"));
                                nv.name = Reader.GetString(Reader.GetOrdinal("name"));
                                nv.phone = Reader.GetString(Reader.GetOrdinal("phone"));
                                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                                {
                                    nv.email = Reader.GetString(Reader.GetOrdinal("email"));
                                }
                                nv.address = Reader.GetString(Reader.GetOrdinal("address"));
                                nv.gender = Reader.GetBoolean(Reader.GetOrdinal("gender"));
                                nv.admin = Reader.GetBoolean(Reader.GetOrdinal("admin"));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    MessageBox.Show("Error");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return nv;
        }

        public void themAdmin_NhanVien(string username, string password, string name, bool gender, bool type, string phone, string email, string address)
        {
            using (OracleConnection connection = new OracleConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand("add_account_adst", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@type", type);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@address", address);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    Console.WriteLine(ex.Message);
                }
            }
            MessageBox.Show("Success");
        }

        public void capNhatNhanVien(string username, string password, string name, string phone, string email, string address, bool gender, bool admin)
        {
            using (OracleConnection connection = new OracleConnection(connStr))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand("update_account_adst", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@admin", admin);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@gender", gender);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            MessageBox.Show("Success");
        }
    }*/
}