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
    public partial class Payment : Form
    {
        List<string> foods= new List<string>();
        List<string> prices= new List<string>();
        List<string> qtys= new List<string>();
        List<string> totals= new List<string>();
        string orderid;
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            cbxOrderID.Fill("select * from headorder where payment = '0'", "orderid", "orderid");
            cbxMetode.Fill(new string[] { "cash", "debit", "credit" });
        }

        private void cbxOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total = 0;
            orderid = cbxOrderID.Text;
            dgvPayment.Fill("select menu.name as menu, orderid, qty, detailorder.price from detailorder join menu on detailorder.menuid = menu.menuid where orderid = '" + orderid + "'");
            dgvPayment.Columns["orderid"].Visible= false;
            if (dgvPayment.Columns.Contains("total"))
            {
                dgvPayment.Columns.Remove("total");
            }
            dgvPayment.Columns.Add("total", "total");
            foreach (DataGridViewRow row in dgvPayment.Rows)
            {
                row.Cells["total"].Value = Convert.ToString(Convert.ToInt32(row.Cells["price"].Value) * Convert.ToInt32(row.Cells["qty"].Value));
                total += Convert.ToInt32(row.Cells["total"].Value);
            }
            lblTotal.Text = total.ToString();
        }

        private void tbnSave_Click(object sender, EventArgs e)
        {
        }

        private void btnKuitansi_Click(object sender, EventArgs e)
        {
            //if (tbBayar.Text.Length == 0)
            //{
            //    tbBayar.showError("input cannot be empty");
            //    return;
            //}
            //foreach (DataGridViewRow r in dgvPayment.Rows)
            //{
            //    foods.Add(r.Cells["menu"].Value.ToString());
            //    prices.Add(r.Cells["price"].Value.ToString());
            //    qtys.Add(r.Cells["qty"].Value.ToString());
            //    totals.Add(r.Cells["total"].Value.ToString());
            //}
            //Kuitansi kuitansi= new Kuitansi(foods, prices, qtys, totals);
            //kuitansi.ShowDialog();
        }

        private void cbxMetode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOrderID.SelectedIndex == -1)
            {
                MessageBox.Show("There are no transaction to be made for this order", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvPayment.Rows.Count < 1)
            {
                MessageBox.Show("Select the order ID first!!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TunaiUC tunai = new TunaiUC();
            NonTunaiUC nonTunai = new NonTunaiUC();
            tunai.total = Convert.ToInt32(lblTotal.Text);
            tunai.orderID = orderid;
            nonTunai.total = Convert.ToInt32(lblTotal.Text);
            nonTunai.orderID = orderid;
            nonTunai.payment = cbxMetode.Text;

            if (cbxMetode.SelectedIndex == 0)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(tunai);
            } else if (cbxMetode.SelectedIndex == 1 || cbxMetode.SelectedIndex == 2)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(nonTunai);
            } else
            {
                panel1.Controls.Clear();
            }
        }
    }
}
