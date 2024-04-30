using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATBM.Admin.DTO;
using ATBM.Admin.BUS;
using ATBM.BUS;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATBM.FORM.KeHoachMo
{
    public partial class ThemKHM : Form
    {
        LopBUS lop = new LopBUS();
        KHMBUS khm = new KHMBUS();
        public ThemKHM()
        {
            InitializeComponent();
            loadHP();
        }

        public ThemKHM(LopDTO khm)
        {
            InitializeComponent();
            loadHP();
            Them_btn.Text = "Cập nhật";
            HocPhan_cb.SelectedValue= khm.MAHP;
            HocPhan_cb.Enabled = false;
            HocKy_cb.SelectedItem = khm.HK.ToString();
            NamHoc_txt.Text = khm.NAM.ToString();
            ChuongTrinh_cb.SelectedItem = khm.MACT;
        }

        private void ThemKHM_Load(object sender, EventArgs e)
        {
            
        }

        private void loadHP()
        {
            IList<LopDTO> ds = lop.layDSLop();
            ds.Insert(0, new LopDTO());
            HocPhan_cb.DataSource = ds;
            HocPhan_cb.DisplayMember = "TENHP";
            HocPhan_cb.ValueMember = "MAHP";
        }

        private void Them_btn_Click(object sender, EventArgs e)
        {
            LopDTO k = new LopDTO();
            k.MAHP = HocPhan_cb.SelectedValue.ToString();
            k.TENHP = HocPhan_cb.Text;
            k.HK = Convert.ToInt32(HocKy_cb.SelectedItem);
            k.NAM = Convert.ToInt32(NamHoc_txt.Text);
            k.MACT = ChuongTrinh_cb.Text;

            if (k.MAHP != null && k.TENHP != null && k.HK != 0 && k.NAM != 0 && k.MACT != null)
            {
                try
                {
                    khm.themKHM(k);
                    MessageBox.Show("Thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Close();
                }
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin");
        }

        private void NamHoc_txt_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            NamHoc_txt.Text = regex.Replace(NamHoc_txt.Text, "");

            NamHoc_txt.SelectionStart = NamHoc_txt.Text.Length;
        }
    }
}
