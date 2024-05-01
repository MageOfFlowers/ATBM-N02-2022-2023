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
using ATBM.DTO;

namespace ATBM.FORM.SinhVien
{
    public partial class KQ_Dang_Ky_HP : Form
    {
        private static HocPhanBUS hp = new HocPhanBUS();
        IList<DangKyDTO> ds = hp.ds_DaDangKy();
        string masv = "";
        int role;
        public KQ_Dang_Ky_HP(int m_role, string username)
        {
            InitializeComponent();
            masv = username;
            role = m_role;
            loadComboBox();
        }

        public KQ_Dang_Ky_HP(int m_role)
        {
            InitializeComponent();
            role = m_role;
            loadComboBox();
        }

        private void loadComboBox()
        {
            HocKyCB.DataSource = ds.Select(hk => hk.HK).Distinct().OrderBy(n => n).ToList();

            NamCB.DataSource = ds.Select(nam => nam.NAM).Distinct().OrderBy(n => n).ToList();

            HocPhan_dvg.DataSource = ds;

            if (role == 3)
            {
                HocPhan_dvg.Columns["MASV"].Visible = true;
            }

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "delete";
            deleteColumn.HeaderText = "Hủy đăng ký";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            HocPhan_dvg.Columns.Add(deleteColumn);

            HocPhan_dvg.CellClick += HocPhan_dvg_CellClick;
        }

        private void HocPhan_dvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DangKyDTO dk = new DangKyDTO();
            if (e.RowIndex >= 0)
            {
                dk.MASV = masv != "" ? masv : HocPhan_dvg.Rows[e.RowIndex].Cells["MASV"].Value.ToString();
                dk.MAHP = HocPhan_dvg.Rows[e.RowIndex].Cells["MAHP"].Value.ToString();
                dk.TENHP = HocPhan_dvg.Rows[e.RowIndex].Cells["TENHP"].Value.ToString();
                dk.HK = Convert.ToInt32(HocPhan_dvg.Rows[e.RowIndex].Cells["HK"].Value);
                dk.NAM = Convert.ToInt32(HocPhan_dvg.Rows[e.RowIndex].Cells["NAM"].Value);

                if (e.ColumnIndex == HocPhan_dvg.Columns["Delete"].Index)
                {
                    try
                    {
                        hp.huy_dang_ky(dk);
                        MessageBox.Show("Hủy thành công");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Close();
                        if (role == 3)
                        {
                            KQ_Dang_Ky_HP f = new KQ_Dang_Ky_HP(role);
                            f.Show();
                        }
                        else
                        {
                            KQ_Dang_Ky_HP f = new KQ_Dang_Ky_HP(role, masv);
                            f.Show();
                        }    
                    }
                }
            }
        }

        private void loadData(int hk, int nam)
        {
            IList<DangKyDTO> temp_list = ds.Where(dk => dk.HK == hk && dk.NAM == nam).ToList();
            HocPhan_dvg.DataSource = temp_list;
            if (role == 0)
            {
                HocPhan_dvg.Columns["MASV"].Visible = false;
            }
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
