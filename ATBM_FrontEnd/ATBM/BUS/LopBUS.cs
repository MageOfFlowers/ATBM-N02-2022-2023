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
using System.Security.Cryptography;
using ATBM.Admin.DTO;
using ATBM.DTO;

namespace ATBM.Admin.BUS
{
    internal class LopBUS
    {
        readonly public OracleConnection connection = new OracleConnection(Program.connectionString);

        public IList<LopDTO> layDSLop()
        {
            List<LopDTO> dsLop = new List<LopDTO>();
            string procedureName = "lay_ds_lop";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                DataTable ds = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                da.SelectCommand = command;
                da.Fill(ds);

                foreach(DataRow row in ds.Rows)
                {
                    LopDTO lop = new LopDTO();
                    lop.MAHP = row["mahp"].ToString();
                    lop.TENHP = row["tenhp"].ToString();
                    lop.HK= Convert.ToInt32(row["hk"]);
                    lop.NAM = Convert.ToInt32(row["nam"]);
                    lop.MACT = row["mact"].ToString();

                    dsLop.Add(lop);
                }

                connection.Close();
            }
            return dsLop;
        }
    }
}
