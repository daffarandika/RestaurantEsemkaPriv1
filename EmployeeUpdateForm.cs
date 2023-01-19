using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantEsemka
{
    public partial class EmployeeUpdateForm : Form
    {
        string employeeID;
        TextBox[] inputFields;
        public EmployeeUpdateForm(string employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            inputFields = new TextBox[] { tbID, tbName, tbEmail, tbPassword, tbHandphone };
            tbID.Visible = false;
            cbxPosition.Fill(new string[] { "admin", "cashier", "chef"});
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(Vars.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from employee where employeeid = '" + employeeID + "'", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            tbName.Text = dt.Rows[0]["name"].ToString();
            tbEmail.Text = dt.Rows[0]["email"].ToString();
            tbHandphone.Text = dt.Rows[0]["handphone"].ToString();
            cbxPosition.Text = dt.Rows[0]["position"].ToString();
        }

        private void EmployeeUpdateForm_Load(object sender, EventArgs e)
        {
            tbID.Text = employeeID;
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            Close();
            reset();
        }
        void reset()
        {
            Helper.clearText(inputFields);
            cbxPosition.SelectedIndex = -1;
        }
    }
}
