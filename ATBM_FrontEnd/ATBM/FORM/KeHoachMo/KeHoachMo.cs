using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATBM.BUS;
using ATBM.DTO;

namespace ATBM.FORM.KeHoachMo
{
    public partial class KeHoachMo : Form
    {
        KHMBUS khm = new KHMBUS();
        public KeHoachMo()
        {
            InitializeComponent();
        }

        private void dgvKHM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KeHoachMo_Load(object sender, EventArgs e)
        {
            IList<KHMDTO> ds = khm.ds_KHM();
            KHM_dvg.DataSource = ds;
            KHM_dvg.Columns[0].HeaderText = "Mã học phần";
            KHM_dvg.Columns[1].HeaderText = "Tên học phần";
            KHM_dvg.Columns[2].HeaderText = "Học kỳ";
            KHM_dvg.Columns[3].HeaderText = "Năm học";
            KHM_dvg.Columns[4].HeaderText = "Chương trình";

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "Edit";
            editColumn.HeaderText = "Sửa";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            KHM_dvg.Columns.Add(editColumn);

            KHM_dvg.CellClick += KHM_dvg_CellClick;
        }

        private void KHM_dvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KHMDTO khm = new KHMDTO();
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == KHM_dvg.Columns["Edit"].Index)
                {
                    khm.MAHP = KHM_dvg.Rows[e.RowIndex].Cells["MAHP"].Value.ToString();
                    khm.TENHP = KHM_dvg.Rows[e.RowIndex].Cells["TENHP"].Value.ToString();
                    khm.HOCKY = Convert.ToInt32(KHM_dvg.Rows[e.RowIndex].Cells["HOCKY"].Value);
                    khm.NAM = Convert.ToInt32(KHM_dvg.Rows[e.RowIndex].Cells["NAM"].Value);
                    khm.MACT = KHM_dvg.Rows[e.RowIndex].Cells["MACT"].Value.ToString();
                    ThemKHM t = new ThemKHM(khm);
                    t.FormClosed += t_FormClosed;
                    t.ShowDialog();
                }
            }
        }

        private void AddPlan_btn_Click(object sender, EventArgs e)
        {
            ThemKHM t = new ThemKHM();
            t.FormClosed += t_FormClosed;
            t.ShowDialog();
        }

        private void t_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
            KeHoachMo r = new KeHoachMo();
            r.ShowDialog();
        }
    }
}
