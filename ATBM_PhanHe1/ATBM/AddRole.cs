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
    public partial class AddRole : Form
    {
        public AddRole()
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
                    string sqlQuery2 = $"create role {RoleName.Text}";
                    using (OracleCommand command1 = new OracleCommand(sqlQuery1, connection))
                    {
                        command1.ExecuteNonQuery();
                        using (OracleCommand command2 = new OracleCommand(sqlQuery2, connection))
                        {
                            command2.ExecuteNonQuery();
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

        private void AddRole_Load(object sender, EventArgs e)
        {

        }
    }
}
