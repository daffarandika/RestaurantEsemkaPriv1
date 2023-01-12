using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantEsemka
{
    internal class Helper
    {
        public static string toSha256(string input)
        {
            byte[] res;
            using (var sha256 = SHA256.Create())
            {
                res = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
                StringBuilder stringBuilder= new StringBuilder();
                foreach (byte b in res)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }

        public static void runQuery(string query)
        {
            using (var conn = new SqlConnection(Vars.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static bool hasRows(string query)
        {
            using (var conn = new SqlConnection(Vars.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                return reader.HasRows;
            }
        }

        public static bool areTextBoxesEmpty(TextBox[] boxes)
        {
            bool res = false;
            foreach (TextBox box in boxes)
            {
                if (box.Text == string.Empty)
                {
                    box.showError("Input cannot be empty");
                    res = true;
                }
            }
            return res;
        }
        public static void clearText(Control[] controls)
        {
            foreach (Control c in controls)
            {
                c.Text = String.Empty;
            }
        }

        public static string getValueFromSql(string command, string value)
        {
            using (var conn = new SqlConnection((string)Vars.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                return reader[value].ToString();
            }
        }

    }
}
