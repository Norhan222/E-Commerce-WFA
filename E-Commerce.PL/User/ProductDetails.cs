using E_Commerce.Application;
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

namespace E_Commerce.PL.User
{
    public partial class ProductDetails : Form
    {
        private int _productId;
        private readonly IproductService _productService;
        private readonly ICartService _cartService;

        public ProductDetails( IproductService productService,ICartService cartService)
        {
            InitializeComponent();
            _productService = productService;
           _cartService = cartService;
        }
        public void LoadProduct(int productid)
        {
           _productId = productid;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            var Product = _productService.GetProductById(_productId);
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

        private void guna2Buttonaddtocart_Click(object sender, EventArgs e)
        {
            var user = SessionManger.currentUser.Id;
            var cartDto = new CartDto
            {
                UserId = SessionManger.currentUser.Id,
                ProductId = _productId,
            };
            _cartService.AddToCart(cartDto);
;            guna2Buttonaddtocart.Text = "Added";
            guna2Buttonaddtocart.FillColor = Color.Green;
        }


       
    }
}
