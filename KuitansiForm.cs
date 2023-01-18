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
    public partial class Kuitansi : Form
    {
        List<string> _foods= new List<string>();
        List<string> _prices= new List<string>();
        List<string> _qtys= new List<string>();
        List<string> _totals= new List<string>();
        string _orderid;
        string html;
        string _bank;
        string _cardNumber;
        int _tunai;
        int _kembali;
        public Kuitansi(List<string> foods, List<string> prices, List<string>qtys, List<string> totals, string orderid, int tunai, int kembali)
        {
            _prices = prices;
            _foods = foods;
            _qtys = qtys;
            _totals = totals;
            _tunai= tunai;
            _kembali= kembali;
            _orderid = orderid;
            InitializeComponent();
        }
        public Kuitansi(List<string> foods, List<string> prices, List<string>qtys, List<string> totals, string orderid, string bank, string cardNumber)
        {
            _prices = prices;
            _foods = foods;
            _qtys = qtys;
            _totals = totals;
            _bank= bank;
            _cardNumber= cardNumber;
            _orderid = orderid;
            InitializeComponent();
        }

        private void Kuitansi_Load(object sender, EventArgs e)
        {
            html = generatePrintable();
            webBrowser1.DocumentText = html;
        }

        private string generatePrintable()
        {
            if (_bank == null)
            {
                string htmlStart = @"<!DOCTYPE html> <html lang='en'> <head> <style> .title{ display: flex; justify-content: center; } td { padding: 3pt; } </style> </head> <body> <h1 class='title'>Restaurant</h1> <p>Tunai : "+_tunai+"</p><p>Kembali : "+_kembali+"</p><table> <tr> <td>No</td> <td>Name</td> <td>Price</td> <td>Qty</td> <td>Total</td> </tr> ";
                string htmlContent = "";
                for (int i = 0; i < _foods.Count; i++)
                {
                    htmlContent += "<tr>" +
                        "<td>" + Convert.ToInt32(i + 1) +"</td>" +
                        "<td>" + _foods[i] +"</td>" +
                        "<td>" + _prices[i] +"</td>" +
                        "<td>" + _qtys[i] +"</td>" +
                        "<td>" + _totals[i] +"</td>" +
                        "</tr>";
                }
                string htmlEnd = @" </table> <br>  <br> <br><small> <table> <tr> <td>Cashier : "+ Vars.employeeName +"</td> <td>Order No : "+_orderid+"</td> </tr> <tr><td><p>THANK YOU ! COME AGAIN !</p></td></tr> </table> </small> </body> </html> ";
                return htmlStart + htmlContent + htmlEnd;
            } else
            {
                string htmlStart = @"<!DOCTYPE html> <html lang='en'> <head> <style> .title{ display: flex; justify-content: center; } td { padding: 3pt; } </style> </head> <body> <h1 class='title'>Restaurant</h1> <p>Bank : "+_bank+"</p> <p>Card Number : "+_cardNumber+"</p><table> <tr> <td>No</td> <td>Name</td> <td>Price</td> <td>Qty</td> <td>Total</td> </tr> ";
                string htmlContent = "";
                for (int i = 0; i < _foods.Count; i++)
                {
                    htmlContent += "<tr>" +
                        "<td>" + Convert.ToInt32(i + 1) +"</td>" +
                        "<td>" + _foods[i] +"</td>" +
                        "<td>" + _prices[i] +"</td>" +
                        "<td>" + _qtys[i] +"</td>" +
                        "<td>" + _totals[i] +"</td>" +
                        "</tr>";
                }
                string htmlEnd = @" </table> <br>  <br> <br><small> <table> <tr> <td>Cashier : "+ Vars.employeeName +"</td> <td>Order No : "+_orderid+"</td> </tr> <tr><td><p>THANK YOU ! COME AGAIN !</p></td></tr> </table> </small> </body> </html> ";
                return htmlStart + htmlContent + htmlEnd;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            html += "<script> window.print() </script>";
            webBrowser1.DocumentText = html;
        }
    }
}
