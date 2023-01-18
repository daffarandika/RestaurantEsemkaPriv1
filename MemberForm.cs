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
    public partial class MemberForm : Form
    {
        TextBox[] inputFields;
        public MemberForm()
        {
            InitializeComponent();
            inputFields = new TextBox  []
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
            if (Helper.areTextBoxesEmpty(inputFields)) return;
            string name = tbName.Text;
            string email = tbEmail.Text;
            string handphone = tbHandphone.Text;    
            string joindate = DateTime.Now.ToString("yyyy-MM-dd");
            Helper.runQuery("insert into member (name, email, handphone, joindate) values ('" + name + "', '" + email + "', '" + handphone + "', '" + joindate + "')");
            reset();
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvMember.CurrentRow;
            tbID.Text = row.Cells["memberid"].Value.ToString();
            tbName.Text = row.Cells["name"].Value.ToString();
            tbEmail.Text = row.Cells["email"].Value.ToString();
            tbHandphone.Text = row.Cells["handphone"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Helper.areTextBoxesEmpty(inputFields)) return;
            string memberid = tbID.Text;
            string name = tbName.Text;
            string email = tbEmail.Text;
            string handphone = tbHandphone.Text;
            Helper.runQuery("update member set name = '" + name + "', email = '" + email + "', '" + handphone + "' where memberid = '"+memberid+"'");
            reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string memberid = tbID.Text;
            Helper.runQuery("delete from member where memberid = '" + memberid + "'");
            reset();
        }
    }
}
