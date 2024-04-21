using System;
using System.Windows.Forms;
using ATBM.FORM.KeHoachMo;
using ATBM.FORM.PhanCong;
using ATBM.FORM;
using ATBM.FORM.SinhVien;

namespace ATBM
{
    public partial class MainMenu : Form
    {
        int role = 0;
        string username;
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(string user, int m_role)
        {
            InitializeComponent();
            Label.Text = $"Xin chào {user}";
            username = user;
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

        private void ThongTinCaNhan_btn_Click(object sender, EventArgs e)
        {
            TTSinhVien sinhVien = new TTSinhVien("SV001",3);
            sinhVien.Show();
            //if (role>0)
            //{
            //    ThongTinCaNhan_NhanSu _NhanSu = new ThongTinCaNhan_NhanSu(username);
            //    _NhanSu.Show();
            //}
            //else if (role==0)
            //{
            //    ThongTinCaNhan_SinhVien _SinhVien = new ThongTinCaNhan_SinhVien(username);
            //    _SinhVien.Show();
            //}
        }
    }
}
