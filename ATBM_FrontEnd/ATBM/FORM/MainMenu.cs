using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATBM.FORM.KeHoachMo;

namespace ATBM
{
    public partial class MainMenu : Form
    {
        int role = 0;
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(string user, int m_role)
        {
            InitializeComponent();
            Label.Text = $"Xin chào {user}";
            role = m_role;

            if (role >= 0)
            {
                if (role != 0)
                {
                    HocPhanDangKy_btn.Hide();
                }
                if (role == 0 || role == 1 || role == 3)
                {
                    ThongTinLopHoc_btn.Hide();
                    ThoiKhoaBieu_btn.Hide();
                }
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void KeHoachMo_btn_Click(object sender, EventArgs e)
        {
            KeHoachMo f = new KeHoachMo(role);
            f.ShowDialog();
        }
    }
}
