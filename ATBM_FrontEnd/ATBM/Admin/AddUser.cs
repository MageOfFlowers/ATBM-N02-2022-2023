using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATBM
{
    public partial class AddUser : Form
    {
        AdminBUS adminBUS = new AdminBUS();
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            string role = RoleCB.SelectedItem.ToString();
            try
            {
                adminBUS.AddUser(username, password);
                if (role != "None" ) 
                {
                    adminBUS.AddRoleToUser(role, username);
                }
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không hợp lệ");
            }
            finally
            {
                Close();
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
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
        }
    }
}
