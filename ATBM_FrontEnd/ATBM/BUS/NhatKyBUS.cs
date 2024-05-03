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

namespace ATBM.BUS
{
    internal class NhatKyBUS
    {
        public OracleConnection connection = new OracleConnection(Program.connectionString);
        public IList<NhatKyDTO> LayNhatKy()
        {
            List<NhatKyDTO> dsNhatKy = new List<NhatKyDTO>();
            string procedureName = "xem_nhat_ky";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                DataTable ds = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                da.SelectCommand = command;
                da.Fill(ds);

                foreach (DataRow row in ds.Rows)
                {
                    NhatKyDTO NhatKy = new NhatKyDTO();
                    NhatKy.dbusername = row["dbusername"].ToString();
                    NhatKy.action_name = row["action_name"].ToString();
                    NhatKy.object_schema = row["object_schema"].ToString();
                    NhatKy.object_name = row["object_name"].ToString();
                    NhatKy.return_code = row["return_code"].ToString();
                    NhatKy.event_timestamp = row["event_timestamp"].ToString();
                    if (NhatKy.return_code == "0")
                    {
                        NhatKy.return_code = "Thành công";
                    }
                    else
                    {
                        NhatKy.return_code = "Thất bại";
                    }
                    if (NhatKy.unified_audit_policies == null)
                    {
                        NhatKy.unified_audit_policies = "Standard";
                    }
                    else
                    {
                        NhatKy.unified_audit_policies = "Unified";
                    }

                    dsNhatKy.Add(NhatKy);
                }

                connection.Close();
            }
            return dsNhatKy;
        }
        public void BatGhiNhatKy(bool bat)
        {

            
        }
    }
}
