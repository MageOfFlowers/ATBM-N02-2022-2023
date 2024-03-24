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
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
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
                MessageBox.Show("Please choose a role to grant");
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
            string a_status = (StatusCB.SelectedItem == "OPEN" ? "UNLOCK" : "LOCK");
            try
            {
                adminBUS.ChangeStatus(Username.Text, a_status);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
