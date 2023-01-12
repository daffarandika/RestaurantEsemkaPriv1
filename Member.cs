using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantEsemka
{
    public partial class Member : Form
    {
        Control[] inputFields;
        public Member()
        {
            InitializeComponent();
            inputFields = new Control[]
            {
                tbID, tbName, tbEmail, tbHandphone
            };
        }

        private void Member_Load(object sender, EventArgs e)
        {
            fillDGV();
        }

        private void fillDGV()
        {
            dgvMember.Fill("select * from member");
            dgvMember.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";
        }

        void clearText()
        {
            Helper.clearText(inputFields);
        }

        void reset()
        {
            fillDGV();
            clearText();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string handphone = tbHandphone.Text;    
            string joindate = DateTime.Now.ToString("yyyy-MM-dd");
            Helper.runQuery("insert into member (name, email, handphone, joindate) values ('" + name + "', '" + email + "', '" + handphone + "', '" + joindate + "')");
            reset();
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}
