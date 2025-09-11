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
        public FormUpdateCategory(DataGridViewRow gridViewRow)
        {
            InitializeComponent();
            txtName.Text = gridViewRow.Cells["Name"].Value?.ToString();
            txtDescription.Text= gridViewRow.Cells["Id"].Value?.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Dashbord).OpenChildForm(new FormCategory());
        }
    }
}
