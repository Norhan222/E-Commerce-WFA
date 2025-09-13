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
    public partial class Register : Form
    {
        private readonly IAuthService _authService;

        public Register(IAuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(_authService);
            login.ShowDialog();
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
            await _authService.Register(Register);
            this.Hide();
            EcommerceForm ecommerceForm
                = new EcommerceForm();
            ecommerceForm.ShowDialog();
        }

        private void guna2TextBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
