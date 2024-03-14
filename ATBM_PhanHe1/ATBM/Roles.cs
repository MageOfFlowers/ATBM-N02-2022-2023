using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBM
{
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRole addRole = new AddRole();
            addRole.Show();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-SF4GJF11;User Id=tai211003;Password=tai62506716;";
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "select granted_role as role, count(username) as quantity from user_role_privs group by granted_role";
                    using (OracleDataAdapter adapter = new OracleDataAdapter(sqlQuery, connection))
                    {
                        // Tạo DataSet để chứa dữ liệu
                        DataSet dataSet = new DataSet();

                        // Đổ dữ liệu từ OracleDataAdapter vào DataSet
                        adapter.Fill(dataSet, "user_role_privs");

                        // Hiển thị dữ liệu trong DataGridView
                        RoleList.DataSource = dataSet.Tables["user_role_privs"];
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;

            RoleList.Columns.Add(editColumn);
            RoleList.Columns.Add(deleteColumn);
        }
    }
}
