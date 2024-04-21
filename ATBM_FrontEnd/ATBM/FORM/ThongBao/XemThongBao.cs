using ATBM.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM.FORM.ThongBao
{
    public partial class XemThongBao : Form
    {
        readonly ThongBaoBUS thongBaoBUS = new ThongBaoBUS(); 
        public XemThongBao()
        {
            InitializeComponent();
        }

        private void XemThongBao_Load(object sender, EventArgs e)
        {
            dgvThongBao.Rows.Clear();
            dgvThongBao.DataSource = thongBaoBUS.LayThongBao();
        }
    }
}
