using System;
using System.Windows.Forms;
using ATBM.FORM.KeHoachMo;
using ATBM.FORM.PhanCong;
using ATBM.FORM;
using ATBM.FORM.SinhVien;
using ATBM.FORM.ThongBao;
using ATBM.FORM.Hocphan;
using System.Security.Cryptography;

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
                if (role > 0)
                {
                    if (role != 3)
                    {
                        HocPhanDangKy_btn.Hide();
                    }
                    DKHP_btn.Hide();
                }
                if (role == 0 || role == 1 || role == 3)
                {
                    ThongTinLopHoc_btn.Hide();
                    if (role == 0)
                    {
                        PhanCong_btn.Hide();
                        DanhSachDonVi_btn.Hide();
                    }
                }
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
        private void KeHoachMo_btn_Click(object sender, EventArgs e)
        {
            KeHoachMo keHoachMo = new KeHoachMo(role);
            keHoachMo.Show();
        }

        private void ThongTinLopHoc_btn_Click(object sender, EventArgs e)
        {
            ThongTinLopHoc thongTinLopHoc = new ThongTinLopHoc();
            thongTinLopHoc.Show();
        }

        private void PhanCong_btn_Click(object sender, EventArgs e)
        {
            PhanCong phanCong = new PhanCong(role);
            phanCong.Show();
        }

        private void ThongTinCaNhan_btn_Click(object sender, EventArgs e)
        {
            if (role > 0)
            {
                ThongTinCaNhan_NhanSu _NhanSu = new ThongTinCaNhan_NhanSu(username);
                _NhanSu.Show();
            }
            else if (role == 0)
            {
                ThongTinCaNhan_SinhVien _SinhVien = new ThongTinCaNhan_SinhVien(username);
                _SinhVien.Show();
            }
        }

        private void ChiTietThongBao_btn_Click(object sender, EventArgs e)
        {
            XemThongBao xemThongBao = new XemThongBao();
            xemThongBao.Show();
        }

        private void HocPhanDangKy_btn_Click(object sender, EventArgs e)
        {
            KQ_Dang_Ky_HP kq_Dang_Ky_HP = new KQ_Dang_Ky_HP(username);
            kq_Dang_Ky_HP.Show();
        }

        private void DKHP_btn_Click(object sender, EventArgs e)
        {
            DangkyHocphan dangkyHocphan = new DangkyHocphan(username);
            dangkyHocphan.Show();
        }

        private void DanhSac_Click(object sender, EventArgs e)
        {
            DSHocphan dsHocPhan = new DSHocphan(role);
            dsHocPhan.Show();
        }

        private void DanhSachDonVi_btn_Click(object sender, EventArgs e)
        {
            DSDonvi dSDonvi = new DSDonvi(role);
            dSDonvi.Show();
        }

        private void DanhSachSinhVien_btn_Click(object sender, EventArgs e)
        {
            DSSinhvien dSSinhvien = new DSSinhvien(role);
            dSSinhvien.Show();
        }
    }
}
