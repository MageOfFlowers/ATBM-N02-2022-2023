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
using ATBM.BUS;
using ATBM.DTO;

namespace ATBM.FORM.KeHoachMo
{
    public partial class ThemKHM : Form
    {
        HocPhanBUS hp = new HocPhanBUS();
        KHMBUS khm = new KHMBUS();
        public ThemKHM()
        {
            InitializeComponent();
            loadHP();
        }

        public ThemKHM(KHMDTO khm)
        {
            InitializeComponent();
            loadHP();
            Them_btn.Text = "Cập nhật";
            HocPhan_cb.SelectedValue= khm.MAHP;
            HocPhan_cb.Enabled = false;
            HocKy_cb.SelectedItem = khm.HOCKY.ToString();
            NamHoc_cb.SelectedItem = khm.NAM.ToString();
            ChuongTrinh_cb.SelectedItem = khm.MACT;
        }

        private void ThemKHM_Load(object sender, EventArgs e)
        {
            
        }

        private void loadHP()
        {
            IList<HocPhanDTO> ds_hp = hp.dsHocPhan();
            ds_hp.Insert(0, new HocPhanDTO());
            HocPhan_cb.DataSource = ds_hp;
            HocPhan_cb.DisplayMember = "TENHP";
            HocPhan_cb.ValueMember = "MAHP";
        }

        private void Them_btn_Click(object sender, EventArgs e)
        {
            KHMDTO k = new KHMDTO();
            k.MAHP = HocPhan_cb.SelectedValue.ToString();
            k.TENHP = HocPhan_cb.Text;
            k.HOCKY = Convert.ToInt32(HocKy_cb.SelectedItem);
            k.NAM = Convert.ToInt32(NamHoc_cb.SelectedItem);
            k.MACT = ChuongTrinh_cb.Text;

            if (k.MAHP != null && k.TENHP != null && k.HOCKY != 0 && k.NAM != 0 && k.MACT != null)
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
    }
}
