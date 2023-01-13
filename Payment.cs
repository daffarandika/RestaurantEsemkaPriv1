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
        List<string> qtys= new List<string>();
        List<string> totals= new List<string>();
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            cbxOrderID.Fill("select * from headorder", "orderid", "orderid");
        }

        private void cbxOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total = 0;
            string orderid = cbxOrderID.Text;
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
            int bayar = Convert.ToInt32(tbBayar.Text);
            int total = Convert.ToInt32(lblTotal.Text);
            int kembali = bayar - total;
            if (kembali < 0)
            {
                MessageBox.Show("Uang yang diterima kurang dari total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbKembali.Text = kembali.ToString();
        }

        private void btnKuitansi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvPayment.Rows)
            {
                foods.Add(r.Cells["menu"].Value.ToString());
                qtys.Add(r.Cells["qty"].Value.ToString());
                totals.Add(r.Cells["total"].Value.ToString());
            }
            Kuitansi kuitansi= new Kuitansi(foods, qtys, totals);
            kuitansi.ShowDialog();
        }
    }
}
