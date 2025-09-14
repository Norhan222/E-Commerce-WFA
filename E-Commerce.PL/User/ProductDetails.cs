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

namespace E_Commerce.PL.User
{
    public partial class ProductDetails : Form
    {
        private readonly int productId;
        private readonly IproductService _productService;
        public ProductDetails(int productId ,IproductService productService)
        {
            InitializeComponent();
            this.productId = productId;
            _productService = productService;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            var Product = _productService.GetProductById(productId);
            label6.Text = Product.Name;
            label7.Text = Product.Description;
            label8.Text = $"${Product.Price.ToString()}";
            label9.Text = Product.Stock.ToString();
            label10.Text = Product.CategoryName;
            var fullpath = Path.Combine(Directory.GetParent(System.Windows.Forms.Application.StartupPath).Parent.Parent.Parent.FullName, Product.ImageUrl);
            if (File.Exists(fullpath))
            {
                using (var fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(fs);
                }
            }
        }
    }
}
