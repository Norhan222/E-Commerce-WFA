using E_Commerce.Application.Dtos;
using E_Commerce.Application.Interfaces;
using Microsoft.VisualBasic.Logging;
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
    public partial class FormAddCategory : Form
    {
        private readonly IAuthService _authService;
        private readonly ICategoryservice _categoryservice;

        public FormAddCategory(ICategoryservice categoryservice)
        {
            this.Text = "AddCategory";
            InitializeComponent();
            _categoryservice = categoryservice;
        }

        private void FormAddCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Dashbord).OpenChildForm(new FormCategory(_categoryservice));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            var name=txtName.Text;
            var Des = txtDescription.Text;
            var category = new CategoryDto()
            {
                Name = name,
                Description = Des,
            };
            var errors = Helper.Validate(category);
            if (errors.Any())
            {
                string message = String.Join("\n", errors.Select(e => e.ErrorMessage));
                MessageBox.Show(message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _categoryservice.createcategory(category);
            _categoryservice.save();
            (this.ParentForm as Dashbord).OpenChildForm(new FormCategory(_categoryservice));
        }
    }
}
