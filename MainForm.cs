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
    public partial class MainForm : Form
    {
        private void Main_Load(object sender, EventArgs e)
        {
            ToolStripItem[] notLoggedIn = { 
                logoutToolStripMenuItem, dATAToolStripMenuItem, tRANSACTIONToolStripMenuItem, rEPORTToolStripMenuItem, cHEFToolStripMenuItem
            };
            ToolStripItem[] admin = { 
                loginToolStripMenuItem
            };
            ToolStripItem[] chef = { 
                loginToolStripMenuItem, dATAToolStripMenuItem, tRANSACTIONToolStripMenuItem, rEPORTToolStripMenuItem
            };
            ToolStripItem[] cashier = {
                loginToolStripMenuItem, dATAToolStripMenuItem, cHEFToolStripMenuItem, rEPORTToolStripMenuItem
            };
            ToolStripItem[] toDisable = { };
            switch (Vars.employeeRole)
            {
                case "":
                    toDisable = notLoggedIn;
                    break;
                case "admin":
                    toDisable= admin;
                    break;
                case "chef":
                    toDisable= chef;
                    break;
                case "cashier":
                    toDisable = cashier;
                    break;
            }
            foreach (ToolStripItem t in toDisable)
            {
                t.Enabled = false;
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            Hide();
            MainForm main= new MainForm();
            main.ShowDialog();
            Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to logout ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Vars.employeeID = "";
                Vars.employeeRole = "";
                Hide();
                MainForm main = new MainForm(); 
                main.ShowDialog();
                Close();
            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void kARYAWANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.ShowDialog();
        }

        private void mENURESTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string max = Helper.getValueFromSql("select max(_orderid) as max from headorder", "max");
            max = (Convert.ToInt32(max) + 1).ToString();
            MessageBox.Show(max.Length.ToString());
        }

        private void mEMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberForm member= new MemberForm();
            member.ShowDialog();
        }

        private void oRDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreOrderForm po = new PreOrderForm();
            po.ShowDialog();
            if (po.DialogResult != DialogResult.Cancel)
            {
                OrderForm order = new OrderForm();
                order.ShowDialog();
            } 
        }

        private void vIEWORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewOrderForm vo = new ViewOrderForm();
            vo.ShowDialog();
        }

        private void pAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentForm payment = new PaymentForm();
            payment.ShowDialog();
        }

        private void rEPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.ShowDialog();
        }
    }
}
