using ATBM.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ATBM.Admin
{
    public partial class Recover : Form
    {
        private readonly AdminBUS adminBUS = new AdminBUS();
        private readonly cmdBUS cmd=new cmdBUS();   
        public Recover()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelChonNgay.Visible = true;
        }

        private void btnConfChonNgay_Click(object sender, EventArgs e)
        {
            string d = dChonNgay.Value.ToString();
            if (checkBox1.Checked)
            {
                cmd.PhucHoiDuLieu(d, "2");
            }
            else
            {
                string bang = cbLoai.SelectedItem.ToString();
                cmd.PhucHoiBang(bang, d, "2");
            }
            Close();
        }

        private void Recover_Load(object sender, EventArgs e)
        {
            cbLoai.Items.Clear();
            IList<string> ds2 = adminBUS.TablesList2();
            foreach (string s in ds2)
            {
                cbLoai.Items.Add(s);
            }
            panelFlashback.Visible = false;
            panelChonNgay.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cbLoai.Enabled=checkBox1.Checked;
        }

        private void btnFlashback_Click(object sender, EventArgs e)
        {
            panelFlashback.Visible = true;
        }

        private void btnCheckpoint_Click(object sender, EventArgs e)
        {
            string d = DateTime.Now.ToString();
            if (checkBox1.Checked)
            {
                cmd.PhucHoiDuLieu(d, "3");
            }
            else
            {
                string bang = cbLoai.SelectedItem.ToString();
                cmd.PhucHoiBang(bang, d, "3");
            }
            Close();
        }

        private void btnHuyBoFlashback_Click(object sender, EventArgs e)
        {
            panelFlashback.Visible = false;
        }

        private void btnHuyChonNgay_Click(object sender, EventArgs e)
        {
            panelChonNgay.Visible = false;
        }

        private void btnConfFlashback_Click(object sender, EventArgs e)
        {
            string min=NFlashback.Value.ToString();
            if(checkBox1.Checked)
            {
                cmd.PhucHoiDuLieu(min,"1");
            }
            else
            {
                string bang = cbLoai.SelectedItem.ToString();
                cmd.PhucHoiBang(bang, min, "1");
            }
            Close();
        }
    }
}
