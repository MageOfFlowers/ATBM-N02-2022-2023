using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using ATBM.Admin.DTO;

namespace ATBM.BUS
{
    internal class KHMBUS
    {
        readonly public OracleConnection connection = new OracleConnection(Program.connectionString);

        public IList<LopDTO> ds_KHM()
        {
            string procedureName = "admin_ols1.xem_ds_ke_hoach_mo";
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

        public void themKHM(LopDTO khm)
        {
            string procedureName = "admin_ols1.them_ke_hoach";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("m_mahp", OracleDbType.Varchar2).Value = khm.MAHP;
                command.Parameters.Add("m_hk", OracleDbType.Int32).Value = khm.HK;
                command.Parameters.Add("m_nam", OracleDbType.Int32).Value = khm.NAM;
                command.Parameters.Add("m_mact", OracleDbType.Varchar2).Value = khm.MACT;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void capNhatKHM(LopDTO kh_cu, LopDTO khm)
        {
            string procedureName = "admin_ols1.thay_doi_ke_hoach";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("m_mahp", OracleDbType.Varchar2).Value = khm.MAHP;

                command.Parameters.Add("m_hk_cu", OracleDbType.Int32).Value = kh_cu.HK;
                command.Parameters.Add("m_hk_moi", OracleDbType.Int32).Value = khm.HK;

                command.Parameters.Add("m_nam_cu", OracleDbType.Int32).Value = kh_cu.NAM;
                command.Parameters.Add("m_nam_moi", OracleDbType.Int32).Value = khm.NAM;

                command.Parameters.Add("m_mact_cu", OracleDbType.Varchar2).Value = kh_cu.MACT;
                command.Parameters.Add("m_mact_moi", OracleDbType.Varchar2).Value = khm.MACT;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
