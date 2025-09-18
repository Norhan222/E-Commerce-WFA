using Autofac;
using E_Commerce.Application;
using E_Commerce.Application.Dtos;
using E_Commerce.Application.Interfaces;
using E_Commerce.PL.Admin;
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
        private readonly IComponentContext _context;
        private readonly IAuthService _authService;
        private readonly ICategoryservice _categoryservice;
        private readonly IproductService _productService;

        public Login(IComponentContext context, IAuthService authService, ICategoryservice categoryservice, IproductService productService)
        {
            InitializeComponent();
            _context = context;
            _authService = authService;
            _categoryservice = categoryservice;
            _productService = productService;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Form1).OpenChildForm(_context.Resolve<Register>());


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
            var errors = Helper.Validate(login);
            if (errors.Any())
            {
                string message = String.Join("\n", errors.Select(e => e.ErrorMessage));
                MessageBox.Show(message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (await _authService.Login(login))
            {
                if (SessionManger.currentUser.Role == "Admin")
                {
                    (this.ParentForm as Form1).Hide();
                    Dashbord dashbord = _context.Resolve<Dashbord>();
                    dashbord.ShowDialog();

                }
                else {
                    this.Close();
                    var ecommerce = _context.Resolve<EcommerceForm>();
                    ecommerce.ShowDialog();
                        };

            }
            else
            {
                MessageBox.Show("Username  Or Password Is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            var ecommerce=_context.Resolve<EcommerceForm>();
            ecommerce.ShowDialog();
        }

        private void Login_Deactivate(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
