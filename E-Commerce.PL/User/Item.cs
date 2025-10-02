using Autofac;
using E_Commerce.Application.Dtos;
using E_Commerce.Application;
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

namespace E_Commerce.PL.User
{
    public partial class Item : UserControl
    {
        private readonly IComponentContext _context;
        private readonly ICartService _cartService;
        Label lblid;
        public Item(IComponentContext context,ICartService cartService)
        {
            InitializeComponent();
            lblid = new Label();
            _context = context;
             _cartService = cartService;
        }

        [Browsable(true)]

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int ProductId
        {
            get => Convert.ToInt32(lblid.Text);
            set => lblid.Text = value.ToString();
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ProductName
        {
            get => lblProductname.Text;
            set => lblProductname.Text = value;
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public decimal ProductPrice
        {
            get => decimal.Parse(label1.Text.Replace("$", ""));
            set => label1.Text = $"${value}";
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image ProductIamge
        {
            get => ProductImage.Image;

            set => ProductImage.Image = value;
        }
        private void Item_Load(object sender, EventArgs e)
        {

        }

        private void ProductImage_Click(object sender, EventArgs e)
        {
            var productDetails = _context.Resolve<ProductDetails>();
            productDetails.LoadProduct(ProductId);//new ProductDetails(ProductId,_productService,_cartService);
            productDetails.ShowDialog();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (SessionManger.currentUser.Id == 0)
            {
                var login = _context.Resolve<Login>();
                login.ShowDialog();
            }
            else
            {


                var user = SessionManger.currentUser.Id;
                var cartDto = new CartDto
                {
                    UserId = SessionManger.currentUser.Id,
                    ProductId = ProductId,
                };
                _cartService.AddToCart(cartDto);
                iconPictureBox1.ForeColor = Color.Green;
            }

        }
    }
}
