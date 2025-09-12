using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.PL.Admin.ChildForm.Product
{
    public partial class AllProductForm : Form
    {
        public AllProductForm()
        {
            InitializeComponent();
            dataGridView.Columns.Add("Id", "Id");
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Price", "Price");
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Picture";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView.Columns.Add(imageColumn);
            dataGridView.Columns.Add("CategoryName", "Category");
            Image img = Properties.Resources.tsgirt;
            Image resizedimg = new Bitmap(img, new Size(50, 50));
            dataGridView.Rows.Add(1, "nour", "$12", resizedimg, "closhes");
            //foreach (var item in Categories)
            //{
            //    dataGridView.Rows.Add(item.Id, item.Name);
            //}
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dataGridView.DefaultCellStyle.Font = new Font("segoe UI", 10);

        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Dashbord).OpenChildForm(new FormAddCategory());

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                var row = dataGridView.CurrentRow;
                (this.ParentForm as Dashbord).OpenChildForm(new FormUpdateCategory(row));

            }
            else
            {
                MessageBox.Show("Please Select a row first!");
            }

        }









        private void AllProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            (this.ParentForm as Dashbord).OpenChildForm(new AddProduct());
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

            if (dataGridView.CurrentRow != null)
            {
                var row = dataGridView.CurrentRow;
                (this.ParentForm as Dashbord).OpenChildForm(new UpdateProduct(row));

            }
            else
            {
                MessageBox.Show("Please Select a row first!");
            }
        }
    }
}
