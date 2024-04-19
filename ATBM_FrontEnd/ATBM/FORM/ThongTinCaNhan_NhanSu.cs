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

namespace ATBM
{
    public partial class ThongTinCaNhan_NhanSu : Form
    {
        readonly NhanSuBUS NhanSuBUS=new NhanSuBUS();
        readonly string manv;
        public ThongTinCaNhan_NhanSu(string pMANV)
        {
            InitializeComponent();
            manv = pMANV;
        }

        private void ThongTinCaNhan_NhanSu_Load(object sender, EventArgs e)
        {
            NhanSuDTO NhanSu=NhanSuBUS.LayTTNhanSu(manv);
            lblHoTen.Text = NhanSu.HOTEN;
            sdt.Text = NhanSu.DT;
            lblPhai.Text = NhanSu.PHAI;
            lblNgaySinh.Text = NhanSu.NGSINH.ToString("dd/MM/yyyy");
            lblPhuCap.Text = NhanSu.PHUCAP.ToString();
            lblVaitro.Text = NhanSu.VAITRO;
            lblDonVi.Text = NhanSu.TENDV;
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Quay lại màn hình chính?","Quay lại", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            string dt = sdt.Text;
            if (Regex.Match(dt, @"^(03|05|07|08|09|01[2|6|8|9])+([0-9]{8})\b$").Success)
            {
                NhanSuBUS.CapNhatSDT(manv, dt);
                ThongTinCaNhan_NhanSu _NhanSu = new ThongTinCaNhan_NhanSu(manv);
                Close();
                _NhanSu.Show();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập số điện thoại hợp lệ");
            }
            
        }
    }
}
