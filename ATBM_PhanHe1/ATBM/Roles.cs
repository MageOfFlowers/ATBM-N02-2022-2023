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
using Oracle.ManagedDataAccess.Client;

namespace ATBM
{
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRole addRole = new AddRole();
            addRole.Show();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            AdminBUS adminBUS = new AdminBUS();
            DataSet dataSet = adminBUS.RoleList();
            RoleList.DataSource = dataSet.Tables["roles"];
              
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;

            RoleList.Columns.Add(editColumn);
            RoleList.Columns.Add(deleteColumn);
        }
    }
}
