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
    public partial class OrderDetailsForm : Form
    {
        private int orderid;
        private readonly IOrderService _orderService;

        public OrderDetailsForm(IOrderService orderService)
        {
            InitializeComponent();
            _orderService = orderService;
            dataGridView.Columns.Add("Product", "Product");
            dataGridView.Columns.Add("Quantity", "Quantity");
            dataGridView.Columns.Add("Price", "Price");
            dataGridView.Columns.Add("Total", "Total");



            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dataGridView.DefaultCellStyle.Font = new Font("segoe UI", 10);


        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            var order = _orderService.GetOrder(orderid);
            foreach (var item in order.OrderItems)
            {
                dataGridView.Rows.Add(item.Product.Name, item.Quantity, item.Price, item.Quantity * item.Price);
            }
        }


        public void GetOrderId(int id)
        {
            orderid = id;
        }

      
    }
}
