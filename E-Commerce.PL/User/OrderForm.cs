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
    public partial class OrderForm : Form
    {
        private readonly IComponentContext _context;
        private readonly IOrderService _orderService;

        public OrderForm(IComponentContext context, IOrderService orderService)
        {
            InitializeComponent();
            _context = context;
            _orderService = orderService;

            dataGridView.Columns.Add("OrderDate", "OrderDate");
            dataGridView.Columns.Add("TotalPrice", "TotalPrice");
            dataGridView.Columns.Add("OrderId", "OrderId");
            dataGridView.Columns["OrderId"].Visible = false;
            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
            viewButtonColumn.HeaderText = "Action";
            viewButtonColumn.Text = "Details";
            viewButtonColumn.Name = "btndetils";
            viewButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(viewButtonColumn);
            dataGridView.Columns["btndetils"].Width = 100;



            var userid = SessionManger.currentUser.Id;
            var orders = _orderService.GetOrdersForUser(userid);
            foreach (var item in orders)
            {
                dataGridView.Rows.Add(item.OrderDate, item.TotalAmount, item.Id);
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int orderid = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["OrderId"].Value);

                var orderdetails = _context.Resolve<OrderDetailsForm>();
                orderdetails.GetOrderId(orderid);
                orderdetails.ShowDialog();
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridView.Columns[e.ColumnIndex].Name == "btndetils")
            {
                int orderId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["OrderId"].Value);
                OrderDetailsForm detailsForm = _context.Resolve<OrderDetailsForm>();
                detailsForm.GetOrderId(orderId);
                detailsForm.ShowDialog();
            }
        }
    }
}
