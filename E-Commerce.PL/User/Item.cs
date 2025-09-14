using E_Commerce.Application.Interfaces;
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
    public partial class Item : UserControl
    {
        private readonly IproductService _productService;
        Label lblid;
        public Item(IproductService productService)
        {
            InitializeComponent();
            lblid = new Label();
           _productService = productService;
        }
        [Browsable(true)]
       
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int ProductId
        {
            get =>Convert.ToInt32(lblid.Text);
            set => lblid.Text =value.ToString();
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ProductName
        {
            get => lblProductname.Text;
            set => lblProductname.Text = value;
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public decimal ProductPrice
        {
            get => decimal.Parse(label1.Text.Replace("$", ""));
            set => label1.Text = $"${value}";
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image ProductIamge
        {
            get => ProductImage.Image;

            set => ProductImage.Image = value;
        }
        private void Item_Load(object sender, EventArgs e)
        {

        }

        private void ProductImage_Click(object sender, EventArgs e)
        {
            ProductDetails productDetails = new ProductDetails(ProductId,_productService);
            productDetails.ShowDialog();
        }
    }
}
