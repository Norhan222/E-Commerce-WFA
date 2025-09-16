namespace E_Commerce.PL.User
{
    partial class Item
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
            lblProductname = new Label();
            ProductImage = new PictureBox();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)ProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblProductname
            // 
            lblProductname.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblProductname.AutoSize = true;
            lblProductname.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductname.ForeColor = Color.DimGray;
            lblProductname.Location = new Point(19, 200);
            lblProductname.Name = "lblProductname";
            lblProductname.Size = new Size(127, 25);
            lblProductname.TabIndex = 1;
            lblProductname.Text = "ProductName";
            // 
            // ProductImage
            // 
            ProductImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ProductImage.Cursor = Cursors.Hand;
            ProductImage.Image = Properties.Resources._543_5436355_plain_green_t_shirt_png_download_image_blank;
            ProductImage.Location = new Point(67, 16);
            ProductImage.Name = "ProductImage";
            ProductImage.Size = new Size(154, 166);
            ProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            ProductImage.TabIndex = 2;
            ProductImage.TabStop = false;
            ProductImage.Click += ProductImage_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(240, 197);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 3;
            label1.Text = "$17.99";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = Color.Gray;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            iconPictureBox1.IconColor = Color.Gray;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 48;
            iconPictureBox1.Location = new Point(254, 13);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(48, 48);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(iconPictureBox1);
            Controls.Add(label1);
            Controls.Add(ProductImage);
            Controls.Add(lblProductname);
            Name = "Item";
            Size = new Size(312, 247);
            Load += Item_Load;
            ((System.ComponentModel.ISupportInitialize)ProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProductname;
        private PictureBox ProductImage;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
