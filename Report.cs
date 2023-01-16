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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        void fillChart(string from, string to)
        {
            if (from.Length == 1)
            {
                from = "0" + from;
            }
            if (to.Length == 1)
            {
                to = "0" + to;
            }
            string year = DateTime.Now.ToString("yyyy");
            string idFrom = year + from;
            string idTo = year + to;
            chart1.Series.Clear();
            using (var conn = new SqlConnection(Vars.connectionString))
            {
                MessageBox.Show("select * from income where id >= '" + idFrom + "' && id <= '" + idTo + "' ");
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from income where id >= '" + idFrom + "' and id <= '" + idTo + "' ", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                chart1.DataSource= ds;
                chart1.Series.Add("Income");
                chart1.Series["Income"].XValueMember = "month";
                chart1.Series["Income"].YValueMembers = "income";
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {
            string[] nums = new string[12];
            foreach (int i in Enumerable.Range(0, 12)) {
                nums[i] = (i + 1).ToString();
            }
            fillChart("1", "12");
            cbxFrom.Fill(
                new string[]
                {
                    "Jan",
                    "Feb",
                    "Mar",
                    "Apr",
                    "May",
                    "Jun",
                    "Jul",
                    "Aug",
                    "Sep",
                    "Oct",
                    "Nov",
                    "Dec"
                }, nums);
            cbxTo.Fill(
                new string[]
                {
                    "Jan",
                    "Feb",
                    "Mar",
                    "Apr",
                    "May",
                    "Jun",
                    "Jul",
                    "Aug",
                    "Sep",
                    "Oct",
                    "Nov",
                    "Dec"
                }, nums);
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbxFrom.SelectedValue) > Convert.ToInt32(cbxTo.SelectedValue))
            {
                MessageBox.Show("invalid");
                return;
            }
            fillChart(cbxFrom.SelectedValue.ToString(), cbxTo.SelectedValue.ToString());
        }

        private void cbxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
