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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            roleName.Text = role;
            LoadQuyen(role);
        }

        private void LoadQuyen(string role)
        {
            try
            {
                DataTable dataTable = adminBUS.PrivsList(role);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Privilege p= new Privilege(roleName.Text,1);
            p.FormClosed += P_FormClosed;
            p.ShowDialog();
        }

        private void P_FormClosed(object sender, FormClosedEventArgs e)
        {
            string role = roleName.Text;
            Close();
            EditRole editRole = new EditRole(role);
            editRole.Show();
        }
    }
}
