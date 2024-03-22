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
using ATBM.BUS;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATBM
{
    public partial class AddUser : Form
    {
        AdminBUS adminBUS = new AdminBUS();
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                adminBUS.AddUser(Username.Text, Password.Text, Role.SelectedItem.ToString());
                MessageBox.Show("Success");
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
            try
            {
                using (OracleConnection connection = new OracleConnection(Program.connectionString))
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
