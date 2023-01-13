using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantEsemka
{
    public partial class ViewOrder : Form
    {
        string orderid;
        public ViewOrder()
        {
            InitializeComponent();
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            cbxOrderID.Fill("select * from headorder", "orderid", "orderid");
            fillCbxStatus();
        }

        void fillCbxStatus()
        {
            cbxStatus.Fill(new string[] {"pending", "cooking", "delivered"});
        }
        private void cbxOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderid = cbxOrderID.Text as string;
            fillDGV();
        }

        void fillDGV()
        {
            using (var conn = new SqlConnection(Vars.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select detailid, menu.name as menu, detailorder.qty, detailorder.status, orderid from detailorder join menu on detailorder.menuid = menu.menuid where orderid = '"+orderid+"'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                dgvOrder.Rows.Clear();
                while (reader.Read())
                {
                    dgvOrder.Rows.Add(reader["detailid"], reader["menu"], reader["qty"], reader["status"]);
                }
            }
        }

        private void dgvOrder_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox box = (ComboBox)e.Control;
            if (box != null)
            {
                box.SelectedIndexChanged -= cbxStatusChanged;
                box.SelectedIndexChanged += cbxStatusChanged;
            }
        }

        private void cbxStatusChanged(object sender, EventArgs e)
        {
            string status = ((ComboBox)sender).Text.ToString();
            string detailid = dgvOrder.CurrentRow.Cells[0].Value.ToString();
            Helper.runQuery("update detailorder set status = '" + status + "' where detailid = '" + detailid + "' ");
        }
    }
}
