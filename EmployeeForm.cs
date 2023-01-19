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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            dgvEmp.Fill("select employeeid, name, email, handphone, position from employee");
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        void reset()
        {
            dgvEmp.Fill("select employeeid, name, email, handphone, position from employee");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EmployeeInsertForm employeeInsertForm = new EmployeeInsertForm();
            employeeInsertForm.ShowDialog();
            reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmp.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string employeeid = dgvEmp.CurrentRow.Cells["employeeid"].Value.ToString();
            Helper.runQuery("delete from employee where employeeid = '" + employeeid + "'");
            reset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEmp.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EmployeeUpdateForm employeeUpdateForm = new EmployeeUpdateForm(dgvEmp.CurrentRow.Cells["employeeid"].Value.ToString());
            employeeUpdateForm.ShowDialog();
            reset();
        }
    }
}
