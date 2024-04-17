using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATBM.DTO;
using System.Windows.Forms;
using System.Data.Linq.Mapping;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ATBM.BUS
{
    internal class KHMBUS
    {
        public OracleConnection connection = new OracleConnection(Program.connectionString);

        public IList<KHMDTO> ds_KHM()
        {
            string procedureName = "xem_ds_ke_hoach_mo";
            IList<KHMDTO> ds = new List<KHMDTO>();
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
                        KHMDTO obj = new KHMDTO();
                        obj.MAHP = row["mahp"].ToString();
                        obj.TENHP = row["tenhp"].ToString();
                        obj.HOCKY = Convert.ToInt32(row["hk"]);
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

        public void themKHM(KHMDTO khm)
        {
            string procedureName = "them_ke_hoach";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("m_mahp", OracleDbType.Varchar2).Value = khm.MAHP;
                command.Parameters.Add("m_hk", OracleDbType.Int32).Value = khm.HOCKY;
                command.Parameters.Add("m_nam", OracleDbType.Int32).Value = khm.NAM;
                command.Parameters.Add("m_mact", OracleDbType.Varchar2).Value = khm.MACT;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void capNhatKHM(KHMDTO khm)
        {
            string procedureName = "thay_doi_ke_hoach";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("m_mahp", OracleDbType.Varchar2).Value = khm.MAHP;
                command.Parameters.Add("m_hk", OracleDbType.Int32).Value = khm.HOCKY;
                command.Parameters.Add("m_nam", OracleDbType.Int32).Value = khm.NAM;
                command.Parameters.Add("m_mact", OracleDbType.Varchar2).Value = khm.MACT;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
