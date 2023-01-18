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
using System.Xml.Linq;

namespace RestaurantEsemka
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            chart1.Series.Clear();
            chart1.Series.Add("Income");
        }

        void fillChart(string from, string to)
        {
            try
            {
                chart1.Series.Clear();
                using (var conn = new SqlConnection(Vars.connectionString)) {
                    conn.Open();
                    DataTable dt = new DataTable();
                    List<string> subqueries = new List<string>();
                    string query = "select ";
                    foreach (int i in Enumerable.Range(Convert.ToInt32(from), Convert.ToInt32(to)))
                    {
                        string month = new DateTime(DateTime.Now.Year, i, 1).ToString("MMM");
                        string dateFrom = new DateTime(DateTime.Now.Year, i, 1).ToString("yyyy-MM-dd");
                        string dateTo = new DateTime(DateTime.Now.Year, i, DateTime.DaysInMonth(DateTime.Now.Year, Convert.ToInt32(i))).ToString("yyyy-MM-dd");
                        string subquery = "(select sum(price * qty) from detailorder where _orderid in" +
                            "(select _orderid from headorder where date >= '" + dateFrom + "'and date <= '" + dateTo + "')) as '" + month + "'";
                        subqueries.Add(subquery);
                    }
                    query += string.Join(", ", subqueries.ToArray());
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);
                    chart1.DataSource = dt;
                    chart1.Series.Add("Income");
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        chart1.Series["Income"].Points.AddXY(dt.Columns[i].ColumnName, Convert.ToInt32(dt.Rows[0][i]));
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("One or more month that you chose does not have an income", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {
            string[] nums = new string[12];
            string[] names = new string[12];
            foreach (int i in Enumerable.Range(0, 12)) {
                nums[i] = (i + 1).ToString();
            }
            foreach (int i in Enumerable.Range(0, 12)) {
                names[i] = new DateTime(DateTime.Now.Year, (i+1), 01 ).ToString("MMM");
            }
            cbxFrom.Fill(names, nums);
            cbxTo.Fill(names, nums); }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbxFrom.SelectedValue) > Convert.ToInt32(cbxTo.SelectedValue))
            {
                MessageBox.Show("The months that you put is invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fillChart(cbxFrom.SelectedValue.ToString(), cbxTo.SelectedValue.ToString());
        }

        private void cbxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
