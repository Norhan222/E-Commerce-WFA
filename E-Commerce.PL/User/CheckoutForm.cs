using Autofac;
using E_Commerce.Application;
using E_Commerce.Application.Dtos;
using E_Commerce.Application.Interfaces;
using E_Commerce.Core.Entites;
using Microsoft.EntityFrameworkCore;
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
    public partial class CheckoutForm : Form
    {
        public Cart Cart;
        private decimal TotalPrice;
        private readonly IComponentContext _context;
        private readonly IOrderService _orderService;
        private readonly ICartService _cartService;

        public CheckoutForm(IComponentContext context, IOrderService orderService, ICartService cartService)
        {
            InitializeComponent();
            _context = context;
            _orderService = orderService;
            _cartService = cartService;
            dataGridView.Columns.Add("Product", "Product");
            dataGridView.Columns.Add("Quantity", "Quantity");
            dataGridView.Columns.Add("Price", "Price");
            dataGridView.Columns.Add("Total", "Total");



            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dataGridView.DefaultCellStyle.Font = new Font("segoe UI", 10);

        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {

        }

        public void Load(Cart cart)
        {
            Cart = cart;
            foreach (var item in Cart.CartItems)
            {
                dataGridView.Rows.Add(item.Product.Name, item.Quantity, item.Product.Price, item.Quantity * item.Product.Price);
                TotalPrice += item.Quantity * item.Product.Price;
            }

            lblPrice.Text = $"${TotalPrice}";
        }

        private void CheckoutForm_Load_1(object sender, EventArgs e)
        {

        }

        private void CheckoutForm_Load_2(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            int userid = SessionManger.currentUser.Id;
            var orderDto = new OrderDto()
            {
                UserId = userid,
                TotalAmount = TotalPrice,

            };
            orderDto.OrderItems = Cart.CartItems.Select(c => new OrderItemDto
            {
                ProductId = c.ProductId,
                Quantity = c.Quantity,
                UnitPrice = c.Product.Price,
                TotalPrice = c.Quantity * c.Product.Price,

            }).ToList();

            _orderService.PlaceOrder(orderDto);
            _cartService.ClearCart(userid);
            MessageBox.Show("Order Added Successfully");
        }

        private void CheckoutForm_Load_3(object sender, EventArgs e)
        {

        }

        private void CheckoutForm_Load_4(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var cartDetails = _context.Resolve<CartDetails>();
            cartDetails.Show();
        }
    }
}
