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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATBM
{
    public partial class Privilege : Form
    {
        AdminBUS adminBUS = new AdminBUS();
        int type;
        public Privilege()
        {
            InitializeComponent();
        }
        public Privilege(string username,int t)
        {
            InitializeComponent();
            type = t;
            Username.Text = username;
            privCB.Items.Clear();
            privCB.Items.Add("SELECT");
            privCB.Items.Add("INSERT");
            privCB.Items.Add("UPDATE");
            privCB.Items.Add("DELETE");
            privCB.SelectedIndex = 0;
            privCB.SelectedIndexChanged += PrivCB_SelectedIndexChanged;
            if(t==0)//user
            {
                label1.Text = "User";
                WithGrant.Enabled = true;
                WithGrant.Visible = true;
            }
            else
            {
                label1.Text = "Role";
                WithGrant.Enabled = false;
                WithGrant.Visible = false;
            }
            
            CollumnCL.Enabled = false; CollumnCL.Visible = false; label4.Visible = false;
        }

        private void PrivCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(privCB.SelectedIndex==2)
            {
                CollumnCL.Enabled = true; CollumnCL.Visible=true; ; label4.Visible = true;
            }
            else
            {
                CollumnCL.Enabled = false;CollumnCL.Visible = false;label4.Visible=false;
            }
        }

        private void Privilege_Load(object sender, EventArgs e)
        {
            TablesCB.Items.Clear();
            DataTable dataTable = adminBUS.TablesList();
            foreach (DataRow row in dataTable.Rows)
            {
                string value = row["table_name"].ToString();
                TablesCB.Items.Add(value);
            }
            TablesCB.SelectedIndex = 0;
        }

        private void TablesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CollumnCL.Items.Clear();
            DataTable dataTable = adminBUS.CollumnsList(TablesCB.SelectedItem.ToString());
            foreach (DataRow row in dataTable.Rows)
            {
                string value = row["column_name"].ToString();
                CollumnCL.Items.Add(value);
            }
            for (int i = 0; i < CollumnCL.Items.Count; i++)
            {
                CollumnCL.SetItemChecked(i, true);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username=Username.Text;
            string priv=privCB.SelectedItem.ToString();
            string table=TablesCB.SelectedItem.ToString();
            bool withGrant = WithGrant.Checked;
            List<string> checkedValues = new List<string>();
            foreach (var item in CollumnCL.CheckedItems)
            {
                checkedValues.Add(item.ToString());
            }
            try
            {
                if (type == 0)
                {
                    adminBUS.AddPrivToUser(priv, table, username, checkedValues, withGrant);
                }
                else
                {
                    adminBUS.AddPrivToRole(priv, table, username, checkedValues);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }
    }
}
