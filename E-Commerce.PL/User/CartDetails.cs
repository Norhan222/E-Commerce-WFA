using Autofac;
using E_Commerce.Application;
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
    public partial class CartDetails : Form
    {
        private readonly IComponentContext _context;
        private readonly ICartService _cartService;
        private decimal total = 0;
        public Cart Cart;
        public CartDetails(IComponentContext context, ICartService cartService)
        {
            InitializeComponent();
            _context = context;
            _cartService = cartService;
        }

        public void CartDetails_Load(object sender, EventArgs e)
        {
            var userid = SessionManger.currentUser.Id;
             Cart = _cartService.GetCartById(userid);
            foreach (var item in Cart.CartItems)
            {

                var CartItem = _context.Resolve<CartItem>();
                CartItem.Id = item.ProductId;
                CartItem.ProductName = item.Product.Name;
                CartItem.ProductPrice = item.Product.Price;
                CartItem.ProductPrice = item.Product.Price;
                CartItem.quantity = item.Quantity;
                CartItem.TotalPrice = item.Product.Price * item.Quantity;

                var fullpath = Path.Combine(Directory.GetParent(System.Windows.Forms.Application.StartupPath).Parent.Parent.Parent.FullName, item.Product.ImageUrl);
                if (File.Exists(fullpath))
                {
                    using (var fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read))
                    {
                        CartItem.ProductIamge = Image.FromStream(fs);
                    }
                }
                flowPanelCarts.Controls.Add(CartItem);
                

            }


        }
      
        private void TotalPrice_Click(object sender, EventArgs e)
        {

        }
        public void load()
        {
            var userid = SessionManger.currentUser.Id;
            var cart = _cartService.GetCartById(userid);
            foreach (var item in cart.CartItems)
            {
                var CartItem = _context.Resolve<CartItem>();
                CartItem.Id = item.ProductId;
                CartItem.ProductName = item.Product.Name;
                CartItem.ProductPrice = item.Product.Price;
                CartItem.ProductPrice = item.Product.Price;
                CartItem.quantity = item.Quantity;
                CartItem.TotalPrice = item.Product.Price * item.Quantity;

                var fullpath = Path.Combine(Directory.GetParent(System.Windows.Forms.Application.StartupPath).Parent.Parent.Parent.FullName, item.Product.ImageUrl);
                if (File.Exists(fullpath))
                {
                    using (var fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read))
                    {
                        CartItem.ProductIamge = Image.FromStream(fs);
                    }
                }
                flowPanelCarts.Controls.Add(CartItem);
                //total+=CartItem.TotalPrice;
                //TotalPrice.Text = total.ToString();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var checoutform=_context.Resolve<CheckoutForm>();
            checoutform.Load(Cart);
          
            checoutform.Show();
        }
    }
}
