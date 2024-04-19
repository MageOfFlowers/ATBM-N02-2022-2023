﻿using ATBM.Admin.BUS;
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
            LevelCLB.Items.AddRange(ds);
            string[] ds2 = { " HTTT", "CNPM", "KHMT", "CNTT", "TGMT", "MMT" };
            CompartmentCLB.Items.AddRange(ds2);
            string[] ds3 = { " Cơ sở 1", "Cơ sở 2"};
            GroupCLB.Items.AddRange(ds3);

            LevelCLB.CheckOnClick = true;
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
            CheckedListBox.CheckedItemCollection selectedItems = LevelCLB.CheckedItems;
            
            if (selectedItems.Count > 0 ) {
                string level = "";
                foreach (string item in selectedItems)
                {
                    string tmp = "";
                    if (item == "Trưởng khoa") { tmp = "TK"; }
                    else if (item == "Trưởng đơn vị") { tmp = "TDV"; }
                    else if (item == "Giảng viên") { tmp = "GVien"; }
                    else if (item == "Giáo vụ") { tmp = "GVu"; }
                    else if (item == "Nhân viên") { tmp = "NV"; }
                    else if (item == "Sinh viên") { tmp = "SV"; }

                    level += tmp + ",";
                }
                level.Remove(level.Length - 1, 1);

                CheckedListBox.CheckedItemCollection selectedItems2 = CompartmentCLB.CheckedItems;
                string compartment = "";
                if (selectedItems2.Count > 0)
                {
                    foreach (string item in selectedItems2)
                    {
                        compartment += item + ",";
                    }
                    compartment.Remove(compartment.Length - 1, 1);
                }

                CheckedListBox.CheckedItemCollection selectedItems3 = GroupCLB.CheckedItems;
                string group = "";
                if (selectedItems3.Count > 0)
                {
                    foreach (string item in selectedItems3)
                    {
                        string tmp = "";
                        if (item == "Cở sở 1") { tmp = "CS1"; }
                        else if (item == "Cơ sở 2") { tmp = "CS2"; }

                        group += tmp + ",";
                    }
                    group.Remove(group.Length - 1, 1);
                }
                if (compartment == "") { compartment = null; }
                if (group == "") { group = null; }
                string noidung = NoiDung.Text;
                AdminBUS.ThemThongBao(noidung, level, compartment, group);

            }
            else
            {
                MessageBox.Show("Phải chọn Level");
            }
            
        }
    }
}