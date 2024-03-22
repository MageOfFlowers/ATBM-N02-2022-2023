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

namespace ATBM
{
    public partial class Users : Form
    {
        AdminBUS adminBUS = new AdminBUS();
        public Users()
        {
            InitializeComponent();
        }

        private void UserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                string username = UserList.Rows[e.RowIndex].Cells["USERNAME"].Value.ToString();
                if (e.ColumnIndex == UserList.Columns["Edit"].Index)
                {
                    EditUser editUser = new EditUser(username);
                    editUser.Show();
                }
                else if (e.ColumnIndex == UserList.Columns["Delete"].Index)
                {
                    try
                    {
                        adminBUS.DeleteUser(username);
                        MessageBox.Show("Delete success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = adminBUS.UserList();
                UserList.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "Edit";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;

            UserList.Columns.Add(editColumn);
            UserList.Columns.Add(deleteColumn);

            UserList.CellClick += UserList_CellClick;
        }

        private void UserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }
    }
}
