namespace E_Commerce.PL.User
{
    partial class CartItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picProductImage = new PictureBox();
            lblProductName = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            btnMinus = new FontAwesome.Sharp.IconPictureBox();
            btnPlus = new FontAwesome.Sharp.IconPictureBox();
            btnDeleteProduct = new FontAwesome.Sharp.IconPictureBox();
            lblProductPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPlus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDeleteProduct).BeginInit();
            SuspendLayout();
            // 
            // picProductImage
            // 
            picProductImage.Location = new Point(17, 20);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(115, 130);
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 0;
            picProductImage.TabStop = false;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(193, 37);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(137, 28);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "ProductName";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(217, 182);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 28);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.LavenderBlush;
            lblQuantity.Location = new Point(56, 185);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(32, 25);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "23";
            lblQuantity.Click += label3_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.WhiteSmoke;
            btnMinus.ForeColor = Color.FromArgb(64, 64, 64);
            btnMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            btnMinus.IconColor = Color.FromArgb(64, 64, 64);
            btnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinus.IconSize = 33;
            btnMinus.Location = new Point(17, 182);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(33, 33);
            btnMinus.TabIndex = 4;
            btnMinus.TabStop = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.WhiteSmoke;
            btnPlus.ForeColor = Color.FromArgb(64, 64, 64);
            btnPlus.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnPlus.IconColor = Color.FromArgb(64, 64, 64);
            btnPlus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPlus.IconSize = 33;
            btnPlus.Location = new Point(94, 182);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(33, 33);
            btnPlus.TabIndex = 5;
            btnPlus.TabStop = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.WhiteSmoke;
            btnDeleteProduct.ForeColor = Color.Red;
            btnDeleteProduct.IconChar = FontAwesome.Sharp.IconChar.Times;
            btnDeleteProduct.IconColor = Color.Red;
            btnDeleteProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeleteProduct.IconSize = 45;
            btnDeleteProduct.Location = new Point(341, 182);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(46, 45);
            btnDeleteProduct.TabIndex = 6;
            btnDeleteProduct.TabStop = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductPrice.ForeColor = SystemColors.ControlDarkDark;
            lblProductPrice.Location = new Point(202, 77);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(56, 28);
            lblProductPrice.TabIndex = 7;
            lblProductPrice.Text = "Price";
            // 
            // CartItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(lblProductPrice);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(lblProductName);
            Controls.Add(picProductImage);
            Name = "CartItem";
            Size = new Size(596, 235);
            Load += CartItem_Load;
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinus).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPlus).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDeleteProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picProductImage;
        private Label lblProductName;
        private Label lblPrice;
        private Label lblQuantity;
        private FontAwesome.Sharp.IconPictureBox btnMinus;
        private FontAwesome.Sharp.IconPictureBox btnPlus;
        private FontAwesome.Sharp.IconPictureBox btnDeleteProduct;
        private Label lblProductPrice;
    }
}
