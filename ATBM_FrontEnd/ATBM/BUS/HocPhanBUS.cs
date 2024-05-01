using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using ATBM.Admin.DTO;
using ATBM.DTO;

namespace ATBM.BUS
{
    internal class HocPhanBUS
    {
        readonly public OracleConnection connection = new OracleConnection(Program.connectionString);
        public List<HocPhanDTO> layDSHocPhan()
        {
            List<HocPhanDTO> ds = new List<HocPhanDTO>();
            string procedureName = "admin_ols1.lay_ds_hoc_phan";

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
                        HocPhanDTO obj = new HocPhanDTO();
                        obj.MAHP = row["mahp"].ToString();
                        obj.TENHP = row["tenhp"].ToString();
                        obj.SOTC = Convert.ToInt32(row["sotc"]);
                        obj.STLT = Convert.ToInt32(row["stlt"]);
                        obj.STTH = Convert.ToInt32(row["stth"]);
                        obj.SOSVTD = Convert.ToInt32(row["sosvtd"]);
                        obj.MADV = row["madv"].ToString();

                        ds.Add(obj);
                    }
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
            return ds;
        }

        public IList<LopDTO> ds_HocPhanDangKy()
        {
            string procedureName = "admin_ols1.xem_khm_cua_sv";
            IList<LopDTO> ds = new List<LopDTO>();
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
                        LopDTO obj = new LopDTO();
                        obj.MAHP = row["mahp"].ToString();
                        obj.TENHP = row["tenhp"].ToString();
                        obj.HK = Convert.ToInt32(row["hk"]);
                        obj.NAM = Convert.ToInt32(row["nam"]);
                        obj.MACT = row["mact"].ToString();

                        ds.Add(obj);
                    }
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
            return ds;
        }

        public IList<LopDTO> ds_DaDangKy()
        {
            string procedureName = "admin_ols1.xem_khm_da_dk";
            IList<LopDTO> ds = new List<LopDTO>();
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
                        LopDTO obj = new LopDTO();
                        obj.MAHP = row["mahp"].ToString();
                        obj.TENHP = row["tenhp"].ToString();
                        obj.HK = Convert.ToInt32(row["hk"]);
                        obj.NAM = Convert.ToInt32(row["nam"]);
                        obj.MACT = row["mact"].ToString();

                        ds.Add(obj);
                    }
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
            return ds;
        }

        public void dang_ky_hp(string masv, LopDTO lop)
        {
            string procedureName = "admin_ols1.dang_ky_hoc_phan";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("m_masv", OracleDbType.Varchar2).Value = masv;
                command.Parameters.Add("m_mahp", OracleDbType.Varchar2).Value = lop.MAHP;
                command.Parameters.Add("m_hk", OracleDbType.Int32).Value = lop.HK;
                command.Parameters.Add("m_nam", OracleDbType.Int32).Value = lop.NAM;
                command.Parameters.Add("m_mact", OracleDbType.Varchar2).Value = lop.MACT;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void huy_dang_ky(string masv, LopDTO lop)
        {
            string procedureName = "admin_ols1.huy_dang_ky_hoc_phan";
            try
            {
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("m_masv", OracleDbType.Varchar2).Value = masv;
                    command.Parameters.Add("m_mahp", OracleDbType.Varchar2).Value = lop.MAHP;
                    command.Parameters.Add("m_hk", OracleDbType.Int32).Value = lop.HK;
                    command.Parameters.Add("m_nam", OracleDbType.Int32).Value = lop.NAM;

                    command.ExecuteNonQuery();
                    connection.Close();
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
        public void CapNhatHocPhan(HocPhanDTO hocPhan)
        {
            string procedureName = "admin_ols1.cap_nhat_hoc_phan";
            try
            {
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("m_mahp", OracleDbType.Char).Value = hocPhan.MAHP;
                    command.Parameters.Add("m_tenhp", OracleDbType.NVarchar2).Value = hocPhan.TENHP;
                    command.Parameters.Add("m_sotc", OracleDbType.Int32).Value = hocPhan.SOTC;
                    command.Parameters.Add("m_stlt", OracleDbType.Int32).Value = hocPhan.STLT;
                    command.Parameters.Add("m_stth", OracleDbType.Int32).Value = hocPhan.STTH;
                    command.Parameters.Add("m_sosvtd", OracleDbType.Int32).Value = hocPhan.SOSVTD;
                    command.Parameters.Add("m_madv", OracleDbType.Char).Value = hocPhan.MADV;

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                connection.Close();
            }
            MessageBox.Show("Đã cập nhật.", "Thông báo");
        }
    }
}
