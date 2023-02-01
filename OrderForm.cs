using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantEsemka
{
    public partial class OrderForm : Form
    {
        string targetDir;
        string windowsUsername = Environment.UserName;
        TextBox[] inputFields;
        List<string> addedMenu = new List<string>();
        List<string> detailOrderQueries = new List<string>();

        public OrderForm()
        {
            string orderid = getOrderID();
            InitializeComponent();
            targetDir = @"C:\Users\" + windowsUsername + @"\Desktop\Restaurant Esemka\Images";
            inputFields = new TextBox[]
            {
                tbName, tbPrice, tbQty
            };
        }

        private string getOrderID()
        {
            string year = DateTime.Now.ToString("yyyy");
            string monthNum = DateTime.Now.ToString("MM");
            string orderid = year + monthNum + "0001";
            if (!Helper.hasRows("select * from headorder where orderid >= '" + orderid + "'"))
            {
                return orderid;
            }
            string max = Helper.getValueFromSql("select max(orderid) as max from headorder", "max");
            return (Convert.ToInt32(max) >= Convert.ToInt32(orderid)) ? (Convert.ToInt32(max) + 1).ToString() : orderid;
        }

        void fillDGVMenu()
        {
            dgvMenu.Fill("select * from menu order by name", new string[] {"menuid", "photo"});
        }

        private void Order_Load(object sender, EventArgs e)
        {
            fillDGVMenu();
            fillDgvOrder();
        }

        private void fillDgvOrder()
        {
            dgvOrder.Fill(new string[] { "menu", "qty", "price", "total" });
        }

        void clearText()
        {
            Helper.clearText(inputFields);
        }

        void resetMenu()
        {
            pbFood.Image = null;
            clearText();
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbName.Text = dgvMenu.CurrentRow.Cells["name"].Value.ToString();
            tbPrice.Text = dgvMenu.CurrentRow.Cells["price"].Value.ToString();
            pbFood.Image = Image.FromFile(targetDir + @"\" + dgvMenu.CurrentRow.Cells["photo"].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Helper.areTextBoxesEmpty(inputFields)) return;
            string menuid = dgvMenu.CurrentRow.Cells["menuid"].Value.ToString();
            string menuName = dgvMenu.CurrentRow.Cells["name"].Value.ToString();
            string qty = tbQty.Text;
            string price = tbPrice.Text;
            string orderid = getOrderID();
            string total = Convert.ToString(Convert.ToInt32(qty) * Convert.ToInt32(price));
            if (!addedMenu.Contains(tbName.Text))
            {
                addedMenu.Add(tbName.Text);
                dgvOrder.Rows.Add(new object[] {menuName, qty, price, total});
            } else
            {
                int index = addedMenu.IndexOf(menuName);
                dgvOrder.Rows[index].Cells["qty"].Value = Convert.ToString(Convert.ToInt32(qty) + Convert.ToInt32(dgvOrder.Rows[index].Cells["qty"].Value));
                dgvOrder.Rows[index].Cells["total"].Value = Convert.ToString(Convert.ToInt32(dgvOrder.Rows[index].Cells["qty"].Value) * Convert.ToInt32(dgvOrder.Rows[index].Cells["price"].Value));
            }
            detailOrderQueries.Add("insert into detailorder (orderid, menuid, qty, price, status) values ('" + orderid + "', '" + menuid + "', '" + qty + "', '" + price + "', 'pending')");
            lblTotal.Text = calculateTotal().ToString();
            resetMenu();
        }

        int calculateTotal()
        {
            int total = 0;
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                total += Convert.ToInt32(row.Cells["total"].Value);
            }
            return total;
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string orderid = getOrderID();
            Helper.runQuery("insert into headorder values('" + orderid + "', '" + Vars.employeeID + "', '" + Vars.memberID + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '0', '0')");
            foreach (string s in detailOrderQueries)
            {
                Helper.runQuery(s);
            }
            MessageBox.Show(orderid, "This is your order's id", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvOrder.Rows.Clear();
            lblTotal.Text = "0";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string max = Helper.getValueFromSql("select max(orderid) as max from headorder", "max");
            MessageBox.Show(max, "Order ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
