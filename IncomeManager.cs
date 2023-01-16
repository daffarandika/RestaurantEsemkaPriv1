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
        public static string monthNumToMonthName(string monthNum)
        {
            string name = "";
            switch (monthNum)
            {
                case "01":
                    name = "Jan";
                    break;
                case "02":
                    name = "Feb";
                    break;
                case "03":
                    name = "Mar";
                    break;
                case "04":
                    name = "Apr";
                    break;
                case "05":
                    name = "May";
                    break;
                case "06":
                    name = "Jun";
                    break;
                case "07":
                    name = "Jul";
                    break;
                case "08":
                    name = "Aug";
                    break;
                case "09":
                    name = "Sep";
                    break;
                case "10":
                    name = "Oct";
                    break;
                case "11":
                    name = "Nov";
                    break;
                case "12":
                    name = "Dec";
                    break;
            }
            return name;
        }
        public static void newEntry(string year, string month)
        {
            string id = string.Format("{0}{1}", year, month);
            Helper.runQuery("insert into income values ('" + id + "', '" + year + "', '" + monthNumToMonthName(month) + "', 0)");
        }
        public static void updateEntry(string year, string month, string ammountToAddToIncome)
        {
            string id = string.Format("{0}{1}", year, month);
            int ammount = Convert.ToInt32(ammountToAddToIncome);
            int current = Convert.ToInt32(Helper.getValueFromSql("select * from income where id = '" + id + "'", "income"));
            Helper.runQuery("update income set income = '" + Convert.ToString(ammount + current) + "' where id = '" + id + "'");
        }
        public static bool monthEntryExists (string year, string month)
        {
            string id = string.Format("{0}{1}", year, month);
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
