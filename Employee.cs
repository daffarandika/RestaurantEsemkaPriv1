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
    public partial class Employee : Form
    {
        Control[] inputFields;
        public Employee()
        {
            InitializeComponent();
            inputFields = new Control[] { tbID, tbName, tbEmail, tbPassword, tbHandphone };
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
            string name = tbName.Text;
            string email = tbEmail.Text;
            string password = Helper.toSha256(tbPassword.Text);
            string handphone = tbHandphone.Text;
            string position = cbxPosition.Text;
            MessageBox.Show(inputFields.Length.ToString());
            Helper.runQuery("insert into employee (name, email, password, handphone, position) values ('" + name + "', '" + email + "', '" + password + "', '" + handphone + "', '" + position + "')");
            reset();
        }
    }
}
