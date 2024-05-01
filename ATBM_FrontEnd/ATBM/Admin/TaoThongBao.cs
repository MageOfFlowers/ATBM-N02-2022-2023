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

namespace ATBM.Admin
{
    public partial class TaoThongBao : Form
    {
        AdminBUS AdminBUS = new AdminBUS();
        public TaoThongBao()
        {
            InitializeComponent();
            string[] ds = { "Trưởng khoa", "Trưởng đơn vị", "Giảng viên", "Giáo vụ", "Nhân viên", "Sinh viên" };
            LevelCB.Items.AddRange(ds);
            string[] ds2 = { "HTTT", "CNPM", "KHMT", "CNTT", "TGMT", "MMT" };
            CompartmentCLB.Items.AddRange(ds2);
            string[] ds3 = { "Cơ sở 1", "Cơ sở 2"};
            GroupCLB.Items.AddRange(ds3);

            CompartmentCLB.CheckOnClick = true;
            GroupCLB.CheckOnClick = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TaoThongBao_Load(object sender, EventArgs e)
        {

        }

        private void LevelCLB_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Tao_Click(object sender, EventArgs e)
        {
            string selectedItems = LevelCB.SelectedItem.ToString();
            
            if (LevelCB.SelectedItem != null) {
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
                        if (item == "Cơ sở 1") { tmp = "CS1"; }
                        else if (item == "Cơ sở 2") { tmp = "CS2"; }

                        group += tmp + ",";
                    }
                    group = group.Substring(0, group.Length - 1);
                }
                if (compartment == "") { compartment = null; }
                if (group == "") { group = null; }
                string noidung = NoiDung.Text;
                AdminBUS.ThemThongBao(noidung, level, compartment, group);
                MessageBox.Show("Thành công!");

            }
            else
            {
                MessageBox.Show("Phải chọn Level");
            }
            
        }
    }
}
