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
        public Kuitansi(List<string> foods, List<string> prices, List<string>qtys, List<string>totals)
        {
            _prices= prices;
            _foods= foods;
            _qtys= qtys;
            _totals=totals;
            InitializeComponent();
        }

        private void Kuitansi_Load(object sender, EventArgs e)
        {
            //dgvKuitansi.Fill(new string[] { "menu", "qty", "total" });
            //for (int i = 0; i < _foods.Count; i++)
            //{
            //    dgvKuitansi.Rows.Add(_foods[i], _qtys[i], _totals[i]);
            //}
            TableLayoutPanel table = new TableLayoutPanel();
            table.Location = new Point(12, 12);
            table.Name = "Kuitansi table";
            table.Size = new Size(302, 461);
            table.BackColor = SystemColors.Window;
            table.ColumnCount = 5;
            table.RowCount = _foods.Count;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            Label lbl = new Label
            {
                Text = "woi ",
                BackColor = SystemColors.HotTrack
            };
            for (int i = 0; i < _foods.Count; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
                table.Controls.Add(lbl, 2, i);
            }
            Controls.Add(table);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
