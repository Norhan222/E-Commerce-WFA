using Autofac;
using E_Commerce.Application.Dtos;
using E_Commerce.Application.Interfaces;
using E_Commerce.Core.Entites;
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
    public partial class AddProduct : Form
    {
        private readonly IComponentContext _context;
        private readonly ICategoryservice _categoryservice;
        private readonly IproductService _productService;

        public AddProduct(IComponentContext context,ICategoryservice categoryservice, IproductService productService)
        {
            InitializeComponent();
            _productService = productService;
            _context = context;
            _categoryservice = categoryservice;
            var cates = _categoryservice.GetAllcategoryies().ToList();
            comboBoxCategory.DataSource = cates;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
            _productService = productService;
        }
        string selectedImagePath = null;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = selectedImagePath;
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            if(!decimal.TryParse(txtPrice.Text,out _))
            {
                MessageBox.Show("Price Must be decimal");
                return;
            }
            var price = Convert.ToDecimal(txtPrice.Text);
            var categoryId = Convert.ToInt32(comboBoxCategory.SelectedValue);

            if (!int.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("Stock Must be number");
                return;
            }
            var stock = Convert.ToInt32(txtQuantity.Text);
            var description = guna2TextBoxDes.Text;
            if(selectedImagePath == null)
            {
                MessageBox.Show("Product Image Requird");
                return;
            }

            var imagefolder = Path.Combine(Directory.GetParent(System.Windows.Forms.Application.StartupPath).Parent.Parent.Parent.FullName, "Images", "Product");
            if (!Directory.Exists(imagefolder))
            {
                Directory.CreateDirectory(imagefolder);
            }
            var newfilename = Guid.NewGuid().ToString() + Path.GetExtension(selectedImagePath);
            var destPath = Path.Combine(imagefolder, newfilename);

            File.Copy(selectedImagePath, destPath, true);
            var relativepath = Path.Combine("Images", "Product", newfilename);

            var ProductDto = new CreateProductDto()
            {
                Name = name,
                Description = description,
                CategoryId = categoryId,
                Stock = stock,
                Price = price,
                ImageUrl = relativepath

            };
            var errors = Helper.Validate(ProductDto);
            if (errors.Any())
            {
                string message = String.Join("\n", errors.Select(e => e.ErrorMessage));
                MessageBox.Show(message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _productService.CreateProduct(ProductDto);
            _productService.Save();
            (this.ParentForm as Dashbord).OpenChildForm(_context.Resolve<AllProductForm>());

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Dashbord).OpenChildForm(_context.Resolve<AllProductForm>());
        }
    }
}
