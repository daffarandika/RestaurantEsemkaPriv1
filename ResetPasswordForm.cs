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
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string currentPassword = Helper.getValueFromSql("select * from employee where employeeid = '" + Vars.employeeID + "'", "password");
            string oldPassword = Helper.toSha256(tbOldPassword.Text);
            string newPassword = Helper.toSha256(tbNewPassword.Text);
            string confirmPassword = Helper.toSha256(tbConfirmPassword.Text);
            if (currentPassword != oldPassword)
            {
                MessageBox.Show("Old Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirmation password don\'t match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Helper.runQuery("update employee set password = '" + newPassword + "'");
            Hide();
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {
        }
    }
}
