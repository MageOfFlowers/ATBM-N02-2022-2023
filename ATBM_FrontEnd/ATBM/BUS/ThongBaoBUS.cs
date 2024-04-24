using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace ATBM.BUS
{
    internal class ThongBaoBUS
    {
        readonly public OracleConnection connection = new OracleConnection(Program.connectionString);
        public DataTable LayThongBao()
        {
            DataTable dataTable = new DataTable();
            string procedureName = "admin_ols1.lay_thong_bao";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                OracleDataAdapter da = new OracleDataAdapter();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand = command;

                da.Fill(dataTable);
                connection.Close();
            }
            return dataTable;
        }
    }
}
