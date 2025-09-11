using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon.Primitives;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace E_Commerce.PL.Admin.ChildForm
{
    public partial class FormCategory : Form
    {
        List<Category> Categories =Category.categories;
        public FormCategory()
        {
            InitializeComponent();
            this.Text = "Categories";
            dataGridView.Columns.Add("Id", "Id");
            dataGridView.Columns.Add("Name", "Name");
            foreach (var item in Categories)
            {
                dataGridView.Rows.Add(item.Id, item.Name);
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        private void FormCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
