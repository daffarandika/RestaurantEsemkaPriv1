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
    public partial class ChefNavigationForm : Form
    {
        public ChefNavigationForm()
        {
            InitializeComponent();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            Hide();
            ViewOrderForm vo = new ViewOrderForm();
            vo.ShowDialog();
            Show();
        }

        private void ChefNavigationForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = string.Format("Welcome, {0}", Vars.employeeName);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Hide();
            ResetPasswordForm reset = new ResetPasswordForm();
            reset.ShowDialog();
            Show();
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
    }
}
