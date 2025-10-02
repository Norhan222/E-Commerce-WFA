using Autofac;
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
    public partial class AllProductForm : Form
    {
        private readonly IComponentContext _context;
        private readonly ICategoryservice _categoryservice;
        private readonly IproductService _productService;
        private string imagefolder;

        public AllProductForm(IComponentContext context,   ICategoryservice categoryservice, IproductService productService)
        {
            InitializeComponent();
            _context = context;
            _categoryservice = categoryservice;
            _productService = productService;
            var products = _productService.GetAllProducts();
            dataGridView.Columns.Add("Id", "Id");
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Price", "Price");
            dataGridView.Columns.Add("Description", "Description");
            dataGridView.Columns.Add("Quantity", "Quantity");

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Picture";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView.Columns.Add(imageColumn);
            dataGridView.Columns.Add("CategoryName", "Category");
            dataGridView.Columns.Add("ImageUrl", "Image Url");
            dataGridView.Columns["ImageUrl"].Visible = false;
            // Image img = Properties.Resources.tsgirt;
            // Image resizedimg = new Bitmap(img, new Size(50, 50));
            // dataGridView.Rows.Add(1, "nour", "$12", resizedimg, "closhes");
             imagefolder = Directory.GetParent(System.Windows.Forms.Application.StartupPath).Parent.Parent.Parent.FullName;
            foreach (var item in products)
            {
                var fullpath = Path.Combine(imagefolder, item.ImageUrl);
                Image img = null;
                if (File.Exists(fullpath))
                {
                    using (var fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read))
                    {
                        img = Image.FromStream(fs);
                    }
                }
                Image resizedimg = new Bitmap(img, new Size(50, 50));
                dataGridView.Rows.Add(item.Id, item.Name, item.Price, item.Description, item.Stock, resizedimg, item.CategoryName, item.ImageUrl);
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dataGridView.DefaultCellStyle.Font = new Font("segoe UI", 10);

        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Dashbord).OpenChildForm(_context.Resolve<AddProduct>());

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                var row = dataGridView.CurrentRow;
                (this.ParentForm as Dashbord).OpenChildForm(_context.Resolve<UpdateProduct>());

            }
            else
            {
                MessageBox.Show("Please Select a row first!");
            }

        }









        private void AllProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            (this.ParentForm as Dashbord).OpenChildForm(_context.Resolve<AddProduct>());
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

            if (dataGridView.CurrentRow != null)
            {
                var row = dataGridView.CurrentRow;
                (this.ParentForm as Dashbord).OpenChildForm(new UpdateProduct(_context,row, _categoryservice, _productService));

            }
            else
            {
                MessageBox.Show("Please Select a row first!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.CurrentRow == null)
                {
                    MessageBox.Show("Please select a category first.");
                    return;
                }

                int productId = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);

                // 2- Confirmation message
                var result = MessageBox.Show("Are you sure you want to delete this product?",
                                             "Delete Confirmation",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.No) return;

                // 3- Check if category has related products
                //var hasProducts = _dbContext.Products.Any(p => p.CategoryId == categoryId);
                //if (hasProducts)
                //{
                //    MessageBox.Show("⚠️ Cannot delete this category because it has related products.");
                //    return;
                //}

                // 4- Delete category
                var product = _productService.GetProductById(productId);
                if (product != null)
                {
                    var imagepath=Path.Combine(imagefolder, product.ImageUrl);
                   
                    _productService.DeleteProduct(product);
                    _productService.Save();
                    if (File.Exists(imagepath))
                    {
                        File.Delete(imagepath);
                    }
                    MessageBox.Show("✅ Product deleted successfully.");
                    dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting: " + ex.Message);
            }
        }
    }
}
