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
    public partial class EditUser : Form
    {
        AdminBUS adminBUS = new AdminBUS();
        public bool start = true;
        public EditUser()
        {
            InitializeComponent();
        }

        public EditUser(string username, string status)
        {
            InitializeComponent();
            Username.Text = username;
            StatusCB.Items.Add("LOCKED");
            StatusCB.Items.Add("OPEN");
            StatusCB.SelectedItem = status;
            LoadQuyen(username);
            LoadRole(username);
            start = false;
        }

        private void LoadQuyen(string username) 
        {
            try
            {
                DataTable dataTable = adminBUS.PrivsList(username);
                QuyenView.DataSource = dataTable;
                QuyenView.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị quyền");
            }
        }

        private void LoadRole(string username)
        {
            try
            {
                DataTable dataTable = adminBUS.UserRole(username);
                RoleView.DataSource = dataTable;
                RoleView.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị Role");
            }

        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            RoleCB.Items.Add("None");
            RoleCB.SelectedItem = "None";
            try
            {
                DataTable dataTable = adminBUS.RoleList();
                foreach (DataRow row in dataTable.Rows)
                {
                    string value = row["granted_role"].ToString();
                    RoleCB.Items.Add(value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;

            QuyenView.Columns.Add(deleteColumn);

            QuyenView.CellClick += QuyenView_CellClick;
        }

        private void QuyenView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string table = QuyenView.Rows[e.RowIndex].Cells["TABLE_NAME"].Value.ToString();
            string priv = QuyenView.Rows[e.RowIndex].Cells["PRIVILEGE"].Value.ToString();
            string username = Username.Text;

            if (e.ColumnIndex == QuyenView.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                try
                {
                    adminBUS.RevokePriv(priv, table, username);
                    MessageBox.Show("Thu hồi thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thu hồi không thành công");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Privilege privilege = new Privilege(Username.Text,0);
            privilege.FormClosed += Privilege_FormClosed;
            privilege.ShowDialog();
            
        }

        private void Privilege_FormClosed(object sender, FormClosedEventArgs e)
        {
            string username=Username.Text;
            string status=StatusCB.SelectedItem.ToString();
            Close();
            EditUser editUser = new EditUser(username, status);
            editUser.Show();
        }

        private void QuyenView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string role=RoleCB.SelectedItem.ToString();
            if(role=="None")
            {
                MessageBox.Show("Vui lòng chọn một vai trò đề cấp");
            }
            else
            {
                string username = Username.Text;
                string status = StatusCB.SelectedItem.ToString();
                adminBUS.AddRoleToUser(role, username);
                Close();
                EditUser editUser = new EditUser(username, status);
                editUser.Show();
            }
        }

        private void StatusCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (start == false)
            {
                try
                {
                    string a_status = (StatusCB.SelectedItem.ToString() == "OPEN" ? "UNLOCK" : "LOCK");
                    adminBUS.ChangeStatus(Username.Text, a_status);
                    MessageBox.Show("Thành công");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }
    }
}
