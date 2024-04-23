using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATBM.Admin.DTO;
using ATBM.Admin.BUS;

namespace ATBM.FORM.SinhVien
{
    public partial class KQ_Dang_Ky_HP : Form
    {
        private LopBUS lop = new LopBUS();
        public KQ_Dang_Ky_HP()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            IList<LopDTO> ds = lop.layDSLop();
            HocPhan_dvg.DataSource = ds;

            HocPhan_dvg.Columns[0].HeaderText = "Mã học phần";
            HocPhan_dvg.Columns[1].HeaderText = "Tên học phần";
            HocPhan_dvg.Columns[0].HeaderText = "Học kỳ";
            HocPhan_dvg.Columns[0].HeaderText = "Năm học";
            HocPhan_dvg.Columns[0].HeaderText = "Chương trình";

            HocKyCB.DataSource = ds.Select(lop => lop.HK).Distinct().OrderBy(n => n).ToList();

            NamCB.DataSource = ds.Select(lop => lop.NAM).Distinct().OrderBy(n => n).ToList();
        }

        private void KQ_Dang_Ky_HP_Load(object sender, EventArgs e)
        {

        }
    }
}
