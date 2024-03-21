using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBM.BUS
{
    public class AdminBUS
    {
        public OracleConnection connection = new OracleConnection(Program.connectionString);
        
        public DataSet UserList()
        {
            DataSet dataSet = new DataSet();
            connection.Open();
            string sqlQuery = "select u.user_id id, u.username username, r.granted_role role from dba_users u join dba_role_privs r on u.username = r.grantee where u.account_status = 'OPEN' and u.user_id >= 116 and u.username != 'SYSRAC' and r.granted_role in (select granted_role from user_role_privs)";
            using (OracleDataAdapter adapter = new OracleDataAdapter(sqlQuery, connection))
            {
                adapter.Fill(dataSet, "dba_users");
            }
            connection.Close();
            return dataSet;
        }
    }
}
