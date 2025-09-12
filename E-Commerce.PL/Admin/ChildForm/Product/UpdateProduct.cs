using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.PL.Admin.ChildForm.Product
{
    public partial class UpdateProduct : Form
    {
        public UpdateProduct(DataGridViewRow gridViewRow)
        {
            InitializeComponent();
            txtName.Text = gridViewRow.Cells["Name"].Value?.ToString();
            textPrice.Text = gridViewRow.Cells["Price"].Value?.ToString();
            var img = gridViewRow.Cells[3].Value;
            if (img is Image img2)
            {
                Image resizedimg = new Bitmap(img2, new Size(200, 200));
                pictureBox1.Image = resizedimg;
            }
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Dashbord).OpenChildForm(new AllProductForm());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
