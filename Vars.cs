using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RestaurantEsemka
{
    internal class Vars
    {
        public static string employeeID = "";
        public static string employeeRole = "";
        public static string memberID = "";
        public static string connectionString = "Data Source=DESKTOP-GHNE639;Initial Catalog=RestaurantDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static string phoneNumberRegex = @"^\d{1,13}$";
        public static Regex pRegex = new Regex(phoneNumberRegex);
    }
}
