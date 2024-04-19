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
using ATBM.FORM;
using ATBM.FORM.PhanCong;

namespace ATBM.FORM.PhanCong
{
    public partial class PhanCong : Form
    {
        PhanCongBUS pc = new PhanCongBUS();
        int role;
        public PhanCong()
        {
            InitializeComponent();
        }

        public PhanCong(int m_role)
        {
            InitializeComponent();
            loadDS();
            role = m_role;
            if (role == -1 || role == 4 || role == 5)
            {

            }
        }

        private void loadDS()
        {
            IList<PhanCongDTO> ds = pc.xem_phan_cong();
            PhanCong_dvg.DataSource = ds;
        }

        private void PhanCong_Load(object sender, EventArgs e)
        {

        }

        private void ThemPC_btn_Click(object sender, EventArgs e)
        {
            ThemPhanCong f = new ThemPhanCong();
            f.FormClosed += f_FormClosed;
            f.ShowDialog();
        }

        private void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
            PhanCong f = new PhanCong();
            f.ShowDialog();
        }
    }
}
