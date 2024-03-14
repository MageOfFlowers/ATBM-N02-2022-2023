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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ATBM
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-SF4GJF11;User Id=tai211003;Password=tai62506716;";
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "select user_id, username from dba_users where account_status = 'OPEN' and user_id >= 116 and username != 'SYSRAC'";
                    using (OracleDataAdapter adapter = new OracleDataAdapter(sqlQuery, connection))
                    {
                        // Tạo DataSet để chứa dữ liệu
                        DataSet dataSet = new DataSet();

                        // Đổ dữ liệu từ OracleDataAdapter vào DataSet
                        adapter.Fill(dataSet, "dba_users");

                        // Hiển thị dữ liệu trong DataGridView
                        UserList.DataSource = dataSet.Tables["dba_users"];
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

            UserList.Columns.Add(editColumn);
            UserList.Columns.Add(deleteColumn);
        }

        private void UserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }
    }
}
