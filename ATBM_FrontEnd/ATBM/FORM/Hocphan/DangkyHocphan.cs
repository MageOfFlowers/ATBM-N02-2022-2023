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

namespace ATBM.FORM.Hocphan
{
    public partial class DangkyHocphan : Form
    {
        KHMBUS khm = new KHMBUS();
        IList<LopDTO> ds = new List<LopDTO>();

        public DangkyHocphan()
        {
            InitializeComponent();
            ds = khm.ds_KHM();
            loadCB(ds);
            loadHP(ds);
        }

        private void loadCB(IList<LopDTO> ds)
        {
            IList<LopDTO> temp = ds;
            LopDTO empty = new LopDTO();
            empty.MAHP = "Tất cả";

            temp.Insert(0, empty);
            
            HocPhanCB.DataSource = temp;
            HocPhanCB.DisplayMember = "MAHP";
            HocPhanCB.ValueMember = "MAHP";
        }

        private void loadHP(IList<LopDTO> ds)
        {
            IList<LopDTO> temp = ds;

            DateTime today = DateTime.Now;

            if (today.Day >= 16)
            {            
                temp = temp.Where(hp => hp.NAM == today.Year).ToList();
                switch (today.Month)
                {
                    case 4:
                        temp = temp.Where(hp => hp.HK == 2).ToList();
                        break;
                    case 8:
                        temp = temp.Where(hp => hp.HK == 3).ToList();
                        break;
                    case 12:
                        temp = temp.Where(hp => hp.HK == 1).ToList();
                        break;
                    default:
                        temp = new List<LopDTO>();
                        DSHocphanDGV.DataSource = temp;
                        MessageBox.Show("Chưa đến ngày đăng ký học phần");
                        DSHocphanDGV.Columns["display"].Visible = false;
                        return;
                }
                string mahp = HocPhanCB.SelectedValue.ToString();
                if (mahp != "Tất cả")
                {
                    temp = ds.Where(hp => hp.MAHP == mahp).ToList();
                }
            }
            else
            {
                temp = new List<LopDTO>();
                MessageBox.Show("Chưa đến ngày đăng ký học phần");
                DSHocphanDGV.Columns["display"].Visible = false;
                return;
            }

            DSHocphanDGV.DataSource = temp;
            DSHocphanDGV.Columns["display"].Visible = false;
        }

        private void DangkyHocphan_Load(object sender, EventArgs e)
        {

        }

        private void HocPhanCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds = khm.ds_KHM();
            loadHP(ds);
        }
    }
}
