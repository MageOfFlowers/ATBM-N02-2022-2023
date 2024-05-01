using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ATBM.DTO;
using System.CodeDom.Compiler;
using System.Text.RegularExpressions;

namespace ATBM.BUS
{
    public class AdminBUS
    {
        readonly public OracleConnection connection = new OracleConnection(Program.connectionString);
        
        public IList<string> UserList2()
        {
            List<string> ds = new List<string>();          
            string procedureName = "DS_User";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                DataTable dataTable = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                da.SelectCommand = command;
                da.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    string tmp = row["USERNAME"].ToString();
                    ds.Add(tmp);
                }
                    connection.Close();
            }
            return ds;
        }

        public IList<string> TablesList2()
        {
            List<string> ds = new List<string>();
            string procedureName = "xem_ds_table";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                DataTable dataTable = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                da.SelectCommand = command;
                da.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    string tmp = row["table_name"].ToString();
                    ds.Add(tmp);
                }
                connection.Close();
            }
            return ds;
        }

        public IList<string> ProcList()
        {
            List<string> ds = new List<string>();
            string procedureName = "DS_Proc";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                DataTable dataTable = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                da.SelectCommand = command;
                da.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    string tmp = row["object_name"].ToString();
                    ds.Add(tmp);
                }
                connection.Close();
            }
            return ds;
        }


        public DataTable RoleList2()
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

        public DataTable AuditPolicyList()
        {
            DataTable dataTable = new DataTable();
            string procedureName = "lay_ds_audit_policy";
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

        public void ThayDoi(bool bat, string policy)
        {
            string STRSQL = "";
            if (bat) { STRSQL = "NOAUDIT policy "+policy; }
            else { 
                STRSQL = "AUDIT policy " + policy; 
            }
            string pattern = @"(SV\d+|NV\d+)";
            Match match = Regex.Match(policy, pattern);
            string id = match.Value;
            char last = policy.Last();
            STRSQL += " BY " + id;
            if (last == '1') { STRSQL += " whenever successful"; }
            else if (last == '0') { STRSQL += " whenever not successful"; }
            Console.WriteLine(STRSQL);
            using (OracleCommand command = new OracleCommand(STRSQL, connection))
            {
                connection.Open();
                    
                    command.ExecuteNonQuery();
                
                connection.Close();
            }
        }
        public IList<string> ViewList()
        {
            List<string> ds = new List<string>();
            string procedureName = "DS_View";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                DataTable dataTable = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                da.SelectCommand = command;
                da.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    string tmp = row["view_name"].ToString();
                    ds.Add(tmp);
                }
                connection.Close();
            }
            return ds;
        }

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

        public bool NhatKyCoHoatDong()
        {
            bool bat;
            string procedureName = "NhatKyCoHoatDong";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("c1", OracleDbType.Boolean).Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                bat = (command.Parameters["c1"].Value.ToString() == "true");
                Console.WriteLine(bat);
                connection.Close();
            }
            return bat;
        }

        public void ThayDoiHoatDong(bool bat)
        {
            string STRSQL="";
            if ( bat ) { STRSQL = "ALTER SYSTEM SET audit_trail = none SCOPE = SPFILE"; }
            else { STRSQL = "ALTER SYSTEM SET audit_trail = db SCOPE = SPFILE"; }
            using (OracleCommand command = new OracleCommand(STRSQL, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void ThemThongBao(string noidung, string level, string compartment, string group)
        {
            string procedureName = "tao_thongbao";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("noidung", OracleDbType.Varchar2).Value = noidung;
                command.Parameters.Add("level", OracleDbType.Varchar2).Value = level;
                command.Parameters.Add("compartment", OracleDbType.Varchar2).Value = compartment;
                command.Parameters.Add("p_group", OracleDbType.Varchar2).Value = group;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void GanNhan(string noidung, string level, string compartment, string group)
        {
            string procedureName = "gan_nhan";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("user", OracleDbType.Varchar2).Value = noidung;
                command.Parameters.Add("level", OracleDbType.Varchar2).Value = level;
                command.Parameters.Add("compartment", OracleDbType.Varchar2).Value = compartment;
                command.Parameters.Add("p_group", OracleDbType.Varchar2).Value = group;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void BatGhiNhatKy(string doituong, string nguoidung, string hanhdong, string trangthai)
        {
            if (hanhdong == "To Table/View") { hanhdong = "all"; }
            if (trangthai == "Mọi lúc") { trangthai = "all"; }
            else if (trangthai == "Thành công") { trangthai = "whenever successful"; }
            else if (trangthai == "Thất bại") { trangthai = "whenever not successful"; }

            string pol = doituong + nguoidung + hanhdong + "_policy";
            if (trangthai == "whenever successful") { pol += "1"; }
            else if (trangthai == "whenever not successful") { pol += "0"; }
            else { pol += "2"; }



            string STRSQL = "CREATE AUDIT POLICY " + pol + " ACTIONS " + hanhdong + " ON " + doituong;

            string STRSQL2 = "AUDIT POLICY " + pol;
            if (nguoidung != "") { 
                STRSQL2 += " BY " + nguoidung; }
            if (trangthai != "all") {
                STRSQL2 += ' ' + trangthai; }
            Console.WriteLine(STRSQL);
            using (OracleCommand command = new OracleCommand(STRSQL, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            Console.WriteLine(STRSQL2);
            using (OracleCommand command = new OracleCommand(STRSQL2, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
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

        public string LevelLabel(string p_user)
        {
            string ds = "";
            string procedureName = "xem_user_level";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                DataTable dataTable = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("p_user", OracleDbType.Varchar2).Value = p_user;
                command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                da.SelectCommand = command;
                da.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    ds = row["row_level"].ToString();
                    if (ds == "TK") { ds = "Trưởng khoa"; }
                    else if (ds == "TDV") { ds = "Trưởng đơn vị"; }
                    else if (ds == "GVien") { ds = "Giảng viên"; }
                    else if (ds == "GVu") { ds = "Giáo vụ"; }
                    else if (ds == "NV") { ds = "Nhân viên"; }
                    else if (ds == "SV") { ds = "Sinh viên"; }
                }
                connection.Close();
            }
            return ds;
        }

        public IList<string> CompartmentLabel(string p_user)
        {
            List<string> ds = new List<string>();
            string procedureName = "xem_user_compartment";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                DataTable dataTable = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("p_user", OracleDbType.Varchar2).Value = p_user;
                command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                da.SelectCommand = command;
                da.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    string tmp = row["comp"].ToString();
                    ds.Add(tmp);
                }
                connection.Close();
            }
            return ds;
        }

        public IList<string> GroupLabel(string p_user)
        {
            List<string> ds = new List<string>();
            string procedureName = "xem_user_group";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                DataTable dataTable = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("p_user", OracleDbType.Varchar2).Value = p_user;
                command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                da.SelectCommand = command;
                da.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    string tmp = row["grp"].ToString();
                    if (tmp == "CS1") { tmp = "Cơ sở 1"; }
                    else if (tmp == "CS2") { tmp = "Cơ sở 2"; }
                    ds.Add(tmp);
                }
                connection.Close();
            }
            return ds;
        }
    }

}
