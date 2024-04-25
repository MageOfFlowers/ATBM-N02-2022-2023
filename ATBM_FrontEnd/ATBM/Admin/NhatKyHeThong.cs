using ATBM.Admin.BUS;
using ATBM.Admin.DTO;
using ATBM.BUS;
using ATBM.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATBM.Admin
{
    public partial class NhatKyHeThong : Form
    {
        NhatKyBUS NhatKyBUS = new NhatKyBUS();
        AdminBUS AdminBUS = new AdminBUS();
        IList<NhatKyDTO> dsNhatKy = new List<NhatKyDTO>();
        public NhatKyHeThong()
        {
            InitializeComponent();
            LayDSNhatKy();
            LayDSThem();
        }

        private void LayDSNhatKy()
        {
            try
            {
                dsNhatKy = NhatKyBUS.LayNhatKy();
                for (int intCount = 0; intCount < dsNhatKy.Count; intCount++)
                {
                    var val = dsNhatKy[intCount];
                    string NguoiDung = val.dbusername;
                    string DoiTuong = val.object_name;
                    string HanhDong = val.action_name;

                    if (!NguoiDungCB.Items.Contains(NguoiDung))
                        NguoiDungCB.Items.Add(NguoiDung);
                    if (!DoiTuongCB.Items.Contains(DoiTuong))
                        DoiTuongCB.Items.Add(DoiTuong);
                    if (!HanhDongCB.Items.Contains(HanhDong))
                        HanhDongCB.Items.Add(HanhDong);
                }
                LoaiCB.Items.Add("Standard");
                LoaiCB.Items.Add("Unified");
                TrangThaiCB.Items.Add("Thành công");
                TrangThaiCB.Items.Add("Thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LayDSThem()
        {
            try
            {
                IList<string> ds = AdminBUS.UserList2();
                IList<string> ds2 = AdminBUS.TablesList2();
                foreach (string s in ds)
                {
                    NguoiDungCB2.Items.Add(s);
                }
                foreach (string s in ds2)
                {
                    DoiTuongCB2.Items.Add(s);
                }
                
                HanhDongCB2.Items.Add("To Table/View");
                HanhDongCB2.Items.Add("Select");
                HanhDongCB2.Items.Add("Delete");
                HanhDongCB2.Items.Add("Insert");
                HanhDongCB2.Items.Add("Update");
                HanhDongCB2.Items.Add("Execute");
                HanhDongCB2.SelectedItem = "To Table/View";

                TrangThaiCB2.Items.Add("Mọi lúc");
                TrangThaiCB2.Items.Add("Thành công");
                TrangThaiCB2.Items.Add("Thất bại");                
                TrangThaiCB2.SelectedItem = "Mọi lúc";

                CachGhiCB.Items.Add("By Access");
                CachGhiCB.Items.Add("By Session");
                CachGhiCB.SelectedItem = "By Access";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void keydownEvt(object sender, KeyEventArgs e)
        {
            NguoiDungCB.DroppedDown = false;
            DoiTuongCB.DroppedDown = false;
            NguoiDungCB2.DroppedDown = false;
            DoiTuongCB2.DroppedDown = false;
            LoaiCB.DroppedDown = false;
            TrangThaiCB.DroppedDown = false;
        }

        public void NguoiDungCB_Refresh()
        {
            string DoiTuong;
            if (DoiTuongCB.SelectedItem != null)
            {
                DoiTuong = DoiTuongCB.SelectedItem.ToString();
            }
            else
            {
                DoiTuong = "";
            }
            string Loai;
            if (LoaiCB.SelectedItem != null)
            {
                Loai = LoaiCB.SelectedItem.ToString();
            }
            else
            {
                Loai = "";
            }
            string TrangThai;
            if (TrangThaiCB.SelectedItem != null)
            {
                TrangThai = TrangThaiCB.SelectedItem.ToString();
            }
            else
            {
                TrangThai = "";
            }
            string HanhDong;
            if (HanhDongCB.SelectedItem != null)
            {
                HanhDong = HanhDongCB.SelectedItem.ToString();
            }
            else
            {
                HanhDong = "";
            }

            bool flag1 = DoiTuongCB.SelectedItem == null;
            bool flag2 = LoaiCB.SelectedItem == null;
            bool flag3 = TrangThaiCB.SelectedItem == null;
            bool flag4 = HanhDongCB.SelectedItem == null;

            for (int i = 0; i < dsNhatKy.Count; i++)
            {
                bool FlagDT = (flag1 || dsNhatKy[i].object_name == DoiTuong);
                bool FlagL = (flag2 || dsNhatKy[i].unified_audit_policies == Loai);
                bool FlagTT = (flag3 || dsNhatKy[i].return_code == TrangThai);
                bool FlagHD = (flag4 || dsNhatKy[i].action_name == HanhDong);
                if (FlagDT && FlagL && FlagTT && FlagHD)
                {
                    dsNhatKy[i].check = true;
                }
                else dsNhatKy[i].check = false;
            }
            if (flag1) DoiTuongCB.Items.Clear();
            if (flag4) HanhDongCB.Items.Clear();

            for (int intCount = 0; intCount < dsNhatKy.Count; intCount++)
            {
                var val = dsNhatKy[intCount];
                DoiTuong = val.object_name;
                HanhDong = val.action_name;
                if (!HanhDongCB.Items.Contains(HanhDong))
                {
                    HanhDongCB.Items.Add(HanhDong);
                }
                if (!DoiTuongCB.Items.Contains(DoiTuong))
                {
                    DoiTuongCB.Items.Add(DoiTuong);
                }
                
            }
        }

        public void DoiTuongCB_Refresh()
        {
            string NguoiDung;
            if (NguoiDungCB.SelectedItem != null)
            {
                NguoiDung = NguoiDungCB.SelectedItem.ToString();
            }
            else
            {
                NguoiDung = "";
            }
            string Loai;
            if (LoaiCB.SelectedItem != null)
            {
                Loai = LoaiCB.SelectedItem.ToString();
            }
            else
            {
                Loai = "";
            }
            string TrangThai;
            if (TrangThaiCB.SelectedItem != null)
            {
                TrangThai = TrangThaiCB.SelectedItem.ToString();
            }
            else
            {
                TrangThai = "";
            }
            string HanhDong;
            if (HanhDongCB.SelectedItem != null)
            {
                HanhDong = HanhDongCB.SelectedItem.ToString();
            }
            else
            {
                HanhDong = "";
            }


            bool flag1 = NguoiDungCB.SelectedItem == null;
            bool flag2 = LoaiCB.SelectedItem == null;
            bool flag3 = TrangThaiCB.SelectedItem == null;
            bool flag4 = HanhDongCB.SelectedItem == null;

            for (int i = 0; i < dsNhatKy.Count; i++)
            {
                bool FlagDT = (flag1 || dsNhatKy[i].dbusername == NguoiDung);
                bool FlagL = (flag2 || dsNhatKy[i].unified_audit_policies == Loai);
                bool FlagTT = (flag3 || dsNhatKy[i].return_code == TrangThai);
                bool FlagHD = (flag4 || dsNhatKy[i].action_name == HanhDong);
                if (FlagDT && FlagL && FlagTT && FlagHD)
                {
                    dsNhatKy[i].check = true;
                }
                else dsNhatKy[i].check = false;
            }
            if (flag1) NguoiDungCB.Items.Clear();
            if (flag4) HanhDongCB.Items.Clear();

            for (int intCount = 0; intCount < dsNhatKy.Count; intCount++)
            {
                var val = dsNhatKy[intCount];
                NguoiDung = val.dbusername;
                HanhDong = val.action_name;
                if (!HanhDongCB.Items.Contains(HanhDong))
                {
                    HanhDongCB.Items.Add(HanhDong);
                }
                if (!NguoiDungCB.Items.Contains(NguoiDung))
                {
                    NguoiDungCB.Items.Add(NguoiDung);
                }
            }
        }

        public void LoaiCB_Refresh()
        {
            string NguoiDung;
            if (NguoiDungCB.SelectedItem != null)
            {
                NguoiDung = NguoiDungCB.SelectedItem.ToString();
            }
            else
            {
                NguoiDung = "";
            }
            string DoiTuong;
            if (DoiTuongCB.SelectedItem != null)
            {
                DoiTuong = DoiTuongCB.SelectedItem.ToString();
            }
            else
            {
                DoiTuong = "";
            }
            string TrangThai;
            if (TrangThaiCB.SelectedItem != null)
            {
                TrangThai = TrangThaiCB.SelectedItem.ToString();
            }
            else
            {
                TrangThai = "";
            }
            string HanhDong;
            if (HanhDongCB.SelectedItem != null)
            {
                HanhDong = HanhDongCB.SelectedItem.ToString();
            }
            else
            {
                HanhDong = "";
            }


            bool flag1 = NguoiDungCB.SelectedItem == null;
            bool flag2 = DoiTuongCB.SelectedItem == null;
            bool flag3 = TrangThaiCB.SelectedItem == null;
            bool flag4 = HanhDongCB.SelectedItem == null;

            for (int i = 0; i < dsNhatKy.Count; i++)
            {
                bool FlagDT = (flag1 || dsNhatKy[i].dbusername == NguoiDung);
                bool FlagL = (flag2 || dsNhatKy[i].object_name == DoiTuong);
                bool FlagTT = (flag3 || dsNhatKy[i].return_code == TrangThai);
                bool FlagHD = (flag4 || dsNhatKy[i].action_name == HanhDong);
                if (FlagDT && FlagL && FlagTT && FlagHD)
                {
                    dsNhatKy[i].check = true;
                }
                else dsNhatKy[i].check = false;
            }
            if (flag1) NguoiDungCB.Items.Clear();
            if (flag2) DoiTuongCB.Items.Clear();
            if (flag4) HanhDongCB.Items.Clear();

            for (int intCount = 0; intCount < dsNhatKy.Count; intCount++)
            {
                var val = dsNhatKy[intCount];
                NguoiDung = val.dbusername;
                DoiTuong = val.object_name;
                HanhDong = val.action_name;
                if (!HanhDongCB.Items.Contains(HanhDong))
                {
                    HanhDongCB.Items.Add(HanhDong);
                }
                if (!NguoiDungCB.Items.Contains(NguoiDung))
                {
                    NguoiDungCB.Items.Add(NguoiDung);
                }
                if (!DoiTuongCB.Items.Contains(DoiTuong))
                {
                    DoiTuongCB.Items.Add(DoiTuong);
                }
            }
        }

        public void TrangThaiCB_Refresh()
        {
            string NguoiDung;
            if (NguoiDungCB.SelectedItem != null)
            {
                NguoiDung = NguoiDungCB.SelectedItem.ToString();
            }
            else
            {
                NguoiDung = "";
            }
            string DoiTuong;
            if (DoiTuongCB.SelectedItem != null)
            {
                DoiTuong = DoiTuongCB.SelectedItem.ToString();
            }
            else
            {
                DoiTuong = "";
            }
            string Loai;
            if (LoaiCB.SelectedItem != null)
            {
                Loai = LoaiCB.SelectedItem.ToString();
            }
            else
            {
                Loai = "";
            }
            string HanhDong;
            if (HanhDongCB.SelectedItem != null)
            {
                HanhDong = HanhDongCB.SelectedItem.ToString();
            }
            else
            {
                HanhDong = "";
            }


            bool flag1 = NguoiDungCB.SelectedItem == null;
            bool flag2 = DoiTuongCB.SelectedItem == null;
            bool flag3 = LoaiCB.SelectedItem == null;
            bool flag4 = HanhDongCB.SelectedItem == null;

            for (int i = 0; i < dsNhatKy.Count; i++)
            {
                bool FlagDT = (flag1 || dsNhatKy[i].dbusername == NguoiDung);
                bool FlagL = (flag2 || dsNhatKy[i].object_name == DoiTuong);
                bool FlagTT = (flag3 || dsNhatKy[i].unified_audit_policies == Loai);
                bool FlagHD = (flag4 || dsNhatKy[i].action_name == HanhDong);
                if (FlagDT && FlagL && FlagTT && FlagHD)
                {
                    dsNhatKy[i].check = true;
                }
                else dsNhatKy[i].check = false;
            }
            if (flag1) NguoiDungCB.Items.Clear();
            if (flag2) DoiTuongCB.Items.Clear();
            if (flag4) HanhDongCB.Items.Clear();

            for (int intCount = 0; intCount < dsNhatKy.Count; intCount++)
            {
                var val = dsNhatKy[intCount];
                NguoiDung = val.dbusername;
                DoiTuong = val.object_name;
                HanhDong = val.action_name;
                if (!HanhDongCB.Items.Contains(HanhDong))
                {
                    HanhDongCB.Items.Add(HanhDong);
                }
                if (!NguoiDungCB.Items.Contains(NguoiDung))
                {
                    NguoiDungCB.Items.Add(NguoiDung);
                }
                if (!DoiTuongCB.Items.Contains(DoiTuong))
                {
                    DoiTuongCB.Items.Add(DoiTuong);
                }
            }
        }
        public void HanhDongCB_Refresh()
        {
            string NguoiDung;
            if (NguoiDungCB.SelectedItem != null)
            {
                NguoiDung = NguoiDungCB.SelectedItem.ToString();
            }
            else
            {
                NguoiDung = "";
            }
            string DoiTuong;
            if (DoiTuongCB.SelectedItem != null)
            {
                DoiTuong = DoiTuongCB.SelectedItem.ToString();
            }
            else
            {
                DoiTuong = "";
            }
            string Loai;
            if (LoaiCB.SelectedItem != null)
            {
                Loai = LoaiCB.SelectedItem.ToString();
            }
            else
            {
                Loai = "";
            }
            string TrangThai;
            if (TrangThaiCB.SelectedItem != null)
            {
                TrangThai = TrangThaiCB.SelectedItem.ToString();
            }
            else
            {
                TrangThai = "";
            }


            bool flag1 = NguoiDungCB.SelectedItem == null;
            bool flag2 = DoiTuongCB.SelectedItem == null;
            bool flag3 = LoaiCB.SelectedItem == null;
            bool flag4 = TrangThaiCB.SelectedItem == null;

            for (int i = 0; i < dsNhatKy.Count; i++)
            {
                bool FlagDT = (flag1 || dsNhatKy[i].dbusername == NguoiDung);
                bool FlagL = (flag2 || dsNhatKy[i].object_name == DoiTuong);
                bool FlagTT = (flag3 || dsNhatKy[i].unified_audit_policies == Loai);
                bool FlagHD = (flag4 || dsNhatKy[i].return_code == TrangThai);
                if (FlagDT && FlagL && FlagTT && FlagHD)
                {
                    dsNhatKy[i].check = true;
                }
                else dsNhatKy[i].check = false;
            }
            if (flag1) NguoiDungCB.Items.Clear();
            if (flag2) DoiTuongCB.Items.Clear();
            if (flag4) TrangThaiCB.Items.Clear();

            for (int intCount = 0; intCount < dsNhatKy.Count; intCount++)
            {
                var val = dsNhatKy[intCount];
                NguoiDung = val.dbusername;
                DoiTuong = val.object_name;
                TrangThai = val.return_code;
                if (!TrangThaiCB.Items.Contains(TrangThai))
                {
                    TrangThaiCB.Items.Add(TrangThai);
                }
                if (!NguoiDungCB.Items.Contains(NguoiDung))
                {
                    NguoiDungCB.Items.Add(NguoiDung);
                }
                if (!DoiTuongCB.Items.Contains(DoiTuong))
                {
                    DoiTuongCB.Items.Add(DoiTuong);
                }
            }
        }


        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("dbusername");
            dt.Columns.Add("action_name");
            dt.Columns.Add("object_schema");
            dt.Columns.Add("object_name");
            dt.Columns.Add("return_code");
            dt.Columns.Add("event_timestamp");
            dt.Columns.Add("system_privilege");
            dt.Columns.Add("unified_audit_policies");
            foreach (var item in dsNhatKy)
            {
                if (item.check == true)
                {
                    var row = dt.NewRow();
                    row["dbusername"] = item.dbusername;
                    row["action_name"] = item.action_name;
                    row["object_schema"] = item.object_schema;
                    row["object_name"] = item.object_name;
                    row["return_code"] = item.return_code;
                    row["event_timestamp"] = item.event_timestamp;
                    row["system_privilege"] = item.system_privilege;
                    row["system_privilege"] = item.system_privilege;
                    row["unified_audit_policies"] = item.unified_audit_policies;
                    dt.Rows.Add(row);
                }
            }
            NhatKyDGV.DataSource = dt;
        }
        private void BatGhiNhatKy_Click(object sender, EventArgs e)
        {
            try
            {
                string doituong = DoiTuongCB2.SelectedItem.ToString();
                string nguoidung = NguoiDungCB2.SelectedItem.ToString();
                string hanhdong = HanhDongCB2.SelectedItem.ToString();
                string trangthai = TrangThaiCB2.SelectedItem.ToString();
                string cachghi = CachGhiCB.SelectedItem.ToString();

                AdminBUS.BatGhiNhatKy(doituong, nguoidung, hanhdong, trangthai, cachghi);
                MessageBox.Show("Cài đặt thành công");
            }
            catch
            {
                MessageBox.Show("Không thể cài đặt");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoaiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NguoiDungCB.SelectedItem == null) { NguoiDungCB_Refresh(); }
            if (DoiTuongCB.SelectedItem == null) { DoiTuongCB_Refresh(); }
            if (TrangThaiCB.SelectedItem == null) { TrangThaiCB_Refresh(); }
            if (HanhDongCB.SelectedItem == null) { HanhDongCB_Refresh(); }
            LoadData();
        }

        private void NguoiDungCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoaiCB.SelectedItem == null) { LoaiCB_Refresh(); }
            if (DoiTuongCB.SelectedItem == null) { DoiTuongCB_Refresh(); }
            if (TrangThaiCB.SelectedItem == null) { TrangThaiCB_Refresh(); }
            if (HanhDongCB.SelectedItem == null) { HanhDongCB_Refresh(); }
            LoadData();
        }

        private void DoiTuongCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NguoiDungCB.SelectedItem == null) { NguoiDungCB_Refresh(); }
            if (LoaiCB.SelectedItem == null) { LoaiCB_Refresh(); }
            if (TrangThaiCB.SelectedItem == null) { TrangThaiCB_Refresh(); }
            if (HanhDongCB.SelectedItem == null) { HanhDongCB_Refresh(); }
            LoadData();
        }

        private void TrangThaiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NguoiDungCB.SelectedItem == null) {NguoiDungCB_Refresh(); }
            if (LoaiCB.SelectedItem == null){ LoaiCB_Refresh(); }
            if (DoiTuongCB.SelectedItem == null){ DoiTuongCB_Refresh(); }
            if (HanhDongCB.SelectedItem == null) { HanhDongCB_Refresh(); }
            LoadData();
        }

        private void HanhDongCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NguoiDungCB.SelectedItem == null) { NguoiDungCB_Refresh(); }
            if (DoiTuongCB.SelectedItem == null) { DoiTuongCB_Refresh(); }
            if (LoaiCB.SelectedItem == null) { LoaiCB_Refresh(); }
            if (TrangThaiCB.SelectedItem == null) { TrangThaiCB_Refresh(); }
            LoadData();
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            NguoiDungCB.Items.Clear();
            NguoiDungCB.ResetText();
            NguoiDungCB2.Items.Clear();
            NguoiDungCB2.ResetText();
            LoaiCB.Items.Clear();
            LoaiCB.ResetText();
            DoiTuongCB.Items.Clear();
            DoiTuongCB.ResetText();
            DoiTuongCB2.Items.Clear();
            DoiTuongCB2.ResetText();
            TrangThaiCB.Items.Clear();
            TrangThaiCB.ResetText();
            TrangThaiCB2.Items.Clear();
            TrangThaiCB2.ResetText();
            HanhDongCB.Items.Clear();
            HanhDongCB.ResetText();
            HanhDongCB2.Items.Clear();
            HanhDongCB2.ResetText();
            LayDSNhatKy();
            LayDSThem();
            NhatKyDGV.DataSource = null;
            NhatKyDGV.Rows.Clear();
            NhatKyDGV.Refresh();
        }

        private void HanhDongCB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoiTuongCB2.Items.Clear();
            DoiTuongCB2.ResetText();
            if (HanhDongCB2.SelectedItem.ToString() != "Execute") {

                IList<string> ds = AdminBUS.ViewList();
                IList<string> ds2 = AdminBUS.TablesList2();
                foreach (string s in ds)
                {
                    DoiTuongCB2.Items.Add(s);
                }
                foreach (string s in ds2)
                {
                    DoiTuongCB2.Items.Add(s);
                }
            }
            else
            {
                IList<string> ds = AdminBUS.ProcList();
                foreach (string s in ds)
                {
                    DoiTuongCB2.Items.Add(s);
                }
            }

        }

        private void NhatKyHeThong_Load(object sender, EventArgs e)
        {

        }
    }
}
