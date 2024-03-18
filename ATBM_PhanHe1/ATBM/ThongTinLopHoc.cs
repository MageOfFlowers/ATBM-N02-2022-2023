using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM
{
    public partial class ThongTinLopHoc : Form
    {
        string MaHP;
        int HocKi;
        string Nam;
        public ThongTinLopHoc()
        {
            InitializeComponent();
        }

        public ThongTinLopHoc(string MaHP, int HocKi, string Nam)
        {
            InitializeComponent();
            MaLop.Text = MaHP;
            HocKiTB.Text = HocKi.ToString();
            NamTB.Text = Nam;
            TenLop.Text = "None";
            this.MaHP = MaHP;
            this.HocKi = HocKi;
            this.Nam = Nam;
        }

        private void ThongTinLopHoc_Load(object sender, EventArgs e)
        {
            loadData();
            ThongTinLopDGV.CellValueChanged += new DataGridViewCellEventHandler(updateMedDep);
        }

        private void loadData()
        {
            ThongTinLopDGV.Rows.Clear();
            DepartmentBUS departmentBUS = new DepartmentBUS();
            IList<MedDepDTO> ds = departmentBUS.layDSThuoc_CoSo(id);
            foreach (MedDepDTO d in ds)
            {
                depMedTable.Rows.Add(d.mID, d.name, d.remain);
            }
            depMedTable.CellValidating += new DataGridViewCellValidatingEventHandler(checkNum);

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
                
        }

        private void TenLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
