using E_Commerce.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
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
        private readonly ICategoryservice _categoryservice;
        public FormCategory(ICategoryservice categoryservice)
        {
            InitializeComponent();
            this.Text = "Categories";
            _categoryservice = categoryservice;

            dataGridView.Columns.Add("Id", "Id");
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Description", "Description");

            foreach (var item in _categoryservice.GetAllcategoryies())
            {
                dataGridView.Rows.Add(item.CatId, item.CatName, item.CatDescription);
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dataGridView.DefaultCellStyle.Font = new Font("segoe UI", 10);
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Dashbord).OpenChildForm(new FormAddCategory(_categoryservice));

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                var row = dataGridView.CurrentRow;
                (this.ParentForm as Dashbord).OpenChildForm(new FormUpdateCategory(row, _categoryservice));

            }
            else
            {
                MessageBox.Show("Please Select a row first!");
            }

        }

        private void FormCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        
            try
            {
                // 1- Check if a category is selected
                if (dataGridView.CurrentRow == null)
                {
                    MessageBox.Show("Please select a category first.");
                    return;
                }

                int categoryId = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);

                // 2- Confirmation message
                var result = MessageBox.Show("Are you sure you want to delete this category?",
                                             "Delete Confirmation",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.No) return;

                // 3- Check if category has related products
                //var hasProducts = _dbContext.Products.Any(p => p.CategoryId == categoryId);
                //if (hasProducts)
                //{
                //    MessageBox.Show("⚠️ Cannot delete this category because it has related products.");
                //    return;
                //}

                // 4- Delete category
                var category =_categoryservice.getcategory(categoryId);
                if (category != null)
                {
                    _categoryservice.deletecategory(category);
                    _categoryservice.Save();
                    MessageBox.Show("✅ Category deleted successfully.");
                    dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting: " + ex.Message);
            }
        
    }
    }
}
