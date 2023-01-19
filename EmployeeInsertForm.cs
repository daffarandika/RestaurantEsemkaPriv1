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
    public partial class EmployeeInsertForm : Form
    {
        TextBox[] inputFields;
        public EmployeeInsertForm()
        {
            InitializeComponent();
            inputFields = new TextBox[] { tbName, tbEmail, tbPassword, tbHandphone };
            cbxPosition.Fill(new string[] { "admin", "cashier", "chef"});
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            Close();
        }
        void reset()
        {
            Helper.clearText(inputFields);
            cbxPosition.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void EmployeeInsertForm_Load(object sender, EventArgs e)
        {
            cbxPosition.SelectedIndex = -1;
        }
    }
}
