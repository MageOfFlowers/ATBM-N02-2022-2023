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

namespace ATBM.BUS
{
    public class AdminBUS
    {
        readonly public OracleConnection connection = new OracleConnection(Program.connectionString);
        
        public DataTable UserList()
        {
            DataTable dataTable = new DataTable();
            string procedureName = "DS_User";
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

        public void AddUser(string username, string password)
        {
            string procedureName = "Tao_User";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("Name", OracleDbType.Varchar2).Value = username;
                command.Parameters.Add("Pasw", OracleDbType.Varchar2).Value = password;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void DeleteUser(string username)
        {
            string procedureName = "Xoa_User";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("Name", OracleDbType.Varchar2).Value = username;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable RoleList()
        {
            DataTable dataTable = new DataTable();
            connection.Open();
            string sqlQuery = "select granted_role, count(grantee) as quantity from dba_role_privs where granted_role in (select granted_role from user_role_privs) group by granted_role";
            using (OracleDataAdapter adapter = new OracleDataAdapter(sqlQuery, connection))
            {
                adapter.Fill(dataTable);
            }
            connection.Close();
            return dataTable;
        }
     
        public void AddRole(string role)
        {
            string procedureName = "Tao_Role";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("Name", OracleDbType.Varchar2).Value = role;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable PrivsList(string username)
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

        public void DeleteRole(string role)
        {
            string procedureName = "Xoa_Role";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("Name", OracleDbType.Varchar2).Value = role;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable TablesList()
        {
            DataTable dataTable = new DataTable();
            string procedureName = "xem_ds_table";
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

        public DataTable CollumnsList(string table)
        {
            DataTable dataTable = new DataTable();
            string sqlQuery = $"select column_name from user_tab_columns where table_name = '{table}'";
            using (OracleDataAdapter adapter = new OracleDataAdapter(sqlQuery, connection))
            {
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        public void AddPrivToUser(string priv,string table,string username,string col,bool withGrant) 
        {
            string procedureName = "cap_quyen_cho_user";
            if (priv == "UPDATE")
            {
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("quyen", OracleDbType.Varchar2).Value = priv;
                    command.Parameters.Add("username", OracleDbType.Varchar2).Value = username;
                    command.Parameters.Add("bang", OracleDbType.Varchar2).Value = table;
                    command.Parameters.Add("tuy_chon", OracleDbType.Boolean).Value = withGrant;
                    command.Parameters.Add("cot", OracleDbType.Varchar2).Value = col;

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("quyen", OracleDbType.Varchar2).Value = priv;
                    command.Parameters.Add("username", OracleDbType.Varchar2).Value = username;
                    command.Parameters.Add("bang", OracleDbType.Varchar2).Value = table;
                    command.Parameters.Add("tuy_chon", OracleDbType.Boolean).Value = withGrant;
                    command.Parameters.Add("cot", OracleDbType.Varchar2).Value = "";

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void AddRoleToUser(string role,string username) 
        {
            string procedureName = "cap_role_cho_user";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("rolename", OracleDbType.Varchar2).Value = role;
                command.Parameters.Add("username", OracleDbType.Varchar2).Value = username;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void ChangeStatus(string username, string status) 
        {
            string procedureName = "Doi_Trangthai_User";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("Name", OracleDbType.Varchar2).Value = username;
                command.Parameters.Add("Status", OracleDbType.Varchar2).Value = status;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void RevokePriv(string priv, string table, string name)
        {
            string procedureName = "Thu_hoi_quyen_UserRole";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("Privilege", OracleDbType.Varchar2).Value = priv;
                command.Parameters.Add("Object", OracleDbType.Varchar2).Value = table;
                command.Parameters.Add("Name", OracleDbType.Varchar2).Value = name;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable UserRole(string username)
        {
            DataTable dataTable = new DataTable();
            string procedureName = "xem_role_user";
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
