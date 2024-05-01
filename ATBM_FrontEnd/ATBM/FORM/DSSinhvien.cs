using ATBM.BUS;
using ATBM.DTO;
using ATBM.FORM.PhanCong;
using ATBM.FORM.SinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ATBM.FORM
{
    public partial class DSSinhvien : Form
    {
        int role;
        SinhVienBUS sv = new SinhVienBUS();

        public DSSinhvien()
        {
            InitializeComponent();
        }

        public DSSinhvien(int m_role)
        {
            InitializeComponent();
            role = m_role;
            loadComponent();
        }

        private void loadDS()
        {
            IList<SinhVienDTO> dssv = sv.lay_danh_sach_sinh_vien();
            SinhVien_dgv.DataSource = dssv;
        }

        private void loadComponent()
        {
            loadDS();
            if (role == 3)
            {
                ThemSV_btn.Visible = true;
                
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
                editColumn.Name = "Edit";
                editColumn.Text = "Sửa";
                editColumn.HeaderText = "Chỉnh sửa";
                editColumn.UseColumnTextForButtonValue = true;

                SinhVien_dgv.Columns.Add(editColumn);
                SinhVien_dgv.CellContentClick += SinhVien_dgv_CellContentClick;
            }
        }

        private void SinhVien_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SinhVienDTO sv = new SinhVienDTO();
            if (e.RowIndex >= 0)
            {
                sv.MASV = SinhVien_dgv.Rows[e.RowIndex].Cells["MASV"].Value.ToString();
                sv.HOTEN = SinhVien_dgv.Rows[e.RowIndex].Cells["HOTEN"].Value.ToString();
                sv.PHAI = SinhVien_dgv.Rows[e.RowIndex].Cells["PHAI"].Value.ToString();
                sv.NGSINH = Convert.ToDateTime(SinhVien_dgv.Rows[e.RowIndex].Cells["NGSINH"].Value);
                sv.DCHI = SinhVien_dgv.Rows[e.RowIndex].Cells["DCHI"].Value.ToString();
                sv.DT = SinhVien_dgv.Rows[e.RowIndex].Cells["DT"].Value.ToString();
                sv.MACT = SinhVien_dgv.Rows[e.RowIndex].Cells["MACT"].Value.ToString();
                sv.MANGANH = SinhVien_dgv.Rows[e.RowIndex].Cells["MANGANH"].Value.ToString();
                sv.SOTCTL = Convert.ToInt32(SinhVien_dgv.Rows[e.RowIndex].Cells["SOTCTL"].Value);
                sv.DTBTL = Convert.ToDouble(SinhVien_dgv.Rows[e.RowIndex].Cells["DTBTL"].Value);

                if (role == 3)
                {
                    if (e.ColumnIndex == SinhVien_dgv.Columns["Edit"].Index)
                    {
                        TTSinhVien t = new TTSinhVien(sv);
                        t.FormClosed += t_FormClosed;
                        t.Show();
                    }
                }
            }
        }

        private void t_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadDS();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MSSV_B = MaSVB.Text;
            ThongTinCaNhan_SinhVien f = new ThongTinCaNhan_SinhVien(MSSV_B);
            f.ShowDialog();
        }

        private void DSSinhvien_Load(object sender, EventArgs e)
        {

        }

        private void ThemSV_btn_Click(object sender, EventArgs e)
        {
            TTSinhVien t = new TTSinhVien();
            t.FormClosed += t_FormClosed;
            t.Show();
        }
    }
}
