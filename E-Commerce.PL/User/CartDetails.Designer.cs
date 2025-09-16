namespace E_Commerce.PL.User
{
    partial class CartDetails
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flowPanelCarts = new FlowLayoutPanel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            TotalPrice = new Label();
            SuspendLayout();
            // 
            // flowPanelCarts
            // 
            flowPanelCarts.AutoScroll = true;
            flowPanelCarts.Location = new Point(4, 1);
            flowPanelCarts.Name = "flowPanelCarts";
            flowPanelCarts.Size = new Size(628, 381);
            flowPanelCarts.TabIndex = 0;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 5;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(0, 192, 0);
            guna2Button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(478, 388);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(141, 50);
            guna2Button1.TabIndex = 0;
            guna2Button1.Text = "Order Now";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 396);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 1;
            label1.Text = "Total:";
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSize = true;
            TotalPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPrice.Location = new Point(164, 396);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Size = new Size(59, 28);
            TotalPrice.TabIndex = 2;
            TotalPrice.Text = "Total";
            TotalPrice.Click += TotalPrice_Click;
            // 
            // CartDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 450);
            Controls.Add(TotalPrice);
            Controls.Add(label1);
            Controls.Add(guna2Button1);
            Controls.Add(flowPanelCarts);
            Name = "CartDetails";
            Text = "CartItem";
            Load += CartDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowPanelCarts;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label1;
        private Label TotalPrice;
    }
}