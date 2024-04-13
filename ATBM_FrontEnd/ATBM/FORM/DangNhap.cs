using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ATBM.FORM.KeHoachMo;

namespace ATBM
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Login_Click_1(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            Program.connectionString += $"User Id={username};Password={password};";
            try
            {
                using (OracleConnection connection = new OracleConnection(Program.connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Login Success");
                    connection.Close();
                    KeHoachMo f = new KeHoachMo();
                    f.ShowDialog();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
