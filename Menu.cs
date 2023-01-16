using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantEsemka
{
    public partial class Menu : Form
    {
        string windowsUsername = Environment.UserName;
        string targetDir;
        string FileName;
        TextBox[] inputFields;
        bool changeImage = false;
        public Menu()
        {
            InitializeComponent();
            targetDir = @"C:\Users\" + windowsUsername + @"\Desktop\Restaurant Esemka\Images";
            inputFields = new TextBox[]
            {
                tbID, tbName, tbPhoto, tbPrice
            };
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            fillDGV();
        }
        void fillDGV()
        {
            dgvMenu.Fill("select * from menu");
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            changeImage = true;
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Images (*.jpeg; *.jpg; *.png) | *.jpeg; *.jpg; *.png",
                Multiselect = false
            };
            if (ofd.ShowDialog() == DialogResult.OK) { 
                pbFood.Image = new Bitmap(ofd.FileName);
                FileName = ofd.FileName;
                tbPhoto.Text = ofd.SafeFileName;    
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (Helper.areTextBoxesEmpty(inputFields)) return;
            Directory.CreateDirectory(targetDir);
            File.Copy(
                FileName,
                Path.Combine(targetDir, Path.GetFileName(FileName)),
                true);
            string name = tbName.Text;
            string price = tbPrice.Text;
            string photo = tbPhoto.Text;
            Helper.runQuery("insert into menu (name, price, photo) values ('" + name + "', '" + price + "', '" + photo + "')");
            reset();
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dgvMenu.CurrentRow.Cells["menuid"].Value.ToString();
            tbName.Text = dgvMenu.CurrentRow.Cells["name"].Value.ToString();
            tbPrice.Text = dgvMenu.CurrentRow.Cells["price"].Value.ToString();
            tbPhoto.Text = dgvMenu.CurrentRow.Cells["photo"].Value.ToString();
            pbFood.Image = Image.FromFile(targetDir + @"\" + tbPhoto.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string menuid = tbID.Text;
            Helper.runQuery("delete from menu where menuid = '" + menuid + "'");
            reset();
        }
        void reset()
        {
            pbFood.Image = null;
            Helper.clearText(inputFields);
            fillDGV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string menuid = tbID.Text;
            string name = tbName.Text;
            string price = tbPrice.Text;
            string photo = tbPhoto.Text;
            if (!changeImage)
            {
                Helper.runQuery("update menu set name = '" + name + "', price = '" + price + "' where menuid = '" + menuid + "'");
                reset();
                return;
            } 
            Directory.CreateDirectory(targetDir);
            File.Copy(
                FileName,
                Path.Combine(targetDir, Path.GetFileName(FileName)),
                true);
            Helper.runQuery("update menu set name = '" + name + "', price = '" + price + "', photo = '" + photo + "' where menuid = '" + menuid + "'");
            reset();
        }
    }
}
