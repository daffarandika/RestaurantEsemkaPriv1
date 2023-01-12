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
        }
        // select * from status

        void fillCbxStatus()
        {
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(Vars.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from status", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                
            }
        }
        private void cbxOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderid = cbxOrderID.Text as string;
            fillDGV();
        }

        void fillDGV()
        {
            dgvOrder.Fill("select menu.name as menu, detailorder.qty, detailorder.status, orderid from detailorder join menu on detailorder.menuid = menu.menuid where orderid = '"+orderid+"'", new string[] { "orderid" });
        }
    }
}
