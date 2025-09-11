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
        public FormAddCategory()
        {
            this.Text = "AddCategory";
            InitializeComponent();
        }

        private void FormAddCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Dashbord).OpenChildForm(new FormCategory());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name=txtName.Text;
            var Des = Int32.Parse(txtDescription.Text);
            var cat = new Category() { Id=Des,Name=name};
            cat.Add(cat);
            (this.ParentForm as Dashbord).OpenChildForm(new FormCategory());
        }
    }
}
