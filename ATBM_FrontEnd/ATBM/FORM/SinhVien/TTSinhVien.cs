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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATBM.FORM.SinhVien
{
    public partial class TTSinhVien : Form
    {
        readonly SinhVienBUS sinhVienBUS=new SinhVienBUS();
        readonly DonViBUS donViBUS=new DonViBUS();
        private bool Them;
        public TTSinhVien(SinhVienDTO sv)
        {
            InitializeComponent();
            loadComponent(sv);
            Them = false;
        }

        public TTSinhVien()
        {
            InitializeComponent();
            loadComboBox();
            generateMaSV();
            btnCapNhat.Text = "Thêm";
            Them = true;
        }

        private void generateMaSV()
        {
            List<string> ds = sinhVienBUS.lay_danh_sach_sinh_vien().Select(sv => sv.MASV).ToList();
            
            int maxId = ds
            .Select(id => int.Parse(id.Substring(2)))
            .Max();

            int newId = maxId + 1;
            string masv = "SV" + newId.ToString("D3");

            lblMaSV.Text = masv;
        }

        private void loadComboBox()
        {

            cbPhai.Items.Clear();
            cbPhai.Items.Add("Nam");
            cbPhai.Items.Add("Nữ");
            cbPhai.SelectedIndex = 0;

            cbMaCT.Items.Clear();
            cbMaCT.Items.Add("CLC");
            cbMaCT.Items.Add("VP");
            cbMaCT.Items.Add("CQ");
            cbMaCT.Items.Add("CTTT");
            cbMaCT.SelectedIndex = 0;

            IList<DonViDTO> dsDonVi = donViBUS.lay_ds_don_vi();

            foreach (DonViDTO d in dsDonVi)
            {
                if (d.MADV.Trim().ToUpper() != "VPK")
                {
                    cbMaNganh.Items.Add(d.MADV.Trim().ToUpper());
                }
            }
            cbMaNganh.SelectedIndex = 0;
        }

        private void loadComponent(SinhVienDTO sinhVien)
        {
            loadComboBox();

            lblMaSV.Text = sinhVien.MASV;
            txtHoTen.Text = sinhVien.HOTEN;

            cbPhai.SelectedIndex = sinhVien.PHAI == "Nam" ? 0 : 1;

            ngaySinh.Value = sinhVien.NGSINH;
            diaChi.Text = sinhVien.DCHI;
            sdt.Text = sinhVien.DT;

            cbMaCT.SelectedIndex = cbMaCT.FindStringExact(sinhVien.MACT);

            cbMaNganh.SelectedIndex = cbMaNganh.FindStringExact(sinhVien.MANGANH.Trim().ToUpper());


            numSTCTL.Value = sinhVien.SOTCTL;
            numDTBTL.Value = Convert.ToDecimal(sinhVien.DTBTL);
        }

        private void TTSinhVien_Load(object sender, EventArgs e)
        {        
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SinhVienDTO sinhVien = new SinhVienDTO()
            {
                MASV = lblMaSV.Text,
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
                if (Them)
                {
                    sinhVienBUS.them_sinh_vien(sinhVien);
                }
                else
                {
                    sinhVienBUS.cap_nhat_tt_sinh_vien(sinhVien);
                }
                Close();
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
