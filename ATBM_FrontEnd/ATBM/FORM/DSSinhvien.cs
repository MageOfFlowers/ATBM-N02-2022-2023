using ATBM.BUS;
using ATBM.DTO;
using ATBM.FORM.PhanCong;
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
        static SinhVienBUS sv = new SinhVienBUS();
        IList<SinhVienDTO> dssv = sv.lay_danh_sach_sinh_vien();
        SinhVienDTO ds = new SinhVienDTO();

        public DSSinhvien()
        {
            InitializeComponent();
        }

        public DSSinhvien(int m_role)
        {
            InitializeComponent();
            loadDS();
        }

        private void loadDS()
        {
            SinhVien_dgv.DataSource = dssv;
        }

        private void ChonBTN_01_Click(object sender, EventArgs e)
        {
            string MSSV_B = MaSVB.Text;
            ThongTinCaNhan_SinhVien f = new ThongTinCaNhan_SinhVien(MSSV_B);
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DSSinhvien_Load(object sender, EventArgs e)
        {

        }
    }
}
