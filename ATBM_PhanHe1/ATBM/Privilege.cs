﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATBM.BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATBM
{
    public partial class Privilege : Form
    {
        AdminBUS adminBUS = new AdminBUS();
        public Privilege()
        {
            InitializeComponent();
        }

        private void Privilege_Load(object sender, EventArgs e)
        {
            DataTable dataTable = adminBUS.TablesList();
            foreach (DataRow row in dataTable.Rows)
            {
                string value = row["table_name"].ToString();
                TablesCB.Items.Add(value);
            }
        }
    }
}
