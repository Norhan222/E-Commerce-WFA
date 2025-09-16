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
        public OrderMangment()
        {
            InitializeComponent();

            dataGridView.Columns.Add("OrderId", "OrderId");
            dataGridView.Columns.Add("CustomerName", "CustomerName");
            dataGridView.Columns.Add("TotalAmount", "TotalAmount");
            dataGridView.Columns.Add("Status", "Status");
            dataGridView.Columns.Add("OrderDate", "OrderDate");

        }

        private void OrderMangment_Load(object sender, EventArgs e)
        {
            guna2ComboBoxStatus.DataSource=Enum.GetValues(typeof(OrderStatus));
        }
    }
}
