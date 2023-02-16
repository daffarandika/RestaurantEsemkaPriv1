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
    public partial class AdminNavigationForm : Form
    {
        public AdminNavigationForm()
        {
            InitializeComponent();
        }

        private void AdminNavigationForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = string.Format("Welcome, {0}", Vars.employeeName);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Vars.employeeID = "";
            Vars.employeeRole = "";
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Hide();
            MenuForm employee = new MenuForm();
            employee.ShowDialog();
            Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Hide();
            ResetPasswordForm reset = new ResetPasswordForm();
            reset.ShowDialog();
            Show();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            Hide();
            MemberForm employee = new MemberForm();
            employee.ShowDialog();
            Show();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            Hide();
            EmployeeForm employee = new EmployeeForm();
            employee.ShowDialog();
            Show();
        }
    }
}
