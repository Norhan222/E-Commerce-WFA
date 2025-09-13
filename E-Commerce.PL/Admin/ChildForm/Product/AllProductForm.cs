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
        private readonly ICategoryservice _categoryservice;
        private readonly IproductService _productService;


        public AllProductForm(ICategoryservice categoryservice,IproductService productService)
        {
            InitializeComponent();
         _categoryservice = categoryservice;
            _productService = productService;
           var products= _productService.GetAllProducts();
            dataGridView.Columns.Add("Id", "Id");
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Price", "Price");
            dataGridView.Columns.Add("Description", "Description");

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Picture";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView.Columns.Add(imageColumn);
            dataGridView.Columns.Add("CategoryName", "Category");
            // Image img = Properties.Resources.tsgirt;
            // Image resizedimg = new Bitmap(img, new Size(50, 50));
            // dataGridView.Rows.Add(1, "nour", "$12", resizedimg, "closhes");
            var imagefolder = Directory.GetParent(System.Windows.Forms.Application.StartupPath).Parent.Parent.Parent.FullName;
            foreach (var item in products)
            {
                var fullpath=Path.Combine(imagefolder, item.ImageUrl);
                Image img = null;
                if (File.Exists(fullpath))
                {
                    using(var fs=new FileStream(fullpath, FileMode.Open, FileAccess.Read))
                    {
                        img =Image.FromStream(fs);
                    }
                }
               Image resizedimg = new Bitmap(img, new Size(50, 50));
                dataGridView.Rows.Add(item.Id, item.Name,item.Price,item.Description, resizedimg,item.Category.Name);
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dataGridView.DefaultCellStyle.Font = new Font("segoe UI", 10);
           
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Dashbord).OpenChildForm(new AddProduct(_categoryservice,_productService));

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                var row = dataGridView.CurrentRow;
                (this.ParentForm as Dashbord).OpenChildForm(new UpdateProduct(row));

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
            (this.ParentForm as Dashbord).OpenChildForm(new AddProduct(_categoryservice,_productService));
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

            if (dataGridView.CurrentRow != null)
            {
                var row = dataGridView.CurrentRow;
                (this.ParentForm as Dashbord).OpenChildForm(new UpdateProduct(row));

            }
            else
            {
                MessageBox.Show("Please Select a row first!");
            }
        }
    }
}
