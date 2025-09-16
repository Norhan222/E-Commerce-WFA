using Autofac;
using E_Commerce.Application;
using E_Commerce.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.PL.User
{
    public partial class CartItem : UserControl
    {
        private readonly IComponentContext _context;
        private readonly ICartService _cartService;
        Label lblProductid;

        public CartItem(IComponentContext context, ICartService cartService)
        {
            InitializeComponent();
            lblProductid = new Label();
            _context = context;
            _cartService = cartService;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        [Browsable(true)]

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Id
        {
            get => Convert.ToInt32(lblProductid.Text);
            set => lblProductid.Text = value.ToString();
        }
        //[Browsable(true)]

        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        //public int CartId
        //{
        //    get => Convert.ToInt32(lblCartid.Text);
        //    set => lblCartid.Text = value.ToString();
        //}
        [Browsable(true)]

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int quantity
        {
            get => Convert.ToInt32(lblQuantity.Text);
            set => lblQuantity.Text = value.ToString();
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ProductName
        {
            get => lblProductName.Text;
            set => lblProductName.Text = value;
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public decimal ProductPrice
        {
            get => decimal.Parse(lblProductPrice.Text.Replace("$", ""));
            set => lblProductPrice.Text = $"${value}";
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public decimal TotalPrice
        {
            get => decimal.Parse(lblPrice.Text.Replace("$", ""));
            set => lblPrice.Text = $"${value}";
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image ProductIamge
        {
            get => picProductImage.Image;

            set => picProductImage.Image = value;
        }

        private void CartItem_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var userid = SessionManger.currentUser.Id;
            _cartService.RemoveFromCart(userid, Id);
            CartDetails cart = _context.Resolve<CartDetails>();
            cart.Show();
        }
     
        private void btnPlus_Click(object sender, EventArgs e)
        {
            var cart = _cartService.GetCartById(SessionManger.currentUser.Id);
            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == Id);
            cartItem.Quantity = ++quantity;
            TotalPrice+=ProductPrice;
            _cartService.Save();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            var cart = _cartService.GetCartById(SessionManger.currentUser.Id);
            var cartItem = cart.CartItems.Where(ci => ci.ProductId == Id).First();

            if (quantity <= 0)
            {
                quantity = 1;

            }
            else
            {
                cartItem.Quantity = --quantity;
                TotalPrice -= ProductPrice;

            }
            _cartService.Save();
        }
    }
}
