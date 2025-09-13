using E_Commerce.Application.Dtos;
using E_Commerce.Application.Interfaces;
using E_Commerce.PL.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.PL
{
    public partial class Login : Form
    {
        private readonly IAuthService _authService;

        public Login(IAuthService authService)
        {
            InitializeComponent();
           _authService = authService;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Form1).OpenChildForm(new Register(_authService));
           

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            var username = guna2TextBoxUsernae.Text;
            var password = guna2TextBoxPassword.Text;
            var login = new LoginDto()
            {
                Username = username,
              
                Password = password,

            };
            await _authService.Login(login);
            this.Hide();
            EcommerceForm ecommerceForm
                = new EcommerceForm();
            ecommerceForm.ShowDialog();
        }
    }
}
