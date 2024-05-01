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
using ATBM.BUS;
using ATBM.DTO;
using ATBM.FORM.KeHoachMo;
using ATBM.FORM.SinhVien;

namespace ATBM.FORM.Donvi
{
    public partial class ThongtinNhansu : Form
    {
        NhanSuBUS nhanSuBUS = new NhanSuBUS();
        DonViBUS donViBUS = new DonViBUS();
        bool Them;
        string madv;
        string vaitro_cu;
        public ThongtinNhansu(string m_madv)
        {
            InitializeComponent();
            madv = m_madv;
            LoadDGV(madv);
            LoadPanel();
        }

        private void LoadPanel()
        {
            NgaySinh_dtp.Format = DateTimePickerFormat.Custom;
            NgaySinh_dtp.CustomFormat = "dd/MM/yyyy";

            PhaiCB.Items.Add("Nam");
            PhaiCB.Items.Add("Nữ");

            VaiTroCB.Items.Add("Nhan vien co ban");
            VaiTroCB.Items.Add("Giang vien");
            VaiTroCB.Items.Add("Giao vu");
            VaiTroCB.Items.Add("Truong don vi");

            IList<DonViDTO> dsDonVi = donViBUS.lay_ds_don_vi();
            foreach (DonViDTO d in dsDonVi)
            {
                DonViCB.Items.Add(d.MADV.Trim().ToUpper());
            }
        }

        private void ResetPanel()
        {
            HoTen_txt.Clear();
            PhaiCB.SelectedIndex = 0;
            PhuCap_num.Value = 0;
            DienThoai_txt.Clear();
            VaiTroCB.SelectedIndex = 0;
            DonViCB.SelectedIndex = 0;
        }
        private void LoadData(string madv)
        {
            IList<NhanSuDTO> ds = nhanSuBUS.LayDSNhanSu();
            TTNhansu_DGV.DataSource = ds.Where(n => n.MADV == madv).ToList();
            TTNhansu_DGV.Columns["TENDV"].Visible = false;
            TTNhansu_DGV.Columns["display"].Visible = false;
        }

        private void LoadDGV(string madv)
        {
            LoadData(madv);
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "Edit";
            editColumn.HeaderText = "Sửa";
            editColumn.Text = "Sửa";
            editColumn.UseColumnTextForButtonValue = true;
            TTNhansu_DGV.Columns.Add(editColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "Delete";
            deleteColumn.HeaderText = "Xóa";
            deleteColumn.Text = "Xóa";
            deleteColumn.UseColumnTextForButtonValue = true;
            TTNhansu_DGV.Columns.Add(deleteColumn);

            TTNhansu_DGV.CellClick += TTNhansu_DGV_CellClick;
        }

        private void TTNhansu_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == TTNhansu_DGV.Columns["Edit"].Index)
                {
                    if (TTNhansu_DGV.Rows[e.RowIndex].Cells["VAITRO"].Value.ToString() == "Truong khoa")
                    {
                        MessageBox.Show("Không thể sửa tài khoản của trưởng khoa");
                        return;
                    }

                    NhanSuDTO nhansu = new NhanSuDTO();
                    nhansu.MANV = TTNhansu_DGV.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                    nhansu.HOTEN = TTNhansu_DGV.Rows[e.RowIndex].Cells["HOTEN"].Value.ToString();
                    nhansu.PHAI = TTNhansu_DGV.Rows[e.RowIndex].Cells["PHAI"].Value.ToString();
                    nhansu.NGSINH = Convert.ToDateTime(TTNhansu_DGV.Rows[e.RowIndex].Cells["NGSINH"].Value);
                    nhansu.PHUCAP = Convert.ToDouble(TTNhansu_DGV.Rows[e.RowIndex].Cells["PHUCAP"].Value);
                    nhansu.DT = TTNhansu_DGV.Rows[e.RowIndex].Cells["DT"].Value.ToString();
                    nhansu.VAITRO = TTNhansu_DGV.Rows[e.RowIndex].Cells["VAITRO"].Value.ToString();
                    nhansu.MADV = TTNhansu_DGV.Rows[e.RowIndex].Cells["MADV"].Value.ToString();
                    vaitro_cu = nhansu.VAITRO;

                    Them = false;
                    TieuDe.Text = "Cập nhật nhân sự";
                    NhanSu_pnl.Visible = true;
                    MaNV_txt.Text = nhansu.MANV;
                    HoTen_txt.Text = nhansu.HOTEN;
                    PhaiCB.SelectedIndex = nhansu.PHAI == "M"?0:1;
                    PhuCap_num.Text = nhansu.PHUCAP.ToString();
                    DienThoai_txt.Text = nhansu.DT;
                    VaiTroCB.SelectedIndex = VaiTroCB.FindStringExact(nhansu.VAITRO);
                    DonViCB.SelectedIndex = DonViCB.FindStringExact(nhansu.MADV.Trim().ToUpper());
                }
                else if (e.ColumnIndex == TTNhansu_DGV.Columns["Delete"].Index)
                {
                    string manv = TTNhansu_DGV.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                    nhanSuBUS.xoa_nhan_su(manv);
                    LoadData(madv);
                }    
            }
        }

        private void generateMaNV()
        {
            IList<String> ds = nhanSuBUS.LayDSNhanSu().Select(ns => ns.MANV).ToList();

            int maxId = ds
            .Select(id => int.Parse(id.Substring(2)))
            .Max();

            int newId = maxId + 1;
            string manv = "NV" + newId.ToString("D3");

            MaNV_txt.Text = manv;
        }

        private void ThongtinNhansu_Load(object sender, EventArgs e)
        {

        }

        private void TTNhansu_BTN_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan_NhanSu t = new ThongTinCaNhan_NhanSu(MaNV_B.Text);
            t.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetPanel();
            NhanSu_pnl.Visible = false;
        }

        private void ThemNS_btn_Click(object sender, EventArgs e)
        {
            Them = true;
            NhanSu_pnl.Visible = true;
            generateMaNV();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            NhanSuDTO nhansu = new NhanSuDTO();

            nhansu.MANV = MaNV_txt.Text;
            nhansu.HOTEN = HoTen_txt.Text;
            nhansu.NGSINH = NgaySinh_dtp.Value;
            nhansu.PHAI = PhaiCB.SelectedItem == "Nam" ? "M" : "F";
            nhansu.PHUCAP = Convert.ToDouble(PhuCap_num.Text);
            nhansu.DT = DienThoai_txt.Text;
            nhansu.VAITRO = VaiTroCB.SelectedItem.ToString();
            nhansu.MADV = DonViCB.SelectedItem.ToString();

            if (nhansu.HOTEN.Trim().Length <= 0)
            {
                MessageBox.Show("Xin nhập tên", "Cảnh báo");
            }
            else if (nhansu.DT.Trim().Length <= 0)
            {
                MessageBox.Show("Xin nhập số điện thoại", "Cảnh báo");
            }
            else if (!Regex.Match(nhansu.DT, @"^(03|05|07|08|09|01[2|6|8|9])+([0-9]{8})\b$").Success)
            {
                MessageBox.Show("Xin nhập số điện thoại hợp lệ", "Cảnh báo");
            }
            else
            {
                if (Them)
                {
                    nhanSuBUS.them_nhan_su(nhansu);
                }
                else
                {
                    nhanSuBUS.sua_nhan_su(vaitro_cu, nhansu);
                }
                ResetPanel();
                NhanSu_pnl.Visible = false;
                LoadData(madv);
            }
        }
    }
}
