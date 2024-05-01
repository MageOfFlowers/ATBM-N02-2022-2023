using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBM.BUS
{
    internal class ThongBaoBUS
    {
        readonly public OracleConnection connection = new OracleConnection(Program.connectionString);
        public DataTable LayThongBao()
        {
            DataTable dataTable = new DataTable();
            string sqlQuery = "select * from admin_ols1.thongbao";
            try
            {
                using (OracleDataAdapter adapter = new OracleDataAdapter(sqlQuery, connection))
                {
                    connection.Open();
                    adapter.Fill(dataTable);
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
            return dataTable;
        }
    }
}
