using E_Commerce.Application.Dtos;
using E_Commerce.Application.Interfaces;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.PL.Admin.ChildForm
{
    public partial class FormUpdateCategory : Form
    {
        private readonly ICategoryservice _categoryservice;
        private Label lblId;
        public FormUpdateCategory(DataGridViewRow gridViewRow, ICategoryservice categoryservice)
        {
            InitializeComponent();
            _categoryservice = categoryservice;
            lblId = new Label();
            lblId.Text = gridViewRow.Cells["Id"].Value?.ToString();
            txtName.Text = gridViewRow.Cells["Name"].Value?.ToString();
            txtDescription.Text = gridViewRow.Cells["Description"].Value?.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Dashbord).OpenChildForm(new FormCategory(_categoryservice));
        }

        private void FormUpdateCategory_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var Des = txtDescription.Text;
            var category = new CategoryDto()
            {
                CatId = Int32.Parse(lblId.Text),
                CatName=name,
                CatDescription=Des,
            };
            var errors = Helper.Validate(category);
            if (errors.Any())
            {
                string message = String.Join("\n", errors.Select(e => e.ErrorMessage));
                MessageBox.Show(message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _categoryservice.updatecategory(category);
            _categoryservice.Save();
            (this.ParentForm as Dashbord).OpenChildForm(new FormCategory(_categoryservice));

        }
    }
}
