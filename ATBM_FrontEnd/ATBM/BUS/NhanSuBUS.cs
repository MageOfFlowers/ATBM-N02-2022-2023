using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATBM.DTO;
using System.Windows.Forms;
using System.Drawing;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ATBM.Admin.DTO;

namespace ATBM.BUS
{
    internal class NhanSuBUS
    {
        readonly public OracleConnection connection = new OracleConnection(Program.connectionString);

        public int lay_vai_tro()
        {
            string procedureName = "admin_ols1.xem_vai_tro";
            string vai_tro_str = "";
            int vai_tro = 0;
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                OracleDataAdapter da = new OracleDataAdapter();
                DataTable dataTable = new DataTable();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                da.SelectCommand = command;
                da.Fill(dataTable);

                vai_tro_str = dataTable.Rows[0].ItemArray[0].ToString();
                connection.Close();
            }
            if (vai_tro_str == "Sinh vien")
                vai_tro = 0;
            else if (vai_tro_str == "Nhan vien co ban")
                vai_tro = 1;
            else if (vai_tro_str == "Giang vien")
                vai_tro = 2;
            else if (vai_tro_str == "Giao vu")
                vai_tro = 3;
            else if (vai_tro_str == "Truong don vi")
                vai_tro = 4;
            else if (vai_tro_str == "Truong khoa")
                vai_tro = 5;

            return vai_tro;
        }

        public IList<NhanSuDTO> LayDSNhanSu()
        {
            string procedureName = "admin_ols1.lay_ds_nhan_su";
            List <NhanSuDTO> dsNhanSu = new List<NhanSuDTO>();
            try
            {
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    connection.Open();
                    OracleDataAdapter da = new OracleDataAdapter();
                    DataTable dataTable = new DataTable();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    da.SelectCommand = command;
                    da.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        NhanSuDTO obj = new NhanSuDTO();
                        obj.MANV = row["manv"].ToString();
                        obj.HOTEN = row["hoten"].ToString();
                        obj.PHAI = row["phai"].ToString(); ;
                        obj.NGSINH = Convert.ToDateTime(row["ngsinh"]);
                        obj.PHUCAP = Convert.ToDouble(row["phucap"]);
                        obj.DT = row["dt"].ToString();
                        obj.VAITRO = row["vaitro"].ToString();
                        obj.MADV = row["madv"].ToString();

                        dsNhanSu.Add(obj);
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
            return dsNhanSu;
        }
        /*
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
        }*/
    }
}