using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }

        public EditUser(string username)
        {
            InitializeComponent();
            Username.Text = username;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {

        }
    }
}
