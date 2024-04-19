using ATBM.Admin.BUS;
using ATBM.Admin.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ATBM
{
    public partial class ThongTinLopHoc : Form
    {
        LopBUS LopBUS = new LopBUS();
        IList<LopDTO> dsLop = new List<LopDTO>();
        DataTable dataTable;
        LopDTO LopHienTai = new LopDTO();
        public ThongTinLopHoc()
        {
            InitializeComponent();
            LayDsLop();
        }

        public ThongTinLopHoc(LopDTO khm)
        {
            InitializeComponent();
            LayDsLop();
            MaLopCB.SelectedItem = khm.MAHP;
            HocKiCB.SelectedItem = khm.HK;
            NamCB.SelectedItem = khm.NAM;
            ChuongTrinhCB.SelectedItem = khm.MACT;
        }

        private void LayDsLop()
        {
            try
            {
                dsLop = LopBUS.layDSLop();
                for (int intCount = 0; intCount < dsLop.Count; intCount++)
                {
                    var val = dsLop[intCount];
                    int HK = val.HK;
                    int Nam = val.NAM;
                    string MACT = val.MACT;
                    string MAHP = val.MAHP;


                    if (!HocKiCB.Items.Contains(HK))
                       HocKiCB.Items.Add(HK);
                    if (!NamCB.Items.Contains(Nam))
                       NamCB.Items.Add(Nam);
                    if (!ChuongTrinhCB.Items.Contains(val.MACT))
                       ChuongTrinhCB.Items.Add(val.MACT);
                    if (!MaLopCB.Items.Contains(MAHP))
                        MaLopCB.Items.Add(MAHP);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void keydownEvt(object sender, KeyEventArgs e)
        {
            MaLopCB.DroppedDown = false;
            ChuongTrinhCB.DroppedDown = false;
            HocKiCB.DroppedDown = false;
            NamCB.DroppedDown = false;
        }

        public void MaLopCB_Refresh()
        {
            int HK = Convert.ToInt32(HocKiCB.SelectedItem);
            int Nam = Convert.ToInt32(NamCB.SelectedItem);
            string MACT;
            if (ChuongTrinhCB.SelectedItem != null)
            {
                MACT = ChuongTrinhCB.SelectedItem.ToString();
            }
            else
            {
                MACT = "";
            }

            bool flag1 = HocKiCB.SelectedItem == null;
            bool flag2 = NamCB.SelectedItem == null;
            bool flag3 = ChuongTrinhCB.SelectedItem == null;

            for (int i = 0; i < dsLop.Count; i++)
            {
                bool FlagHK = (flag1 || dsLop[i].HK == HK);
                bool FlagN = (flag2 || dsLop[i].NAM == Nam);
                bool FlagCT = (flag3 || dsLop[i].MACT == MACT);
                if (FlagHK && FlagCT && FlagN)
                    {
                        dsLop[i].check = true;
                    }
                    else dsLop[i].check = false;              
            }
            if (flag1) HocKiCB.Items.Clear();
            if (flag2) NamCB.Items.Clear();
            if (flag3) ChuongTrinhCB.Items.Clear();

            for (int intCount = 0; intCount < dsLop.Count; intCount++)
            {
                var val = dsLop[intCount];
                HK = val.HK;
                Nam = val.NAM;
                MACT = val.MACT;
                Console.WriteLine(val.MACT);
                //check if it already exists
                if (val.check == true){
                    if (flag1)
                    {
                        if (!HocKiCB.Items.Contains(HK))
                            HocKiCB.Items.Add(HK);
                    }                 
                    if (flag2)
                    {
                        if (!NamCB.Items.Contains(Nam))
                            NamCB.Items.Add(Nam);
                    }
                    if (flag3)
                    {
                        if (!ChuongTrinhCB.Items.Contains(val.MACT))
                            ChuongTrinhCB.Items.Add(val.MACT);
                    }
                }
            }
        }

        public void ChuongTrinhCB_Refresh()
        {
            int HK = Convert.ToInt32(HocKiCB.SelectedItem);
            int Nam = Convert.ToInt32(NamCB.SelectedItem);
            string MAHP;
            if (MaLopCB.SelectedItem != null)
            {
                MAHP = MaLopCB.SelectedItem.ToString();
            }
            else
            {
                MAHP = "";
            }

            bool flag1 = HocKiCB.SelectedItem == null;
            bool flag2 = NamCB.SelectedItem == null;
            bool flag3 = MaLopCB.SelectedItem == null;

            for (int i = 0; i < dsLop.Count; i++)
            {
                bool FlagHK = (flag1 || dsLop[i].HK == HK);
                bool FlagN = (flag2 || dsLop[i].NAM == Nam);
                bool FlagHP = (flag3 || dsLop[i].MAHP == MAHP);
                if (FlagHK && FlagHP && FlagN)
                {
                    dsLop[i].check = true;
                }
                else dsLop[i].check = false;
            }
            if (flag1) HocKiCB.Items.Clear();
            if (flag2) NamCB.Items.Clear();
            if (flag3) MaLopCB.Items.Clear();

            for (int intCount = 0; intCount < dsLop.Count; intCount++)
            {
                var val = dsLop[intCount];
                HK = val.HK;
                Nam = val.NAM;
                MAHP = val.MAHP;
                Console.WriteLine(val.MACT);
                //check if it already exists
                if (val.check == true)
                {
                    if (flag1)
                    {
                        if (!HocKiCB.Items.Contains(HK))
                            HocKiCB.Items.Add(HK);
                    }
                    if (flag2)
                    {
                        if (!NamCB.Items.Contains(Nam))
                            NamCB.Items.Add(Nam);
                    }
                    if (flag3)
                    {
                        if (!MaLopCB.Items.Contains(MAHP))
                            MaLopCB.Items.Add(MAHP);
                    }
                }
            }
        }

        public void HocKiCB_Refresh()
        {
            string MAHP;
            if (MaLopCB.SelectedItem != null)
            {
                MAHP = MaLopCB.SelectedItem.ToString();
            }
            else
            {
                MAHP = "";
            }
            int Nam = Convert.ToInt32(NamCB.SelectedItem);
            string MACT;
            if (ChuongTrinhCB.SelectedItem != null)
            {
                MACT = ChuongTrinhCB.SelectedItem.ToString();
            }
            else
            {
                MACT = "";
            }

            bool flag1 = MaLopCB.SelectedItem == null;
            bool flag2 = NamCB.SelectedItem == null;
            bool flag3 = ChuongTrinhCB.SelectedItem == null;

            for (int i = 0; i < dsLop.Count; i++)
            {
                bool FlagHP = (flag1 || dsLop[i].MAHP == MAHP);
                bool FlagN = (flag2 || dsLop[i].NAM == Nam);
                bool FlagCT = (flag3 || dsLop[i].MACT == MACT);
                if (FlagHP && FlagCT && FlagN)
                {
                    dsLop[i].check = true;
                }
                else dsLop[i].check = false;
            }
            if (flag1) MaLopCB.Items.Clear();
            if (flag2) NamCB.Items.Clear();
            if (flag3) ChuongTrinhCB.Items.Clear();

            for (int intCount = 0; intCount < dsLop.Count; intCount++)
            {
                var val = dsLop[intCount];
                MAHP = val.MAHP;
                Nam = val.NAM;
                MACT = val.MACT;
                Console.WriteLine(val.MACT);
                //check if it already exists
                if (val.check == true)
                {
                    if (flag1)
                    {
                        if (!MaLopCB.Items.Contains(MAHP))
                            MaLopCB.Items.Add(MAHP);
                    }
                    if (flag2)
                    {
                        if (!NamCB.Items.Contains(Nam))
                            NamCB.Items.Add(Nam);
                    }
                    if (flag3)
                    {
                        if (!ChuongTrinhCB.Items.Contains(val.MACT))
                            ChuongTrinhCB.Items.Add(val.MACT);
                    }
                }
            }
            Console.WriteLine("121313313");
        }

        public void NamCB_Refresh()
        {
            string MAHP;
            if (MaLopCB.SelectedItem != null)
            {
                MAHP = MaLopCB.SelectedItem.ToString();
            }
            else
            {
                MAHP = "";
            }
            int HK = Convert.ToInt32(HocKiCB.SelectedItem);
            string MACT;
            if (ChuongTrinhCB.SelectedItem != null)
            {
                MACT = ChuongTrinhCB.SelectedItem.ToString();
            }
            else
            {
                MACT = "";
            }

            bool flag1 = MaLopCB.SelectedItem == null;
            bool flag2 = HocKiCB.SelectedItem == null;
            bool flag3 = ChuongTrinhCB.SelectedItem == null;

            for (int i = 0; i < dsLop.Count; i++)
            {
                bool FlagHP = (flag1 || dsLop[i].MAHP == MAHP);
                bool FlagHK = (flag2 || dsLop[i].NAM == HK);
                bool FlagCT = (flag3 || dsLop[i].MACT == MACT);
                if (FlagHP && FlagCT && FlagHK)
                {
                    dsLop[i].check = true;
                }
                else dsLop[i].check = false;
            }
            if (flag1) MaLopCB.Items.Clear();
            if (flag2) HocKiCB.Items.Clear();
            if (flag3) ChuongTrinhCB.Items.Clear();

            for (int intCount = 0; intCount < dsLop.Count; intCount++)
            {
                var val = dsLop[intCount];
                MAHP = val.MAHP;
                HK = val.HK;
                MACT = val.MACT;
                //check if it already exists
                Console.WriteLine(val.MACT);
                if (val.check == true)
                {
                    if (flag1)
                    {
                        if (!MaLopCB.Items.Contains(MAHP))
                            MaLopCB.Items.Add(MAHP);
                    }
                    if (flag2)
                    {
                        if (!HocKiCB.Items.Contains(HK))
                            HocKiCB.Items.Add(HK);
                    }
                    if (flag3)
                    {
                        if (!ChuongTrinhCB.Items.Contains(val.MACT))
                            ChuongTrinhCB.Items.Add(val.MACT);
                    }
                }
            }
        }

        private void ThongTinLopHoc_Load(object sender, EventArgs e)
        {
            loadData();
            //ThongTinLopDGV.CellValueChanged += new DataGridViewCellEventHandler(updateMedDep);
        }

        private void loadData()
        {
            TTHSTrongLopBUS TTHSTrongLopBUS = new TTHSTrongLopBUS();
            
            int HK = Convert.ToInt32(HocKiCB.SelectedItem);
            int Nam = Convert.ToInt32(NamCB.SelectedItem);
            string MACT = ChuongTrinhCB.SelectedItem.ToString();
            string MAHP = MaLopCB.SelectedItem.ToString();
            LopHienTai.HK = HK;
            LopHienTai.NAM = Nam;
            LopHienTai.MACT = MACT;
            LopHienTai.MAHP = MAHP;
            try
            {
                dataTable = TTHSTrongLopBUS.LayThongTinHocSinhTrongLop(MAHP, HK, Nam, MACT);
                ThongTinLopDGV.DataSource = dataTable;
                CapNhatDiem.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
                
        }

        private void TenLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThongTinLopHoc_Load_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void HocKiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MaLopCB.SelectedItem == null) MaLopCB_Refresh();
            if (NamCB.SelectedItem == null) NamCB_Refresh();
            if (ChuongTrinhCB.SelectedItem == null) ChuongTrinhCB_Refresh();
            if (MaLopCB.SelectedItem != null && NamCB.SelectedItem != null && ChuongTrinhCB.SelectedItem != null && HocKiCB.SelectedItem != null) loadData();
        }

        private void MaLopCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HocKiCB.SelectedItem == null) HocKiCB_Refresh();
            if (NamCB.SelectedItem == null) NamCB_Refresh();
            if (ChuongTrinhCB.SelectedItem == null) ChuongTrinhCB_Refresh();
            if (MaLopCB.SelectedItem != null && NamCB.SelectedItem != null && ChuongTrinhCB.SelectedItem != null && HocKiCB.SelectedItem != null) loadData();
        }

        private void NamCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HocKiCB.SelectedItem == null) HocKiCB_Refresh();
            if (MaLopCB.SelectedItem == null) MaLopCB_Refresh();
            if (ChuongTrinhCB.SelectedItem == null) ChuongTrinhCB_Refresh();
            if (MaLopCB.SelectedItem != null && NamCB.SelectedItem != null && ChuongTrinhCB.SelectedItem != null && HocKiCB.SelectedItem != null) loadData();
        }

        private void ChuongTrinhCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HocKiCB.SelectedItem == null) HocKiCB_Refresh();
            if (MaLopCB.SelectedItem == null) MaLopCB_Refresh();
            if (NamCB.SelectedItem == null) NamCB_Refresh();
            if (MaLopCB.SelectedItem != null && NamCB.SelectedItem != null && ChuongTrinhCB.SelectedItem != null && HocKiCB.SelectedItem != null) loadData();
        }

        private void ChonLai_Click(object sender, EventArgs e)
        {
            MaLopCB.Items.Clear();
            MaLopCB.ResetText();
            NamCB.Items.Clear();
            NamCB.ResetText();
            ChuongTrinhCB.Items.Clear();
            ChuongTrinhCB.ResetText();
            HocKiCB.Items.Clear();
            HocKiCB.ResetText();
            LayDsLop();
            ThongTinLopDGV.DataSource = null;
            ThongTinLopDGV.Rows.Clear();
            ThongTinLopDGV.Refresh();
            CapNhatDiem.Visible = false;
        }


        private void CapNhatDiem_Click(object sender, EventArgs e)
        {
            try
            {
                TTHSTrongLopBUS TTHSTrongLopBUS = new TTHSTrongLopBUS();
                TTHSTrongLopBUS.CapNhatDiem(dataTable, LopHienTai);
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }
        }

        private void ThongTinLopHoc_Load_2(object sender, EventArgs e)
        {

        }
    }
}
