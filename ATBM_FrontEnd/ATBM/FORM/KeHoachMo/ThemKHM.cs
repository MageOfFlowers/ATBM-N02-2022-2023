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

        private void ThemKHM_Load(object sender, EventArgs e)
        {
            
        }

        private void loadHP()
        {
            IList<HocPhanDTO> ds_hp = hp.dsHocPhan();
            HocPhan_cb.DataSource = ds_hp;
            HocPhan_cb.DisplayMember = "TENHP";
            HocPhan_cb.ValueMember = "MAHP";
        }

        private void Them_btn_Click(object sender, EventArgs e)
        {
            KHMDTO k = new KHMDTO();
            k.MAHP = HocPhan_cb.SelectedValue.ToString();
            k.TENHP = HocPhan_cb.Text;
            MessageBox.Show(k.TENHP);
            k.HOCKY = Convert.ToInt32(HocKy_cb.SelectedItem);
            k.NAM = Convert.ToInt32(NamHoc_cb.SelectedItem);
            k.MACT = ChuongTrinh_cb.SelectedItem.ToString();

            try
            {
                khm.themKHM(k);
                MessageBox.Show("Success");
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
    }
}
