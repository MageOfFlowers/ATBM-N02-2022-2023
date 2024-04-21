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

namespace ATBM.FORM.SinhVien
{
    public partial class TTSinhVien : Form
    {
        readonly SinhVienBUS sinhVienBUS=new SinhVienBUS();
        readonly DonViBUS donViBUS=new DonViBUS();
        string masv;
        int role;
        public TTSinhVien(string maSV,int r)
        {
            InitializeComponent();
            masv = maSV;
            role = r;
        }

        private void TTSinhVien_Load(object sender, EventArgs e)
        {
            SinhVienDTO sinhVien = sinhVienBUS.layTTSinhVien(masv);
            lblMaSV.Text = masv;
            txtHoTen.Text = sinhVien.HOTEN;

            cbPhai.Items.Clear();
            cbPhai.Items.Add("Nam");
            cbPhai.Items.Add("Nữ");
            cbPhai.SelectedIndex = sinhVien.PHAI == "M" ? 0 : 1;

            ngaySinh.Value = sinhVien.NGSINH;
            diaChi.Text = sinhVien.DCHI;
            sdt.Text = sinhVien.DT;

            cbMaCT.Items.Clear();
            cbMaCT.Items.Add("CLC");
            cbMaCT.Items.Add("VP");
            cbMaCT.Items.Add("CQ");
            cbMaCT.Items.Add("CTTT");
            cbMaCT.SelectedIndex = cbMaCT.FindStringExact(sinhVien.MACT);

            cbMaNganh.Items.Clear();
            cbMaNganh.Items.Add("HTTT");
            cbMaNganh.Items.Add("CNPM");
            cbMaNganh.Items.Add("KHMT");
            cbMaNganh.Items.Add("CNTT");
            cbMaNganh.Items.Add("TGMT");
            cbMaNganh.Items.Add("MMT");
            cbMaNganh.SelectedIndex = cbMaNganh.FindStringExact(sinhVien.MANGANH);

            numSTCTL.Value = sinhVien.SOTCTL;
            numDTBTL.Value = Convert.ToDecimal(sinhVien.DTBTL);

            CtrlSV.Enabled = (role == 3);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SinhVienDTO sinhVien = new SinhVienDTO()
            {
                MASV = masv,
                HOTEN = txtHoTen.Text,
                PHAI = cbPhai.SelectedIndex == 0 ? "M" : "F",
                NGSINH = ngaySinh.Value,
                DCHI = diaChi.Text,
                DT = sdt.Text,
                MACT = cbMaCT.SelectedItem.ToString(),
                MANGANH = cbMaNganh.SelectedItem.ToString(),
                SOTCTL = Convert.ToInt32(numSTCTL.Value),
                DTBTL = Convert.ToDouble(numDTBTL.Value)
            };
            if(sinhVien.HOTEN.Trim().Length<=0)
            {
                MessageBox.Show("Xin nhập tên", "Cảnh báo");
            }
            else if(sinhVien.DCHI.Trim().Length<=0)
            {
                MessageBox.Show("Xin nhập địa chỉ", "Cảnh báo");
            }
            else if (sinhVien.DT.Trim().Length <= 0)
            {
                MessageBox.Show("Xin nhập số điện thoại", "Cảnh báo");
            }
            else if (!Regex.Match(sinhVien.DT, @"^(03|05|07|08|09|01[2|6|8|9])+([0-9]{8})\b$").Success)
            {
                MessageBox.Show("Xin nhập số điện thoại hợp lệ", "Cảnh báo");
            }
            else
            {
                sinhVienBUS.cap_nhat_tt_sinh_vien(sinhVien);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Quay lại màn hình chính?", "Quay lại", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
