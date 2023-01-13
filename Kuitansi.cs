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
        List<string> _qtys= new List<string>();
        List<string> _totals= new List<string>();
        public Kuitansi(List<string> foods, List<string>qtys, List<string>totals)
        {
            _foods= foods;
            _qtys= qtys;
            _totals=totals;
            InitializeComponent();
        }

        private void Kuitansi_Load(object sender, EventArgs e)
        {
            dgvKuitansi.Fill(new string[] { "menu", "qty", "total" });
            for (int i = 0; i < _foods.Count; i++)
            {
                dgvKuitansi.Rows.Add(_foods[i], _qtys[i], _totals[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
