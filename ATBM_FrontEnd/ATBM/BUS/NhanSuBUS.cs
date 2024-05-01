using System;
using System.Data;
using System.Windows.Forms;
using ATBM.DTO;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ATBM.Admin.DTO;
using System.Collections.Generic;

namespace ATBM.BUS
{
    internal class NhanSuBUS
    {
        OracleConnection connection = new OracleConnection(Program.connectionString);
        public NhanSuDTO LayTTNhanSu(string pMANV)
        {
            string procedureName = "admin_ols1.lay_thong_tin_nhan_su";
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
                    nhanSu.PHAI = row["phai"].ToString() == "M" ? "Nam" : "Nữ";
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
        public void CapNhatSDT(string pMANV, string sdt)
        {
            string procedureName = "admin_ols1.cap_nhat_sdt_nhan_su";
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
            MessageBox.Show("Đã lưu", "Thông báo");
        }
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
                command.CommandType = CommandType.StoredProcedure;
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
            List<NhanSuDTO> dsNhanSu = new List<NhanSuDTO>();
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

        public void them_nhan_su(NhanSuDTO nhansu)
        {
            string procedureName = "admin_ols1.them_nhan_su";
            try
            {
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    connection.Open();
                    OracleDataAdapter da = new OracleDataAdapter();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("m_manv", OracleDbType.Varchar2).Value = nhansu.MANV;
                    command.Parameters.Add("m_hoten", OracleDbType.NVarchar2).Value = nhansu.HOTEN;
                    command.Parameters.Add("m_phai", OracleDbType.Char).Value = nhansu.PHAI;
                    command.Parameters.Add("m_ngsinh", OracleDbType.Date).Value = nhansu.NGSINH;
                    command.Parameters.Add("m_phucap", OracleDbType.Double).Value = nhansu.PHUCAP;
                    command.Parameters.Add("m_dt", OracleDbType.Varchar2).Value = nhansu.DT;
                    command.Parameters.Add("m_vaitro", OracleDbType.Varchar2).Value = nhansu.VAITRO;
                    command.Parameters.Add("m_madv", OracleDbType.Varchar2).Value = nhansu.MADV;
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void xoa_nhan_su(string manv)
        {
            string procedureName = "admin_ols1.xoa_nhan_su";
            try
            {
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    connection.Open();
                    OracleDataAdapter da = new OracleDataAdapter();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("m_manv", OracleDbType.Varchar2).Value = manv;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo");
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
        }

        public void sua_nhan_su(string vaitro_cu, NhanSuDTO nhansu)
        {
            string procedureName = "admin_ols1.sua_nhan_su";
            try
            {
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    connection.Open();
                    OracleDataAdapter da = new OracleDataAdapter();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("m_manv", OracleDbType.Varchar2).Value = nhansu.MANV;
                    command.Parameters.Add("m_hoten", OracleDbType.NVarchar2).Value = nhansu.HOTEN;
                    command.Parameters.Add("m_phai", OracleDbType.Char).Value = nhansu.PHAI;
                    command.Parameters.Add("m_ngsinh", OracleDbType.Date).Value = nhansu.NGSINH;
                    command.Parameters.Add("m_phucap", OracleDbType.Double).Value = nhansu.PHUCAP;
                    command.Parameters.Add("m_dt", OracleDbType.Varchar2).Value = nhansu.DT;
                    command.Parameters.Add("m_vaitro_cu", OracleDbType.Varchar2).Value = vaitro_cu;
                    command.Parameters.Add("m_vaitro_moi", OracleDbType.Varchar2).Value = nhansu.VAITRO;
                    command.Parameters.Add("m_madv", OracleDbType.Varchar2).Value = nhansu.MADV;
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}