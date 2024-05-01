using ATBM.Admin;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            roles.ShowDialog();
        }

        private void GanNhan_Click(object sender, EventArgs e)
        {
            GanNhan g = new GanNhan();
            g.ShowDialog();
        }

        private void TaoThongBao_Click(object sender, EventArgs e)
        {
            TaoThongBao t = new TaoThongBao();
            t.ShowDialog();
        }

        private void NhatKyHeThong_Click(object sender, EventArgs e)
        {
            NhatKyHeThong t = new NhatKyHeThong();
            t.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
