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
    public partial class EditRole : Form
    {
        AdminBUS adminBUS = new AdminBUS();
        public EditRole()
        {
            InitializeComponent();
        }

        public EditRole(string role)
        {
            InitializeComponent();
            LoadQuyen(role);
        }

        private void LoadQuyen(string role)
        {
            try
            {
                DataTable dataTable = adminBUS.Xem_Quyen(role);
                QuyenView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditRole_Load(object sender, EventArgs e)
        {

        }
    }
}
