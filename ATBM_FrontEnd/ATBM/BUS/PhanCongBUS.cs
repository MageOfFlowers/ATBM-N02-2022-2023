using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATBM.DTO;
using System.Windows.Forms;

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
    }
}
