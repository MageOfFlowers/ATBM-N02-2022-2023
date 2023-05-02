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
using ATBM.FORM.SinhVien;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ATBM.FORM.Hocphan
{
    public partial class DangkyHocphan : Form
    {
        HocPhanBUS hp = new HocPhanBUS();
        IList<LopDTO> ds = new List<LopDTO>();
        string masv;

        public DangkyHocphan(string m_masv)
        {
            InitializeComponent();
            masv = m_masv;
            try
            {
                ds = hp.ds_HocPhanDangKy();
                loadCB(ds);
                loadHP(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadCB(IList<LopDTO> ds)
        {
            IList<LopDTO> temp = ds;

            DataGridViewButtonColumn addColumn = new DataGridViewButtonColumn();
            addColumn.Name = "Add";
            addColumn.HeaderText = "Đăng ký";
            addColumn.Text = "Add";
            addColumn.UseColumnTextForButtonValue = true;

            DSHocphanDGV.Columns.Add(addColumn);

            DSHocphanDGV.CellClick += DSHocphanDGV_CellClick;

            LopDTO empty = new LopDTO();
            empty.MAHP = "Tất cả";

            temp.Insert(0, empty);
            
            HocPhanCB.DataSource = temp;
            HocPhanCB.DisplayMember = "MAHP";
            HocPhanCB.ValueMember = "MAHP";
        }

        private void DSHocphanDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LopDTO lop = new LopDTO();
            if (e.RowIndex >= 0)
            {
                lop.MAHP = DSHocphanDGV.Rows[e.RowIndex].Cells["MAHP"].Value.ToString();
                lop.TENHP = DSHocphanDGV.Rows[e.RowIndex].Cells["TENHP"].Value.ToString();
                lop.HK = Convert.ToInt32(DSHocphanDGV.Rows[e.RowIndex].Cells["HK"].Value);
                lop.NAM = Convert.ToInt32(DSHocphanDGV.Rows[e.RowIndex].Cells["NAM"].Value);
                lop.MACT = DSHocphanDGV.Rows[e.RowIndex].Cells["MACT"].Value.ToString();

                if (e.ColumnIndex == DSHocphanDGV.Columns["Add"].Index)
                {
                    try
                    {
                        hp.dang_ky_hp(masv, lop);
                        MessageBox.Show("Đăng ký thành công");
                        ds = hp.ds_HocPhanDangKy();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        loadHP(ds);
                    }
                }
            }
        }

        private void loadHP(IList<LopDTO> ds)
        {
            IList<LopDTO> temp = ds;
            
            string mahp = HocPhanCB.SelectedValue.ToString();
            if (mahp != "Tất cả")
            {
                temp = ds.Where(hp => hp.MAHP == mahp).ToList();
            }
            
            DSHocphanDGV.DataSource = temp;
            DSHocphanDGV.Columns["display"].Visible = false;
        }

        private void DangkyHocphan_Load(object sender, EventArgs e)
        {

        }

        private void HocPhanCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ds = hp.ds_HocPhanDangKy();
                loadHP(ds);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KetQua_btn_Click(object sender, EventArgs e)
        {
            KQ_Dang_Ky_HP kq_Dang_Ky_HP = new KQ_Dang_Ky_HP(masv);
            kq_Dang_Ky_HP.Show();
        }
    }
}
