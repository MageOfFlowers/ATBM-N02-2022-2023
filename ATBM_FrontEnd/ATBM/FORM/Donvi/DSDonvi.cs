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
        int role;
        public DSDonvi()
        {
            InitializeComponent();
        }

        public DSDonvi(int m_role)
        {
            InitializeComponent();
            role = m_role;
            loadDS();
        }

        private void loadDS()
        {
            DonVi_dgv.DataSource = dsdv;
            if (role == 5)
            {
                DataGridViewButtonColumn dtColumn = new DataGridViewButtonColumn();
                dtColumn.Name = "CT";
                dtColumn.Text = "Chi tiết";
                dtColumn.HeaderText = "Chi tiết nhân sự";
                dtColumn.UseColumnTextForButtonValue = true;
                DonVi_dgv.Columns.Add(dtColumn);

                DonVi_dgv.CellContentClick += DonVi_dgv_CellContentClick;
            }
        }

        private void DonVi_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DonVi_dgv.Columns["CT"].Index)
            {
                string madv = DonVi_dgv.Rows[e.RowIndex].Cells["MADV"].Value.ToString();
                ThongtinNhansu t = new ThongtinNhansu(madv);
                t.Show();
            }    
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DSDonvi_Load(object sender, EventArgs e)
        {

        }
    }
}
