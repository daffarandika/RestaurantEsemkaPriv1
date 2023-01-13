using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantEsemka
{
    internal static class Extensions
    {
        public static void showError(this TextBox tb, string message)
        {
            ErrorProvider ep = new ErrorProvider();
            ep.SetError(tb, message);
        }

        public static void Fill(this DataGridView dgv, string query, string[] to_hide)
        {
            using (var conn = new SqlConnection(Vars.connectionString))
            {
                DataTable dt = new DataTable();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(query, conn);    
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dt);
                dgv.DataSource = dt;
                dgv.AllowUserToAddRows = false;
                dgv.ReadOnly = true;
                dgv.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
                foreach (string s in to_hide)
                {
                    dgv.Columns[s].Visible = false;
                }
            }
        }
        public static void Fill(this DataGridView dgv, string[] columns)
        {
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns.Clear();
            }
            foreach (string s in columns)
            {
                dgv.Columns.Add(s, s);
            }
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible= false;
        }

        public static void Fill(this DataGridView dgv, string query)
        {
            using (var conn = new SqlConnection(Vars.connectionString))
            {
                DataTable dt = new DataTable();
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(query, conn);    
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dt);
                dgv.DataSource = dt;
                dgv.AllowUserToAddRows = false;
                dgv.ReadOnly = true;
                dgv.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            }
        }

        public static void Fill(this ComboBox cbx, string command, string displayMember, string valueMember)
        {
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(Vars.connectionString))
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(command, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dt);
                cbx.DataSource = dt;
                cbx.DisplayMember = displayMember;
                cbx.ValueMember = valueMember;
                cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            cbx.SelectedIndex = -1;
        }
        public static void Fill(this DataGridViewComboBoxColumn cbx, string[] rows)
        {
            if (cbx.Items.Count > 0)
            {
                cbx.Items.Clear();
            }
            foreach (string s in rows)
            {
                cbx.Items.Add(s);
            }
        }

        public static void Fill(this ComboBox cbx, string[] rows)
        {
            if (cbx.Items.Count > 0)
            {
                cbx.Items.Clear();
            }
            foreach (string s in rows)
            {
                cbx.Items.Add(s);
            }
            cbx.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
