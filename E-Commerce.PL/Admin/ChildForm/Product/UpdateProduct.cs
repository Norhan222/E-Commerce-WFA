using E_Commerce.Application.Dtos;
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
        private bool flag = false;
        private string imagePathold;
        private string oldRelativePath;
        Label idlbl;
        public UpdateProduct(DataGridViewRow gridViewRow, ICategoryservice categoryservice, IproductService productService)
        {
            InitializeComponent();
            _categoryservice = categoryservice;
            _productService = productService;
            idlbl = new Label();
            var cates = _categoryservice.GetAllcategoryies().ToList();
            comboBoxCategory.DataSource = cates;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";

            idlbl.Text = gridViewRow.Cells["Id"].Value?.ToString();
            txtName.Text = gridViewRow.Cells["Name"].Value?.ToString();
            textPrice.Text = gridViewRow.Cells["Price"].Value?.ToString();
            txtquantity.Text= gridViewRow.Cells["Quantity"].Value?.ToString();
            guna2TextBoxDes.Text = gridViewRow.Cells["Description"].Value?.ToString();
            comboBoxCategory.Text = gridViewRow.Cells["CategoryName"].Value?.ToString();
            oldRelativePath = gridViewRow.Cells["ImageUrl"].Value?.ToString();
            var imagefolder = Directory.GetParent(System.Windows.Forms.Application.StartupPath).Parent.Parent.Parent.FullName;
           var imagepath = Path.Combine(imagefolder, oldRelativePath);
            pictureBox1.Image = Image.FromFile(imagepath);
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }

            using (var fs = new FileStream(imagepath, FileMode.Open, FileAccess.Read))
            {
                pictureBox1.Image = Image.FromStream(fs);
            }

            imagePathold = imagepath;


        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Dashbord).OpenChildForm(new AllProductForm(_categoryservice, _productService));
        }
        string selectedImagePath = null;
        string relativepath;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                flag = true;
                selectedImagePath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = selectedImagePath;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var price = Convert.ToDecimal(textPrice.Text);
            var categoryId = Convert.ToInt32(comboBoxCategory.SelectedValue);
            var stock = Convert.ToInt32(txtquantity.Text);
            var description = guna2TextBoxDes.Text;
            if (flag == true)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }

                if (!string.IsNullOrEmpty(imagePathold) && File.Exists(imagePathold))
                {
                    File.Delete(imagePathold);
                    imagePathold = null;
                }
                var imagefolder = Path.Combine(Directory.GetParent(System.Windows.Forms.Application.StartupPath).Parent.Parent.Parent.FullName, "Images", "Product");
                if (!Directory.Exists(imagefolder))
                {
                    Directory.CreateDirectory(imagefolder);
                }
                var newfilename = Guid.NewGuid().ToString() + Path.GetExtension(selectedImagePath);
                var destPath = Path.Combine(imagefolder, newfilename);

                File.Copy(selectedImagePath, destPath, true);
                relativepath = Path.Combine("Images", "Product", newfilename);
              


               
            }
            else
            {
                relativepath = oldRelativePath;
            }
            var ProductDto = new UpdateProductDto()
            {
                Id = Convert.ToInt32(idlbl.Text),
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

            _productService.UpdateProduct(ProductDto);
            _productService.Save();
            (this.ParentForm as Dashbord).OpenChildForm(new AllProductForm(_categoryservice, _productService));
        }
    }
}
