using E_Commerce.Application.Interfaces;
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
        private readonly ICategoryservice _categoryservice;
        private readonly IproductService _productService;

        public UpdateProduct(DataGridViewRow gridViewRow,ICategoryservice categoryservice,IproductService productService)
        {
            InitializeComponent();
            _categoryservice = categoryservice;
           _productService = productService;
            var cates = _categoryservice.GetAllcategoryies().ToList();
            comboBoxCategory.DataSource = cates;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
          
            txtName.Text = gridViewRow.Cells["Name"].Value?.ToString();
            textPrice.Text = gridViewRow.Cells["Price"].Value?.ToString();
            guna2TextBoxDes.Text = gridViewRow.Cells["Description"].Value?.ToString();
            comboBoxCategory.Text = gridViewRow.Cells["CategoryName"].Value?.ToString();
            var img = gridViewRow.Cells[4].Value;
            if (img is Image img2)
            {
                Image resizedimg = new Bitmap(img2, new Size(200, 200));
                pictureBox1.Image = img2;
            }

        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           (this.ParentForm as Dashbord).OpenChildForm(new AllProductForm(_categoryservice, _productService));
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
