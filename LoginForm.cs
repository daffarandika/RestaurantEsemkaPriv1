using System;
using System.CodeDom;
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
    public partial class LoginForm : Form
    {
        bool show = false;
        public LoginForm()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (areMT())
            {
                return;
            }
            string email = tbEmail.Text;
            string password = Helper.toSha256(tbPassword.Text);
            using (var conn = new SqlConnection(Vars.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from employee where email = '" + email + "' and password = '" + password + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    Hide();
                    Vars.employeeID = reader["employeeid"].ToString();
                    Vars.employeeRole = reader["position"].ToString();
                    Vars.employeeName = reader["name"].ToString();
                    Redirect();
                    Close();
                } else
                {
                    MessageBox.Show("Please re-check your email and password", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void Redirect()
        {
            switch (Vars.employeeRole)
            {
                case "admin":
                    AdminNavigationForm admin = new AdminNavigationForm();
                    admin.ShowDialog();
                    break;
                case "chef":
                    ChefNavigationForm chef = new ChefNavigationForm();
                    chef.ShowDialog();
                    break;
                case "cashier":
                    CashierNavigationForm cashier = new CashierNavigationForm();
                    cashier.ShowDialog();
                    break;
                default: 
                    throw new Exception("salah login ");
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = show;
            show = !show;
            tbPassword.Focus();
        }

        public bool areMT ()
        {
            return Helper.areTextBoxesEmpty(new TextBox[] { tbEmail, tbPassword });
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
