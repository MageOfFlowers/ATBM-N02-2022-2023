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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(string user)
        {
            InitializeComponent();
            Label.Text = $"Xin chào {user}";
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void BtnTTCaNhan_Click(object sender, EventArgs e)
        {
            //nho truyen ma nhan vien / ma sinh vien vao
            ThongTinCaNhan_NhanSu _NhanSu = new ThongTinCaNhan_NhanSu("NV001");
            _NhanSu.Show();
        }
    }
}
