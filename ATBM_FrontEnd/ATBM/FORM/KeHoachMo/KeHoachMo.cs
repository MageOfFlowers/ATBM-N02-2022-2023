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
using ATBM.Admin.DTO;

namespace ATBM.FORM.KeHoachMo
{
    public partial class KeHoachMo : Form
    {
        KHMBUS khm = new KHMBUS();
        int role;
        public KeHoachMo()
        {
            InitializeComponent();
        }

        public KeHoachMo(int m_role)
        {
            InitializeComponent();
            role = m_role;
            if (role >= 0 && role != 3)
                AddPlan_btn.Hide();
        }

        private void dgvKHM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KeHoachMo_Load(object sender, EventArgs e)
        {
            IList<LopDTO> ds = khm.ds_KHM();
            KHM_dvg.DataSource = ds;
            KHM_dvg.Columns["display"].Visible = false;
            KHM_dvg.Columns[0].HeaderText = "Mã học phần";
            KHM_dvg.Columns[1].HeaderText = "Tên học phần";
            KHM_dvg.Columns[2].HeaderText = "Học kỳ";
            KHM_dvg.Columns[3].HeaderText = "Năm học";
            KHM_dvg.Columns[4].HeaderText = "Chương trình";

            if (role == 3 || role == -1)
            {
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
                editColumn.Name = "Edit";
                editColumn.HeaderText = "Sửa";
                editColumn.Text = "Edit";
                editColumn.UseColumnTextForButtonValue = true;
                KHM_dvg.Columns.Add(editColumn);
            }
            KHM_dvg.CellClick += KHM_dvg_CellClick;
        }

        private void KHM_dvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LopDTO lop = new LopDTO();
            if (e.RowIndex >= 0)
            {
                lop.MAHP = KHM_dvg.Rows[e.RowIndex].Cells["MAHP"].Value.ToString();
                lop.TENHP = KHM_dvg.Rows[e.RowIndex].Cells["TENHP"].Value.ToString();
                lop.HK = Convert.ToInt32(KHM_dvg.Rows[e.RowIndex].Cells["HK"].Value);
                lop.NAM = Convert.ToInt32(KHM_dvg.Rows[e.RowIndex].Cells["NAM"].Value);
                lop.MACT = KHM_dvg.Rows[e.RowIndex].Cells["MACT"].Value.ToString();

                if (role == 3 || role == -1)
                {
                    if (e.ColumnIndex == KHM_dvg.Columns["Edit"].Index)
                    {
                        ThemKHM t = new ThemKHM(lop);
                        t.FormClosed += t_FormClosed;
                        t.ShowDialog();
                    }
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
