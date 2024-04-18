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
                NhanSuBUS ns = new NhanSuBUS();
                string vai_tro = ns.lay_vai_tro();
                MessageBox.Show("Đăng nhập thành công!");
                MessageBox.Show(vai_tro);
                MainMenu f = new MainMenu(username);
                f.ShowDialog();
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
