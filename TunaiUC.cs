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
    public partial class TunaiUC : UserControl
    {
        public int total { get; set; }
        public string orderID { get; set; }
        TextBox[] inputFields;
        public TunaiUC()
        {
            InitializeComponent();
            inputFields = new TextBox[]
            {
                tbBayar, tbKembali
            };
        }


        private void tbnSave_Click(object sender, EventArgs e)
        {
            if (Helper.areTextBoxesEmpty(inputFields))
            {
                return;
            }
            int bayar = Convert.ToInt32(tbBayar.Text);
            int kembali = bayar - total;
            if (kembali < 0)
            {
                MessageBox.Show("The amount recieved is less than the total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbKembali.Text = kembali.ToString();
            Helper.runQuery("update headorder set payment = 'cash' where orderid = '" + orderID + "'");
            MessageBox.Show("Transaction has been completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
        }

        void reset()
        {
            DataGridView dgvPayment = (DataGridView) Parent.Parent.Controls.Find("dgvPayment", true)[0];
            ComboBox cbxMetode = (ComboBox)Parent.Parent.Controls.Find("cbxMetode", true)[0];
            ComboBox cbxOrderID = (ComboBox)Parent.Parent.Controls.Find("cbxOrderID", true)[0];
            Label label = (Label)Parent.Parent.Controls.Find("lblTotal", true)[0];
            cbxMetode.SelectedIndex = -1;
            cbxOrderID.SelectedIndex = -1;
            dgvPayment.DataSource = null;
            dgvPayment.Columns.Clear();
            label.Text = "0";
            cbxOrderID.Fill("select * from headorder where payment = '0'", "orderid", "orderid");
        }

        private void TunaiUC_Load(object sender, EventArgs e)
        {

        }
    }
}
