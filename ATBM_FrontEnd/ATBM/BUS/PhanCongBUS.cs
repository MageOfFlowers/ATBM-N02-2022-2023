using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATBM.DTO;
using System.Windows.Forms;
using ATBM.Admin.DTO;

namespace ATBM.BUS
{
    internal class PhanCongBUS
    {
        readonly public OracleConnection connection = new OracleConnection(Program.connectionString);

        public IList<PhanCongDTO> xem_phan_cong()
        {
            string procedureName = "admin_ols1.xem_phan_cong";
            IList<PhanCongDTO> ds = new List<PhanCongDTO>();
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
                        PhanCongDTO obj = new PhanCongDTO();
                        obj.MAGV = row["magv"].ToString();
                        obj.MAHP = row["mahp"].ToString();
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

        public void them_phan_cong(PhanCongDTO pc)
        {
            string procedureName = "admin_ols1.them_phan_cong";
            try
            {
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("m_magv", OracleDbType.Varchar2).Value = pc.MAGV;
                    command.Parameters.Add("m_mahp", OracleDbType.Varchar2).Value = pc.MAHP;
                    command.Parameters.Add("m_hk", OracleDbType.Int32).Value = pc.HK;
                    command.Parameters.Add("m_nam", OracleDbType.Int32).Value = pc.NAM;
                    command.Parameters.Add("m_mact", OracleDbType.Varchar2).Value = pc.MACT;
                    command.ExecuteNonQuery();

                    MessageBox.Show("Thêm thành công");
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

        public void xoa_phan_cong(PhanCongDTO pc)
        {
            string procedureName = "admin_ols1.xoa_phan_cong";
            try
            {
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("m_magv", OracleDbType.Varchar2).Value = pc.MAGV;
                    command.Parameters.Add("m_mahp", OracleDbType.Varchar2).Value = pc.MAHP;
                    command.Parameters.Add("m_hk", OracleDbType.Int32).Value = pc.HK;
                    command.Parameters.Add("m_nam", OracleDbType.Int32).Value = pc.NAM;
                    command.Parameters.Add("m_mact", OracleDbType.Varchar2).Value = pc.MACT;
                    command.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công");
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

        public void sua_phan_cong(PhanCongDTO pc, string magv)
        {
            string procedureName = "admin_ols1.sua_phan_cong";
            try
            {
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("m_magv_cu", OracleDbType.Varchar2).Value = pc.MAGV;
                    command.Parameters.Add("m_magv_moi", OracleDbType.Varchar2).Value = magv;
                    command.Parameters.Add("m_mahp", OracleDbType.Varchar2).Value = pc.MAHP;
                    command.Parameters.Add("m_hk", OracleDbType.Int32).Value = pc.HK;
                    command.Parameters.Add("m_nam", OracleDbType.Int32).Value = pc.NAM;
                    command.Parameters.Add("m_mact", OracleDbType.Varchar2).Value = pc.MACT;

                    MessageBox.Show("Thay đổi thành công");
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
    }
}
