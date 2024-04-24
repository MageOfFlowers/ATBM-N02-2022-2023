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
using ATBM.FORM.KeHoachMo;
using ATBM.BUS;

namespace ATBM.FORM.SinhVien
{
    public partial class KQ_Dang_Ky_HP : Form
    {
        private static LopBUS lop = new LopBUS();
        private HocPhanBUS hp = new HocPhanBUS();
        IList<LopDTO> ds = lop.layDSLop();

        string masv;
        public KQ_Dang_Ky_HP(string username)
        {
            InitializeComponent();
            loadComboBox();
            masv = username;
        }

        private void loadComboBox()
        {
            HocKyCB.DataSource = ds.Select(lop => lop.HK).Distinct().OrderBy(n => n).ToList();

            NamCB.DataSource = ds.Select(lop => lop.NAM).Distinct().OrderBy(n => n).ToList();

            HocPhan_dvg.DataSource = ds;
            HocPhan_dvg.Columns["display"].Visible = false;

            HocPhan_dvg.Columns[0].HeaderText = "Mã học phần";
            HocPhan_dvg.Columns[1].HeaderText = "Tên học phần";
            HocPhan_dvg.Columns[2].HeaderText = "Học kỳ";
            HocPhan_dvg.Columns[3].HeaderText = "Năm học";
            HocPhan_dvg.Columns[4].HeaderText = "Chương trình";

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "delete";
            deleteColumn.HeaderText = "Hủy đăng ký";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            HocPhan_dvg.Columns.Insert(5, deleteColumn);

            HocPhan_dvg.CellClick += HocPhan_dvg_CellClick;
        }

        private void HocPhan_dvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LopDTO lop = new LopDTO();
            if (e.RowIndex >= 0)
            {
                lop.MAHP = HocPhan_dvg.Rows[e.RowIndex].Cells["MAHP"].Value.ToString();
                lop.TENHP = HocPhan_dvg.Rows[e.RowIndex].Cells["TENHP"].Value.ToString();
                lop.HK = Convert.ToInt32(HocPhan_dvg.Rows[e.RowIndex].Cells["HK"].Value);
                lop.NAM = Convert.ToInt32(HocPhan_dvg.Rows[e.RowIndex].Cells["NAM"].Value);

                if (e.ColumnIndex == HocPhan_dvg.Columns["Delete"].Index)
                {
                    try
                    {
                        hp.huy_dang_ky(masv, lop);
                        MessageBox.Show("Hủy thành công");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Close();
                        KQ_Dang_Ky_HP f = new KQ_Dang_Ky_HP(masv);
                        f.Show();
                    }
                }
            }
        }

        private void loadData(int hk, int nam)
        {
            IList<LopDTO> temp_list = ds.Where(lop => lop.HK == hk && lop.NAM == nam).ToList();
            HocPhan_dvg.DataSource = temp_list;
        }

        private void KQ_Dang_Ky_HP_Load(object sender, EventArgs e)
        {

        }

        private void HocKyCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData(Convert.ToInt32(HocKyCB.SelectedValue), Convert.ToInt32(NamCB.SelectedValue));
        }

        private void NamCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData(Convert.ToInt32(HocKyCB.SelectedValue), Convert.ToInt32(NamCB.SelectedValue));
        }
    }
}
