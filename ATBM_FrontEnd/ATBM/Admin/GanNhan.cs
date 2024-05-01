using ATBM.Admin.BUS;
using ATBM.Admin.DTO;
using ATBM.BUS;
using ATBM.DTO;
using System;
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
    public partial class GanNhan : Form
    {
        AdminBUS AdminBUS = new AdminBUS();
        public GanNhan()
        {
            InitializeComponent();
            string[] ds = { "Trưởng khoa", "Trưởng đơn vị", "Giảng viên", "Giáo vụ", "Nhân viên", "Sinh viên" };
            LevelCB.Items.AddRange(ds);
            string[] ds2 = { "HTTT", "CNPM", "KHMT", "CNTT", "TGMT", "MMT" };
            CompartmentCLB.Items.AddRange(ds2);
            string[] ds3 = { "Cơ sở 1", "Cơ sở 2" };
            GroupCLB.Items.AddRange(ds3);
            IList<string> ds1 = AdminBUS.UserList2();
            foreach (string item in ds1)
            {
                NguoiDungCB.Items.Add(item);
            }

            CompartmentCLB.CheckOnClick = true;
            GroupCLB.CheckOnClick = true;

        }

        private void GanNhan_Load(object sender, EventArgs e)
        {

        }

        private void NguoiDungCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItems = NguoiDungCB.SelectedItem.ToString();
            string level = AdminBUS.LevelLabel(selectedItems);
            int i = LevelCB.FindStringExact(level);

            if (i != -1)
            {
                LevelCB.SelectedIndex = i;
            }
            IList<string> ds = AdminBUS.CompartmentLabel(selectedItems);
            IList<string> ds2 = AdminBUS.GroupLabel(selectedItems);
            foreach (string item in ds)
            {
                int index = CompartmentCLB.Items.IndexOf(item);
                if (index != -1)
                {
                    CompartmentCLB.SetItemChecked(index, true);
                }
            }
            foreach (string item in ds2)
            {
                int index = GroupCLB.Items.IndexOf(item);
                if (index != -1)
                {
                    GroupCLB.SetItemChecked(index, true);
                }
            }

        }

        private void Tao_Click(object sender, EventArgs e)
        {
            string selectedItems = LevelCB.SelectedItem.ToString();

            if (LevelCB.SelectedItem != null)
            {
                string level = "";

                string tmp = "";
                if (selectedItems == "Trưởng khoa") { tmp = "TK"; }
                else if (selectedItems == "Trưởng đơn vị") { tmp = "TDV"; }
                else if (selectedItems == "Giảng viên") { tmp = "GVien"; }
                else if (selectedItems == "Giáo vụ") { tmp = "GVu"; }
                else if (selectedItems == "Nhân viên") { tmp = "NV"; }
                else if (selectedItems == "Sinh viên") { tmp = "SV"; }

                level += tmp;

                CheckedListBox.CheckedItemCollection selectedItems2 = CompartmentCLB.CheckedItems;
                string compartment = "";
                if (selectedItems2.Count > 0)
                {
                    foreach (string item in selectedItems2)
                    {
                        compartment += item + ",";
                    }
                    compartment = compartment.Substring(0, compartment.Length - 1);
                }

                CheckedListBox.CheckedItemCollection selectedItems3 = GroupCLB.CheckedItems;
                string group = "";
                if (selectedItems3.Count > 0)
                {
                    foreach (string item in selectedItems3)
                    {
                        tmp = "";
                        if (item == "Cở sở 1") { tmp = "CS1"; }
                        else if (item == "Cơ sở 2") { tmp = "CS2"; }

                        group += tmp + ",";
                    }
                    group = group.Substring(0, group.Length - 1);
                }
                if (compartment == "") { compartment = null; }
                if (group == "") { group = null; }
                string NguoiDung = NguoiDungCB.SelectedItem.ToString();
                AdminBUS.GanNhan(NguoiDung, level, compartment, group);
                MessageBox.Show("Thành công!");
            }
            else
            {
                MessageBox.Show("Phải chọn Level");
            }
        }
    }
}
