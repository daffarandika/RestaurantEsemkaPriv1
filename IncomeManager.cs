using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEsemka
{
    internal class IncomeManager
    {
        public static void newEntry(string year, string month)
        {
            string id = string.Format("{0}_{1}", year, month);
            Helper.runQuery("insert into income values ('" + id + "', '" + year + "', '" + month + "', 0)");
        }
        public static void updateEntry(string year, string month, string ammountToAddToIncome)
        {
            string id = string.Format("{0}_{1}", year, month);
            int ammount = Convert.ToInt32(ammountToAddToIncome);
            int current = Convert.ToInt32(Helper.getValueFromSql("select * from income where id = '" + id + "'", "income"));
            Helper.runQuery("update income set income = '" + Convert.ToString(ammount + current) + "' where id = '" + id + "'");
        }
        public static bool monthEntryExists (string year, string month)
        {
            string id = string.Format("{0}_{1}", year, month);
            using (var conn = new SqlConnection(Vars.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from income where id = '" + id + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                return reader.HasRows;
            }
        }
    }
}
