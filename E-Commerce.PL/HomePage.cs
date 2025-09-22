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
    using Autofac;
    using E_Commerce.PL.User;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class HomePage : Form
    {
        private readonly IComponentContext _context;
        public HomePage(IComponentContext context)
        {
            InitializeComponent();
            this.Text = "Welcome";
            _context = context;
            this.WindowState = FormWindowState.Maximized;
        }



        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var register = _context.Resolve<Register>();
            register.Show();

        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.FromArgb(200, Color.OrangeRed);
            guna2Button2.FillColor = Color.FromArgb(200, Color.OrangeRed);

        }


        private void guna2Button1_MouseHover(object sender, EventArgs e)
        {

            guna2Button1.FillColor = Color.FromArgb(150, Color.White);


            guna2Button2.FillColor = Color.FromArgb(200, Color.OrangeRed);


        }

        private void guna2Button2_MouseHover(object sender, EventArgs e)
        {

            guna2Button2.FillColor = Color.FromArgb(150, Color.White);


            guna2Button1.FillColor = Color.FromArgb(200, Color.OrangeRed);



        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            var login = _context.Resolve<Login>();
            login.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var customer = _context.Resolve<EcommerceForm>();
            customer.Show();
        }
    }
}
