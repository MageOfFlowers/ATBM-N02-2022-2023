using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATBM.Admin.BUS;
using ATBM.DTO;
using ATBM.Admin.DTO;
using ATBM.BUS;
using ATBM.FORM.KeHoachMo;
using System.Drawing;

namespace ATBM.FORM.PhanCong
{
    public partial class ThemPhanCong : Form
    {
        private KHMBUS khm = new KHMBUS();
        private NhanSuBUS ns = new NhanSuBUS();
        private PhanCongBUS ph = new PhanCongBUS();
        private IList<PhanCongDTO> ds_phancong;
        public ThemPhanCong()
        {
            InitializeComponent();
        }
        public ThemPhanCong(IList<PhanCongDTO> ds)
        {
            InitializeComponent();
            ds_phancong = ds;
            DSGiangVien();
            LoadData();
        }

        private void RefreshData(string magv)
        {
            IList<PhanCongDTO> ds_sosanh = ds_phancong.Where(pc => pc.MAGV ==  magv).ToList();
            IList<LopDTO> ds = khm.ds_KHM();
            ds = ds.Where(lop => !ds_sosanh.Any(pc => pc.MAHP == lop.MAHP && pc.HK == lop.HK && pc.NAM == lop.NAM && pc.MACT == lop.MACT)).ToList();
            Lop_dgv.DataSource = ds;
            Lop_dgv.Columns["display"].Visible = false;
        }

        private void DSGiangVien()
        {
            IList<NhanSuDTO> dsGV = ns.LayDSNhanSu();
            dsGV = dsGV.Where(gv => gv.VAITRO == "Giang vien").ToList();

            GiangVienCB.DataSource = dsGV;
            GiangVienCB.ValueMember = "MANV";
            GiangVienCB.DisplayMember = "display";
        }

        private void LoadData()
        {
            DataGridViewCheckBoxColumn chonLop = new DataGridViewCheckBoxColumn();
            chonLop.Name = "Select";
            chonLop.HeaderText = "Chọn";
            Lop_dgv.Columns.Insert(0, chonLop);

            Lop_dgv.Columns[1].HeaderText = "Mã học phần";
            Lop_dgv.Columns[2].HeaderText = "Tên học phần";
            Lop_dgv.Columns[3].HeaderText = "Học kỳ";
            Lop_dgv.Columns[4].HeaderText = "Năm học";
            Lop_dgv.Columns[5].HeaderText = "Chương trình";
        }

        private void ThemPhanCong_Load(object sender, EventArgs e)
        {

        }
        private void GiangVienCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData(GiangVienCB.SelectedValue.ToString());
        }

        private void ThemPC_btn_Click(object sender, EventArgs e)
        {
            PhanCongDTO pc = new PhanCongDTO();
            pc.MAGV = GiangVienCB.SelectedValue.ToString();
            foreach (DataGridViewRow row in Lop_dgv.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Select"].Value))
                {
                    pc.MAHP = row.Cells["MAHP"].Value.ToString();
                    pc.HK = Convert.ToInt32(row.Cells["HK"].Value);
                    pc.NAM = Convert.ToInt32(row.Cells["NAM"].Value);
                    pc.MACT = row.Cells["MACT"].Value.ToString();
                    ph.them_phan_cong(pc);
                }
            }
            Close();
        }
    }
}
