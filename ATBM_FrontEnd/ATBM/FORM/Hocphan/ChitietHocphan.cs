using ATBM.BUS;
using ATBM.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATBM.FORM
{
    public partial class ChitietHocphan : Form
    {
        private HocPhanDTO hocPhan;
        private readonly DonViBUS donViBUS=new DonViBUS();
        private readonly HocPhanBUS hocPhanBUS=new HocPhanBUS();
        bool Them;
        public ChitietHocphan()
        {
            InitializeComponent();
            Them = true;
            label2.Text = "Thêm học phần";
            CapnhatCTHP_BTN.Text = "Thêm";
            loadCB();
        }
        public ChitietHocphan(HocPhanDTO hocPhanDTO)
        {
            InitializeComponent();
            Them = false;
            hocPhan= hocPhanDTO;
            lblMaHP.ReadOnly = true;
            loadCB();
            loadHP();
        }

        private void HuyboCTHP_BTN_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Quay lại màn hình chính?", "Quay lại", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void CapnhatCTHP_BTN_Click(object sender, EventArgs e)
        {
            HocPhanDTO hocPhanDTO= new HocPhanDTO() 
            {
                MAHP = lblMaHP.Text,
                TENHP = txtTenHP.Text,
                SOTC = Convert.ToInt32(NSoTC.Value),
                STLT = Convert.ToInt32(NSTLT.Value),
                STTH = Convert.ToInt32(NSTTH.Value),
                SOSVTD = Convert.ToInt32(NSoSVTD.Value),
                MADV = cbMaDV.SelectedItem.ToString()
            };
            if(hocPhanDTO.TENHP.Length==0)
            {
                MessageBox.Show("Xin nhập tên học phần", "Cảnh báo");
            }
            else
            {
                if (Them)
                {
                    hocPhanBUS.ThemHocPhan(hocPhanDTO);
                }   
                else
                {
                    hocPhanBUS.CapNhatHocPhan(hocPhanDTO);
                }
                Close();
            }
            
        }
        private void loadHP()
        {
            lblMaHP.Text = hocPhan.MAHP;
            txtTenHP.Text = hocPhan.TENHP;
            NSoTC.Value = hocPhan.SOTC;
            NSTLT.Value = hocPhan.STLT;
            NSTTH.Value = hocPhan.STTH;
            NSoSVTD.Value = hocPhan.SOSVTD;
            cbMaDV.SelectedIndex = cbMaDV.FindStringExact(hocPhan.MADV);
        }

        private void loadCB()
        {
            cbMaDV.Items.Clear();
            List<DonViDTO> dsDonVi = donViBUS.lay_ds_don_vi();
            foreach (DonViDTO d in dsDonVi)
            {
                cbMaDV.Items.Add(d.MADV);
            }
        }

        private void ChitietHocphan_Load(object sender, EventArgs e)
        {
            
        }
    }
}
