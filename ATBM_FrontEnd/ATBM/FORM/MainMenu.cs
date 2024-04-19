using System;
using System.Windows.Forms;
using ATBM.FORM.KeHoachMo;
using ATBM.FORM;

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
                    PhanCong_btn.Hide();
                    DanhSachDonVi_btn.Hide();
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

        private void ThongTinLopHoc_btn_Click(object sender, EventArgs e)
        {
            ThongTinLopHoc f = new ThongTinLopHoc();
            f.ShowDialog();
        }

        private void PhanCong_btn_Click(object sender, EventArgs e)
        {
            PhanCong f = new PhanCong(role);
            f.ShowDialog();
        }
    }
}
