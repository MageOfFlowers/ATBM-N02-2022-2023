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
    public partial class AddRole : Form
    {
        public AddRole()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AdminBUS adminBUS = new AdminBUS();
                adminBUS.AddRole(RoleName.Text);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("không hợp lệ");
            }
            finally
            {
                Close();
            }
        }

        private void AddRole_Load(object sender, EventArgs e)
        {

        }
    }
}
