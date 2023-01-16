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
    public partial class NonTunaiUC : UserControl
    {
        public int total { get; set; }
        public string orderID { get; set; }
        public string payment { get; set; }
        public NonTunaiUC()
        {
            InitializeComponent();
        }

        private void NonTunaiUC_Load(object sender, EventArgs e)
        {
            cbxBank.Fill(new string[] { "BCA", "BRI", "BTN", "Mandiri" });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Helper.areTextBoxesEmpty(new TextBox[] { tbCardNumber })) return;
            if (cbxBank.SelectedIndex < 0)
            {
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(cbxBank, "Input fields cannot be empty");
            }
            Helper.runQuery("update headorder set payment = '" + payment + "', bank = '"+cbxBank.Text+"' where orderid = '"+ orderID +"'");
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
        }
    }
}
