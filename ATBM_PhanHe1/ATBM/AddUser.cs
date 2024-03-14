using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATBM
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-SF4GJF11;User Id=tai211003;Password=tai62506716;";
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery1 = "alter session set \"_ORACLE_SCRIPT\"=true";
                    string sqlQuery2 = $"create user {Username.Text} identified by {Password.Text}";
                    string sqlQuery3 = $"grant {Role.SelectedItem} to {Username.Text}";
                    using (OracleCommand command1 = new OracleCommand(sqlQuery1, connection))
                    {
                        command1.ExecuteNonQuery();
                        using (OracleCommand command2 = new OracleCommand(sqlQuery2, connection))
                        {
                            command2.ExecuteNonQuery();
                            if (Role.SelectedItem != "None")
                                using (OracleCommand command3 = new OracleCommand(sqlQuery3, connection))
                                {
                                    command3.ExecuteNonQuery();
                                }
                        }
                    }
                    MessageBox.Show("Success");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            Role.Items.Add("None");
            Role.SelectedItem = "None";
            string connectionString = "Data Source=LAPTOP-SF4GJF11;User Id=tai211003;Password=tai62506716;";
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "select distinct granted_role from user_role_privs";
                    using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Role.Items.Add(reader["granted_role"].ToString());
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
