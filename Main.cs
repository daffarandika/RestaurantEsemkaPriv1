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
    public partial class Main : Form
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
        public Main()
        {
            InitializeComponent();
        }
        
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            Hide();
            Main main= new Main();
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
                Main main = new Main(); 
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
            Employee employee = new Employee();
            employee.ShowDialog();
        }

        private void mENURESTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string max = Helper.getValueFromSql("select max(orderid) as max from headorder", "max");
            max = (Convert.ToInt32(max) + 1).ToString();
            MessageBox.Show(max.Length.ToString());
        }

        private void mEMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member member= new Member();
            member.ShowDialog();
        }

        private void oRDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreOrder po = new PreOrder();
            po.ShowDialog();
            if (po.DialogResult != DialogResult.Cancel)
            {
                Order order = new Order();
                order.ShowDialog();
            } 
        }

        private void vIEWORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewOrder vo = new ViewOrder();
            vo.ShowDialog();
        }

        private void pAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.ShowDialog();
        }

        private void rEPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
        }
    }
}
