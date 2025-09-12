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
        public Item()
        {
            InitializeComponent();
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
            get =>decimal.Parse(label1.Text.Replace("$",""));
            set => label1.Text = $"${value}";
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image ProductIamge 
        { get => ProductImage.Image;

          set =>ProductImage.Image=value; 
        }
        private void Item_Load(object sender, EventArgs e)
        {

        }
    }
}
