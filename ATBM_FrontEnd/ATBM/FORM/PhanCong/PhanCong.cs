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
using ATBM.BUS;
using ATBM.DTO;
using ATBM.FORM;
using ATBM.FORM.KeHoachMo;
using ATBM.FORM.PhanCong;

namespace ATBM.FORM.PhanCong
{
    public partial class PhanCong : Form
    {
        static PhanCongBUS pc = new PhanCongBUS();
        IList<PhanCongDTO> ds = pc.xem_phan_cong();
        int role;
        public PhanCong()
        {
            InitializeComponent();
        }

        public PhanCong(int m_role)
        {
            InitializeComponent();
            role = m_role;
            loadDS();
        }

        private void loadDS()
        {
            PhanCong_dvg.DataSource = ds;

            if (role >= 3 || role == -1)
            {
                ThemPC_btn.Visible = true;

                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
                editColumn.Name = "Edit";
                editColumn.HeaderText = "Sửa";
                editColumn.Text = "Edit";
                editColumn.UseColumnTextForButtonValue = true;
                PhanCong_dvg.Columns.Add(editColumn);

                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                deleteColumn.Name = "Delete";
                deleteColumn.HeaderText = "Xóa";
                deleteColumn.Text = "Delete";
                deleteColumn.UseColumnTextForButtonValue = true;
                PhanCong_dvg.Columns.Add(deleteColumn);

                PhanCong_dvg.CellClick += PhanCong_dvg_CellClick;
            }
        }

        private void PhanCong_dvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PhanCongDTO ph = new PhanCongDTO();
            if (e.RowIndex >= 0)
            {
                ph.MAGV = PhanCong_dvg.Rows[e.RowIndex].Cells["MAGV"].Value.ToString();
                ph.MAHP = PhanCong_dvg.Rows[e.RowIndex].Cells["MAHP"].Value.ToString();
                ph.HK = Convert.ToInt32(PhanCong_dvg.Rows[e.RowIndex].Cells["HK"].Value);
                ph.NAM = Convert.ToInt32(PhanCong_dvg.Rows[e.RowIndex].Cells["NAM"].Value);
                ph.MACT = PhanCong_dvg.Rows[e.RowIndex].Cells["MACT"].Value.ToString();

                if (e.ColumnIndex == PhanCong_dvg.Columns["Delete"].Index)
                {
                    pc.xoa_phan_cong(ph);
                    formreset();
                }
            }
        }

        private void PhanCong_Load(object sender, EventArgs e)
        {

        }

        private void ThemPC_btn_Click(object sender, EventArgs e)
        {
            ThemPhanCong f = new ThemPhanCong(ds);
            f.FormClosed += f_FormClosed;
            f.ShowDialog();
        }

        private void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            formreset();
        }

        private void formreset()
        {
            Close();
            PhanCong f = new PhanCong(role);
            f.ShowDialog();
        }
    }
}
