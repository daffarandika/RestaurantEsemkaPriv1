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
    public partial class EmployeeForm : Form
    {
        TextBox[] inputFields;
        public EmployeeForm()
        {
            InitializeComponent();
            inputFields = new TextBox[] { tbID, tbName, tbEmail, tbPassword, tbHandphone };
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            cbxPosition.Fill(new string[] { "admin", "cashier", "chef"});
            dgvEmp.Fill("select * from employee");
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dgvEmp.CurrentRow.Cells["employeeid"].Value.ToString();
            tbName.Text = dgvEmp.CurrentRow.Cells["name"].Value.ToString();
            tbEmail.Text = dgvEmp.CurrentRow.Cells["email"].Value.ToString();
            tbPassword.Text = dgvEmp.CurrentRow.Cells["password"].Value.ToString();
            tbHandphone.Text = dgvEmp.CurrentRow.Cells["handphone"].Value.ToString();
            cbxPosition.Text = dgvEmp.CurrentRow.Cells["position"].Value.ToString();
        }
        void reset()
        {
            dgvEmp.Fill("select * from employee");
            Helper.clearText(inputFields);
            cbxPosition.SelectedIndex = -1;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (Helper.areTextBoxesEmpty(inputFields)) return;
            if (!tbHandphone.validatePhoneNumber()) return;
            if (!tbEmail.validateEmail()) return;
            string name = tbName.Text;
            string email = tbEmail.Text;
            string password = Helper.toSha256(tbPassword.Text);
            string handphone = tbHandphone.Text;
            string position = cbxPosition.Text;
            Helper.runQuery("insert into employee (name, email, password, handphone, position) values ('" + name + "', '" + email + "', '" + password + "', '" + handphone + "', '" + position + "')");
            reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string employeeid = tbID.Text;
            Helper.runQuery("delete from employee where employeeid = '" + employeeid + "'");
            reset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Helper.areTextBoxesEmpty(inputFields)) return;
            if (!tbHandphone.validatePhoneNumber()) return;
            if (!tbEmail.validateEmail()) return;
            string employeeid = tbID.Text;
            string name = tbName.Text;
            string email = tbEmail.Text;
            string password = Helper.toSha256(tbPassword.Text);
            string handphone = tbHandphone.Text;
            string position = cbxPosition.Text;
            Helper.runQuery("update employee set name = '" + name + "', email = '"+email+"', password = '" + password + "', handphone = '" + handphone + "', position = '" + position + "' where employeeid = '"+employeeid+"'");
            reset();
        }
    }
}
