using ATBM.BUS;
using ATBM.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM.FORM
{
    public partial class ThongTinCaNhan_SinhVien : Form
    {
        readonly string masv;
        readonly SinhVienBUS sinhVienBUS=new SinhVienBUS();
        public ThongTinCaNhan_SinhVien(string maSV)
        {
            InitializeComponent();
            masv = maSV;
        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            SinhVienDTO sinhVien = new SinhVienDTO();
            lblHoTen.Text = sinhVien.HOTEN;
            lblPhai.Text = sinhVien.PHAI;
            lblNgaySinh.Text = sinhVien.NGSINH.ToString("dd/MM/yyyy"); ;
            diaChi.Text = sinhVien.DCHI;
            sdt.Text = sinhVien.DT;
            lblMaCT.Text = sinhVien.MACT;
            lblMaNganh.Text = sinhVien.MANGANH;
            lblSTCTL.Text = sinhVien.SOTCTL.ToString();
            lblDTBTL.Text = sinhVien.DTBTL.ToString();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            string dchi=diaChi.Text;
            string dt = sdt.Text;
            if (!Regex.Match(dt, @"^(03|05|07|08|09|01[2|6|8|9])+([0-9]{8})\b$").Success)
            {
                MessageBox.Show("Xin hãy nhập số điện thoại hợp lệ");
            }
            else if(dchi.Trim().Length==0)
            {
                MessageBox.Show("Xin hãy nhập địa chỉ hợp lệ");
            }
            else
            {
                sinhVienBUS.cap_nhat_dia_chi_va_sdt_sinh_vien(masv, dchi, dt);
                ThongTinCaNhan_SinhVien _SinhVien = new ThongTinCaNhan_SinhVien(masv);
                Close();
                _SinhVien.Show();
            }
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Quay lại màn hình chính?", "Quay lại", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
