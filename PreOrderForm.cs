using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantEsemka
{
    public partial class PreOrderForm : Form
    {
        public PreOrderForm()
        {
            InitializeComponent();
        }


        private void PreOrder_Load(object sender, EventArgs e)
        {
            cbxMember.Fill("select * from member", "name", "memberid");
            cbxMember.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxMember.SelectedIndex != -1)
            {
                Vars.memberID = cbxMember.SelectedValue.ToString();
                this.DialogResult= DialogResult.OK;
                Close();
                return;
            }
            MessageBox.Show("Please select a member first", "Alert !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void PreOrder_Leave(object sender, EventArgs e)
        {
        }
        
    }
}
