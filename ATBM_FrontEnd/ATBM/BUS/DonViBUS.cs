using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ATBM.DTO;

namespace ATBM.BUS
{
    internal class DonViBUS
    {
        readonly public OracleConnection connection = new OracleConnection(Program.connectionString);
        public IList<DonViDTO> lay_ds_don_vi()
        {
            string procedureName = "admin_ols1.lay_ds_don_vi";
            IList<DonViDTO> dsDonVi = new List<DonViDTO>();
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
                        DonViDTO obj = new DonViDTO();

                        obj.MADV = row["madv"].ToString();
                        obj.TENDV = row["tendv"].ToString();
                        obj.TRGDV = row["trgdv"].ToString();

                        dsDonVi.Add(obj);
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
            return dsDonVi;
        }
    }
}
