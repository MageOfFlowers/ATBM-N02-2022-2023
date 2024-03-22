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

namespace ATBM.BUS
{
    public class AdminBUS
    {
        public OracleConnection connection = new OracleConnection(Program.connectionString);
        
        public DataSet UserList()
        {
            DataSet dataSet = new DataSet();
            connection.Open();
            string sqlQuery = "select user_id, username from dba_users where user_id >= 111 and user_id <= 500";
            using (OracleDataAdapter adapter = new OracleDataAdapter(sqlQuery, connection))
            {
                adapter.Fill(dataSet, "dba_users");
            }
            connection.Close();
            return dataSet;
        }

        public void AddUser(string username, string password, string role)
        {
            connection.Open();
            string sqlQuery1 = $"create user {username} identified by {password}";
            string sqlQuery2 = $"grant {role} to {username}";
            using (OracleCommand command1 = new OracleCommand(sqlQuery1, connection))
            {
                command1.ExecuteNonQuery();
                if (role != "None")
                    using (OracleCommand command2 = new OracleCommand(sqlQuery2, connection))
                    {
                        command2.ExecuteNonQuery();
                    }
            }
            connection.Close();
        }

        public void DeleteUser(string username)
        {
            connection.Open();
            string sqlQuery1 = "alter session set \"_ORACLE_SCRIPT\"=true";
            string sqlQuery2 = $"drop user {username}";
            using (OracleCommand command1 = new OracleCommand(sqlQuery1, connection))
            {
                command1.ExecuteNonQuery();
                using (OracleCommand command2 = new OracleCommand(sqlQuery2, connection))
                {
                    command2.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        public DataSet RoleList()
        {
            DataSet dataSet = new DataSet();
            connection.Open();
            string sqlQuery = "select granted_role as role, count(grantee) as quantity from dba_role_privs where granted_role in (select granted_role from user_role_privs) group by granted_role";
            using (OracleDataAdapter adapter = new OracleDataAdapter(sqlQuery, connection))
            {
                adapter.Fill(dataSet, "roles");
            }
            connection.Close();
            return dataSet;
        }
     
        public void AddRole(string role)
        {
            connection.Open();
            string sqlQuery1 = "alter session set \"_ORACLE_SCRIPT\"=true";
            string sqlQuery2 = $"create role {role}";
            using (OracleCommand command1 = new OracleCommand(sqlQuery1, connection))
            {
                command1.ExecuteNonQuery();
                using (OracleCommand command2 = new OracleCommand(sqlQuery2, connection))
                {
                    command2.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        public DataTable Xem_Quyen(string username)
        {
            DataTable dataTable = new DataTable();
            string procedureName = "xem_quyen_user";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                OracleDataAdapter da = new OracleDataAdapter();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("p_user", OracleDbType.Varchar2).Value = username;
                command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                
                da.SelectCommand = command;
                da.Fill(dataTable);
                connection.Close();
            }
            return dataTable;  
        }
    }
}
