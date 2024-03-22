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
        AdminBUS adminBUS = new AdminBUS();
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
            DataTable dataTable = adminBUS.RoleList();
            RoleList.DataSource = dataTable;
              
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "Edit";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;

            RoleList.Columns.Add(editColumn);
            RoleList.Columns.Add(deleteColumn);

            RoleList.CellClick += RoleList_CellClick;
        }

        private void RoleList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string role = RoleList.Rows[e.RowIndex].Cells["ROLE"].Value.ToString();
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == RoleList.Columns["Edit"].Index)
                {
                    EditRole editRole = new EditRole(role);
                    editRole.Show();
                }
                else if (e.ColumnIndex == RoleList.Columns["Delete"].Index)
                {
                    try
                    {
                        adminBUS.DeleteRole(role);
                        MessageBox.Show("Delete success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
