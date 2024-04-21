using System;
using System.Data;
using System.Windows.Forms;
using ATBM.DTO;
using Oracle.ManagedDataAccess.Client;

namespace ATBM.BUS
{
    internal class SinhVienBUS
    {
        readonly OracleConnection connection = new OracleConnection(Program.connectionString);
        public SinhVienDTO layTTSinhVien(string pMASV)
        {
            string procedureName = "admin_ols1.lay_thong_tin_sinh_vien";
            SinhVienDTO sinhVien = new SinhVienDTO();
            try
            {
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    connection.Open();
                    OracleDataAdapter da = new OracleDataAdapter();
                    DataTable dataTable = new DataTable();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("pMASV", OracleDbType.Varchar2).Value = pMASV.Trim('\'').Trim('-');
                    command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    da.SelectCommand = command;
                    da.Fill(dataTable);
                    if(dataTable.Rows.Count !=1 )
                    {
                        MessageBox.Show("Ugh");
                        return null;
                    }
                    DataRow row = dataTable.Rows[0];
                    sinhVien.HOTEN = row["hoten"].ToString();
                    sinhVien.PHAI = row["phai"].ToString() == "M" ? "Nam" : "Nữ";
                    sinhVien.NGSINH = Convert.ToDateTime(row["ngsinh"]);
                    sinhVien.DCHI = row["dchi"].ToString();
                    sinhVien.DT = row["dt"].ToString();
                    sinhVien.MACT = row["mact"].ToString();
                    sinhVien.MANGANH = row["manganh"].ToString();
                    sinhVien.SOTCTL = Convert.ToInt32(row["sotctl"]);
                    sinhVien.DTBTL = Convert.ToDouble(row["dtbtl"]);
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
            return sinhVien;
        }
        public void cap_nhat_dia_chi_va_sdt_sinh_vien(string pMASV,string diachi,string sdt)
        {
            string procedureName = "admin_ols1.cap_nhat_dia_chi_va_sdt_sinh_vien";
            try
            {
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    connection.Open();
                    OracleDataAdapter da = new OracleDataAdapter();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("pMASV", OracleDbType.Varchar2).Value = pMASV;
                    command.Parameters.Add("diachi", OracleDbType.Varchar2).Value = diachi.Trim().Trim('=');
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
            MessageBox.Show("Đã lưu","Thông báo");
        }
        public void cap_nhat_tt_sinh_vien(SinhVienDTO sinhVien)
        {
            string procedureName = "admin_ols1.cap_nhat_tt_sinh_vien";
            try
            {
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    connection.Open();
                    OracleDataAdapter da = new OracleDataAdapter();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("pMASV", OracleDbType.Varchar2).Value = sinhVien.MASV;
                    command.Parameters.Add("hotensv", OracleDbType.NVarchar2).Value = sinhVien.HOTEN;
                    command.Parameters.Add("phaisv", OracleDbType.Char).Value = sinhVien.PHAI;
                    command.Parameters.Add("ngsinhsv", OracleDbType.Date).Value = sinhVien.NGSINH;
                    command.Parameters.Add("dchisv", OracleDbType.NVarchar2).Value = sinhVien.DCHI;
                    command.Parameters.Add("dtsv", OracleDbType.Varchar2).Value = sinhVien.DT;
                    command.Parameters.Add("mactsv", OracleDbType.Varchar2).Value = sinhVien.MACT;
                    command.Parameters.Add("manganhsv", OracleDbType.Varchar2).Value = sinhVien.MANGANH;
                    command.Parameters.Add("sotctlsv", OracleDbType.Int32).Value = sinhVien.SOTCTL;
                    command.Parameters.Add("dtbtlsv", OracleDbType.Decimal).Value = sinhVien.DTBTL;
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
            MessageBox.Show("Đã cập nhật", "Thông báo");
        }
    }
}
