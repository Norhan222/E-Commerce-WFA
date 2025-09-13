using E_Commerce.Application.Dtos;
using E_Commerce.Application.Interfaces;
using E_Commerce.PL.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.PL
{
    public partial class Register : Form
    {
        private readonly IAuthService _authService;
        private readonly ICategoryservice _categoryservice;
        private readonly IproductService productService;

        public Register(IAuthService authService,ICategoryservice categoryservice, IproductService productService)
        {
            InitializeComponent();
            _authService = authService;
           _categoryservice = categoryservice;
            this.productService = productService;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
          (this.ParentForm as Form1).OpenChildForm(new Login(_authService,_categoryservice,productService));
          
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            var username = guna2TextBoxUsername.Text;
            var email = guna2TextBoxEmail.Text;
            var password = guna2TextBoxPAssword.Text;
            var Register = new RegisterDto()
            {
                UserName = username,
                Email = email,
                Password = password,
                PhoneNumber = null

            };
            var errors = Helper.Validate(Register);
            if (errors.Any())
            {
                string message = String.Join("\n", errors.Select(e => e.ErrorMessage));
                MessageBox.Show(message,"Validation",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            await _authService.Register(Register);
            (this.ParentForm as Form1).OpenChildForm(new Login(_authService, _categoryservice,productService));
        }

        private void guna2TextBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
