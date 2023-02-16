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
    public partial class CashierNavigationForm : Form
    {
        public CashierNavigationForm()
        {
            InitializeComponent();
        }

        private void CashierNavigationForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = string.Format("Welcome, {0}", Vars.employeeName);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Hide();
            PreOrderForm of = new PreOrderForm();
            if (of.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            OrderForm order = new OrderForm();
            order.ShowDialog();
            Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Hide();
            PaymentForm of = new PaymentForm();
            of.ShowDialog();
            Show();
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
