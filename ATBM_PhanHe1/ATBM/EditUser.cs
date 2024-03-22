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

        public EditUser(string username)
        {
            InitializeComponent();
            Username.Text = username;
            LoadQuyen(username);
        }

        private void LoadQuyen(string username) 
        {
            try
            {
                DataTable dataTable = adminBUS.Xem_Quyen(username);
                QuyenView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            
        }
    }
}
