using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATBM.DTO;

namespace ATBM.BUS
{
    internal class HocPhanBUS
    {
        readonly public OracleConnection connection = new OracleConnection(Program.connectionString);
        public IList<HocPhanDTO> dsHocPhan()
        {

            string procedureName = "admin_ols1.xem_ds_hoc_phan";
            IList<HocPhanDTO> ds = new List<HocPhanDTO>();
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
    }
}
