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
using ATBM.BUS;
using ATBM.Admin;


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
            OracleConnection connection = new OracleConnection(Program.connectionString);
            try
            {
                int vai_tro = 0;
                if (username.Equals("admin_ols1", StringComparison.OrdinalIgnoreCase))
                {
                    vai_tro = -1;
                    connection.Open();
                    connection.Close();
                }
                else
                {
                    NhanSuBUS ns = new NhanSuBUS();
                    vai_tro = ns.lay_vai_tro();
                }
                MessageBox.Show("Đăng nhập thành công!");
                if (vai_tro == -1)
                {
                    Form1 m = new Form1();
                    m.ShowDialog();
                }
                else
                {
                    MainMenu m = new MainMenu(username, vai_tro);
                    m.ShowDialog();
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
