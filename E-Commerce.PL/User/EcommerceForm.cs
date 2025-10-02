using Autofac;
using E_Commerce.Application;
using E_Commerce.Application.Interfaces;
using E_Commerce.Core.Entites;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.PL.User
{
    public partial class EcommerceForm : Form
    {
        private readonly IComponentContext _context;
        private readonly ICategoryservice _categoryservice;
        private readonly IproductService _productService;

        public EcommerceForm(IComponentContext context, ICategoryservice categoryservice, IproductService productService)
        {
            InitializeComponent();
           
             this.WindowState = FormWindowState.Maximized;

            _context = context;
            _categoryservice = categoryservice;
            _productService = productService;

            if (SessionManger.currentUser.Id == 0)
            {
                lblUsername.Text = "Login";
                iconPictureBox1.Visible = false;


            }
            else
            {
                lblUsername.Text = SessionManger.currentUser.Username;
                iconPictureBox1.Visible = true;
            }



            // Add Guna2CheckBoxes
            foreach (var cat in _categoryservice.GetAllcategoryies())
            {
                var chk = new Guna2CheckBox
                {
                    Text = cat.Name,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10),
                    CheckedState = { FillColor = Color.DodgerBlue },
                    UncheckedState = { FillColor = Color.LightGray }

                };
                flowLayoutFilter.Controls.Add(chk);
            }
            linkSelectAll.Click += (s, e) =>
             {
                 foreach (Guna2CheckBox chk in flowLayoutFilter.Controls)
                     chk.Checked = true;
             };
            linkClear.Click += (s, e) =>
            {
                foreach (Guna2CheckBox chk in flowLayoutFilter.Controls)
                    chk.Checked = false;
            };
            guna2BtnApply.Click += (s, e) =>
            {
                var selected = flowLayoutFilter.Controls.OfType<Guna2CheckBox>()
                                .Where(c => c.Checked)
                                .Select(c => c.Text);
                flowLayoutitmes.Controls.Clear();

                foreach (var item in selected)
                {
                  var products=  _productService.GetProductsWithCategory(item);

                    foreach (var product in products)
                    {
                        Item card = _context.Resolve<Item>();   
                        card.ProductId = product.Id;
                        card.ProductName = product.Name;
                        card.ProductPrice = product.Price;
                        var fullpath = Path.Combine(Directory.GetParent(System.Windows.Forms.Application.StartupPath).Parent.Parent.Parent.FullName, product.ImageUrl);
                        if (File.Exists(fullpath))
                        {
                            using (var fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read))
                            {
                                card.ProductIamge = Image.FromStream(fs);
                            }
                        }

                        flowLayoutitmes.Controls.Add(card);
                    }


                }
            };

        }

        private void EcommerceForm_Load(object sender, EventArgs e)
        {

            var products = _productService.GetAllProducts();
            foreach (var item in products)
            {
                Item card = _context.Resolve<Item>();         //new Item(_productService);
                card.ProductId = item.Id;
                card.ProductName = item.Name;
                card.ProductPrice = item.Price;
                var fullpath = Path.Combine(Directory.GetParent(System.Windows.Forms.Application.StartupPath).Parent.Parent.Parent.FullName, item.ImageUrl);
                if (File.Exists(fullpath))
                {
                    using (var fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read))
                    {
                        card.ProductIamge = Image.FromStream(fs);
                    }
                }

                flowLayoutitmes.Controls.Add(card);
            }

        }



      

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            ContextMenuStrip usertMenu = new ContextMenuStrip();

            if (SessionManger.currentUser.Id == 0)
            {
                usertMenu.Items.Add("Register");

            }
            else
            {
                usertMenu.Items.Add("Logout");
                usertMenu.Items.Add("Orders");
            }
            iconPictureBox2.Click += (s, e) =>
            {
                usertMenu.Show(iconPictureBox2, new Point(-100, iconPictureBox2.Height));
            };
            usertMenu.ItemClicked += (s, e) =>
            {
                if (e.ClickedItem is ToolStripMenuItem item)
                {
                    if (item.Text == "Orders")
                    {
                        var orderform = _context.Resolve<OrderForm>();
                        orderform.Show();
                    }
                    else if (item.Text == "Register")
                    {
                        var register = _context.Resolve<Register>();
                        register.Show();
                    }
                    else if (item.Text == "Logout")
                    {
                        SessionManger.currentUser = new UserSession
                        {
                            Id = 0,
                            Username = null,
                            Role = null
                        };
                        var ecoomerec = _context.Resolve<EcommerceForm>();
                        ecoomerec.Show();
                    }
                }
            };

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutitmes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            var searchproducts = _productService.SearchProducts(guna2TextBox1.Text);
            if (searchproducts.Any())
            {
                flowLayoutitmes.Controls.Clear();
                foreach (var item in searchproducts)
                {
                    Item card = _context.Resolve<Item>();
                    card.ProductId = item.Id;
                    card.ProductName = item.Name;
                    card.ProductPrice = item.Price;
                    var fullpath = Path.Combine(Directory.GetParent(System.Windows.Forms.Application.StartupPath).Parent.Parent.Parent.FullName, item.ImageUrl);
                    if (File.Exists(fullpath))
                    {
                        using (var fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read))
                        {
                            card.ProductIamge = Image.FromStream(fs);
                        }
                    }

                    flowLayoutitmes.Controls.Add(card);
                }
            }
        }

        private void guna2BtnApply_Click(object sender, EventArgs e)
        {
            var selected = flowLayoutFilter.Controls.OfType<Guna2CheckBox>()
                .Where(c => c.Checked)
                .Select(c => c.Text);

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            if (SessionManger.currentUser.Id == 0)
            {
                var login = _context.Resolve<Login>();
                login.ShowDialog();
            }
            else
            {
                var CartDetails = _context.Resolve<CartDetails>();
                CartDetails.ShowDialog();
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            if (lblUsername.Text == "Login")
            {
                var login = _context.Resolve<Login>();
                login.ShowDialog();
            }
        }

        //[DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        //private static extern void ReleaseCapture();
        //[DllImport("user32.dll", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        //private void panel1_MouseDown(object sender, MouseEventArgs e)
        //{

        //}

        //private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}
    }
}
