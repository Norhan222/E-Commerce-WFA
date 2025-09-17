using E_Commerce.Application.Interfaces;
using E_Commerce.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.PL.Admin.ChildForm.Order
{
    public partial class OrderMangment : Form
    {
        private readonly IOrderService _orderService;
        private DataGridViewRow Row;
        public OrderMangment(IOrderService orderService)
        {
            InitializeComponent();
            _orderService = orderService;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.DefaultCellStyle.Font = new Font("segoe UI", 10);
            dataGridView.Columns.Add("OrderId", "OrderId");
            dataGridView.Columns.Add("CustomerName", "CustomerName");
            dataGridView.Columns.Add("TotalAmount", "TotalAmount");
            dataGridView.Columns.Add("Status", "Status");
            dataGridView.Columns.Add("OrderDate", "OrderDate");

            guna2ComboBoxStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
            foreach (var item in _orderService.GetOrders())
            {
                dataGridView.Rows.Add(item.Id, item.User.UserName, item.TotalAmount, item.Status, item.OrderDate);

            }


        }

        private void OrderMangment_Load(object sender, EventArgs e)
        {





        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                Row = dataGridView.CurrentRow;
                string status = dataGridView.CurrentRow.Cells["Status"].Value?.ToString();
                guna2ComboBoxStatus.SelectedItem = Enum.Parse(typeof(OrderStatus), status);
            }
        }

        private void btnupdateSataus_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (dataGridView.CurrentRow == Row)
                {
                    string status = guna2ComboBoxStatus.SelectedItem.ToString();
                    var order = _orderService.GetOrder(Convert.ToInt32(Row.Cells["OrderId"].Value));
                    order.Status =(OrderStatus) Enum.Parse(typeof(OrderStatus), status);
                    _orderService.Save();
                    dataGridView.CurrentRow.Cells["Status"].Value = status;
                }
            }

        }
    }
}
