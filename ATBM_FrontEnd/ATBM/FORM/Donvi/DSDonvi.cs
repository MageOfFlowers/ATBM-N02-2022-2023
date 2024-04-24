using ATBM.BUS;
using ATBM.DTO;
using ATBM.FORM.Donvi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM.FORM
{
    public partial class DSDonvi : Form
    {
        static DonViBUS dv = new DonViBUS();
        IList<DonViDTO> dsdv = dv.lay_ds_don_vi();
        DonViDTO ds = new DonViDTO();
        public DSDonvi()
        {
            InitializeComponent();
        }

        public DSDonvi(int m_role)
        {
            InitializeComponent();
            loadDS();
        }

        private void loadDS()
        {
            DonVi_dgv.DataSource = dsdv;
        }

        private void DSDonviBTN_Click(object sender, EventArgs e)
        {
            string MSDV_B = MsDV_B.Text;
            ThongtinNhansu f = new ThongtinNhansu();// (MSDV_B);
            f.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DSDonvi_Load(object sender, EventArgs e)
        {

        }
    }
}
