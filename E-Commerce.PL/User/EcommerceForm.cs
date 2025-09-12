using E_Commerce.Core.Entites;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.PL.User
{
    public partial class EcommerceForm : Form
    {
        public EcommerceForm()
        {
            InitializeComponent();
            // CreateFilterPanel();
            string[] categories =
           {
            "Aventura", "Dallas", "Daly City", "Deerfield Beach",
            "Hayward", "Highland Village", "Irving",
            "Manhattan", "Montgomery", "San Jose"
        };

            // Add Guna2CheckBoxes
            foreach (var cat in categories)
            {
                var chk = new Guna2CheckBox
                {
                    Text = cat,
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
                MessageBox.Show("Selected: " + string.Join(", ", selected));
            };
        }
        

    List<Product> Products = new List<Product>()
        {
        new Product()
        {
            Name = "Product 2",
            Price = 200,
            ImageUrl = "https://via.placeholder.com/150",
            },
            new Product()
        {
            Name = "Product 3",
            Price = 300,
            ImageUrl = "https://via.placeholder.com/150",
            },
            new Product()
        {
            Name = "Product 4",
            Price = 400,
            ImageUrl = "https://via.placeholder.com/150",
            },
            new Product()
        {
            Name = "Product 5",
            Price = 500,
            ImageUrl = "https://via.placeholder.com/150",
            },
         new Product()
        {
            Name = "Product 5",
            Price = 500,
            ImageUrl = "https://via.placeholder.com/150",
            }, new Product()
        {
            Name = "Product 5",
            Price = 500,
            ImageUrl = "https://via.placeholder.com/150",
            }, new Product()
        {
            Name = "Product 5",
            Price = 500,
            ImageUrl = "https://via.placeholder.com/150",
            }, new Product()
        {
            Name = "Product 5",
            Price = 500,
            ImageUrl = "https://via.placeholder.com/150",
            }, new Product()
        {
            Name = "Product 5",
            Price = 500,
            ImageUrl = "https://via.placeholder.com/150",
            }, new Product()
        {
            Name = "Product 5",
            Price = 500,
            ImageUrl = "https://via.placeholder.com/150",
            }, new Product()
        {
            Name = "Product 5",
            Price = 500,
            ImageUrl = "https://via.placeholder.com/150",
            }, new Product()
        {
            Name = "Product 5",
            Price = 500,
            ImageUrl = "https://via.placeholder.com/150",
            }, new Product()
        {
            Name = "Product 5",
            Price = 500,
            ImageUrl = "https://via.placeholder.com/150",
            }, new Product()
        {
            Name = "Product 5",
            Price = 500,
            ImageUrl = "https://via.placeholder.com/150",
            }, new Product()
        {
            Name = "Product 5",
            Price = 500,
            ImageUrl = "https://via.placeholder.com/150",
            }, new Product()
        {
            Name = "Product 5",
            Price = 500,
            ImageUrl = "https://via.placeholder.com/150",
            }, new Product()
        {
            Name = "Product 5",
            Price = 500,
            ImageUrl = "https://via.placeholder.com/150",
            },
        };

        private void EcommerceForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Products)
            {
                Item card = new Item();
                card.ProductName = item.Name;
                card.ProductPrice = item.Price;
                card.ProductIamge = Properties.Resources.tsgirt;
                flowLayoutitmes.Controls.Add(card);
            }
        }



        private void CreateFilterPanel()
        {
            // Panel
            var panelFilter = new Guna2Panel
            {
                Size = new Size(250, 586),
                BorderThickness = 1,
                BorderColor = Color.LightGray,
                BackColor = Color.White,
                AutoScroll = true
            };
            // panel2.Controls.Add(panelFilter);

            // LinkLabels
            var linkSelectAll = new LinkLabel { Text = "Select all", Location = new Point(10, 10) };
            var linkClear = new LinkLabel { Text = "Clear", Location = new Point(100, 10) };
            panelFilter.Controls.Add(linkSelectAll);
            panelFilter.Controls.Add(linkClear);

            // FlowLayoutPanel for checkboxes
            var flow = new FlowLayoutPanel
            {
                Location = new Point(10, 40),
                Size = new Size(220, 220),
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };
            panelFilter.Controls.Add(flow);

            // Categories
            string[] categories =
            {
            "Aventura", "Dallas", "Daly City", "Deerfield Beach",
            "Hayward", "Highland Village", "Irving",
            "Manhattan", "Montgomery", "San Jose"
        };

            // Add Guna2CheckBoxes
            foreach (var cat in categories)
            {
                var chk = new Guna2CheckBox
                {
                    Text = cat,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10),
                    CheckedState = { FillColor = Color.DodgerBlue },
                    UncheckedState = { FillColor = Color.LightGray }
                };
                flow.Controls.Add(chk);
            }

            // Buttons
            var btnCancel = new Guna2Button
            {
                Text = "Cancel",
                Location = new Point(10, 280),
                Size = new Size(100, 35),
                FillColor = Color.White,
                ForeColor = Color.Black,
                BorderColor = Color.Gray,
                BorderThickness = 1
            };
            var btnApply = new Guna2Button
            {
                Text = "Apply",
                Location = new Point(130, 280),
                Size = new Size(100, 35),
                FillColor = Color.DodgerBlue,
                ForeColor = Color.White
            };

            panelFilter.Controls.Add(btnCancel);
            panelFilter.Controls.Add(btnApply);

            // Events
            linkSelectAll.Click += (s, e) =>
            {
                foreach (Guna2CheckBox chk in flow.Controls)
                    chk.Checked = true;
            };

            linkClear.Click += (s, e) =>
            {
                foreach (Guna2CheckBox chk in flow.Controls)
                    chk.Checked = false;
            };

            btnApply.Click += (s, e) =>
            {
                var selected = flow.Controls.OfType<Guna2CheckBox>()
                                .Where(c => c.Checked)
                                .Select(c => c.Text);
                MessageBox.Show("Selected: " + string.Join(", ", selected));
            };
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            ContextMenuStrip usertMenu=new ContextMenuStrip();
            usertMenu.Items.Add("Logout");
            usertMenu.Items.Add("Cart");
            iconPictureBox2.Click += (s, e) => {
                usertMenu.Show(iconPictureBox2, new Point(-100, iconPictureBox2.Height));
                };
        }
    }
}
