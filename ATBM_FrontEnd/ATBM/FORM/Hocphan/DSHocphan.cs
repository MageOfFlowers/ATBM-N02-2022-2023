using ATBM.BUS;
using ATBM.DTO;
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
    public partial class DSHocphan : Form
    {
        private readonly HocPhanBUS hocPhanBUS=new HocPhanBUS();
        int r = 0;
        public DSHocphan(int role)
        {
            InitializeComponent();
            r= role;
        }

        private void DSHocphan_Load(object sender, EventArgs e)
        {
            List<HocPhanDTO> dsHocPhan = hocPhanBUS.layDSHocPhan();
            var bindingList = new BindingList<HocPhanDTO>(dsHocPhan);
            var source = new BindingSource(bindingList, null);
            DSHocphanDGV.DataSource = source;
            if(r==3)
            {
                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.UseColumnTextForButtonValue = true;
                col.Text = "Sửa";
                col.Name = "Edit";
                col.HeaderText = "Sửa học phần";
                DSHocphanDGV.Columns.Add(col);
            }
        }

        private void DSHocphanBTN_Click(object sender, EventArgs e)
        {
            string mahp = MaHPB.Text;
            List<HocPhanDTO> dsHocPhan = hocPhanBUS.layDSHocPhan().Where(x=>x.MAHP.Contains(mahp)).ToList();
            var bindingList = new BindingList<HocPhanDTO>(dsHocPhan);
            var source = new BindingSource(bindingList, null);
            DSHocphanDGV.DataSource = source;
        }

        private void DSHocphanDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DSHocphanDGV.Columns[e.ColumnIndex].Name=="Edit" && e.RowIndex != -1)
            {
                HocPhanDTO hocPhan = new HocPhanDTO()
                {
                    MAHP= DSHocphanDGV.Rows[e.RowIndex].Cells["MAHP"].Value.ToString(),
                    TENHP = DSHocphanDGV.Rows[e.RowIndex].Cells["TENHP"].Value.ToString(),
                    SOTC =Convert.ToInt32(DSHocphanDGV.Rows[e.RowIndex].Cells["SOTC"].Value),
                    STLT = Convert.ToInt32(DSHocphanDGV.Rows[e.RowIndex].Cells["STLT"].Value),
                    STTH = Convert.ToInt32(DSHocphanDGV.Rows[e.RowIndex].Cells["STTH"].Value),
                    SOSVTD = Convert.ToInt32(DSHocphanDGV.Rows[e.RowIndex].Cells["SOSVTD"].Value),
                    MADV= DSHocphanDGV.Rows[e.RowIndex].Cells["MADV"].Value.ToString()
                };
                ChitietHocphan chitietHocphan = new ChitietHocphan(hocPhan);
                chitietHocphan.FormClosed += refreshData;
                chitietHocphan.ShowDialog();
            }
        }

        private void refreshData(object sender, FormClosedEventArgs e)
        {
            List<HocPhanDTO> dsHocPhan = hocPhanBUS.layDSHocPhan();
            var bindingList = new BindingList<HocPhanDTO>(dsHocPhan);
            var source = new BindingSource(bindingList, null);
            DSHocphanDGV.DataSource = source;
        }

        private void Them_btn_Click(object sender, EventArgs e)
        {
            ChitietHocphan chitietHocphan = new ChitietHocphan();
            chitietHocphan.FormClosed += refreshData;
            chitietHocphan.Show();
        }
    }
}
