namespace E_Commerce.PL
{
    partial class HomePage
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Bottom;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderColor = Color.OrangeRed;
            guna2Button2.BorderRadius = 30;
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Coral;
            guna2Button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.MistyRose;
            guna2Button2.Location = new Point(457, 183);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(223, 65);
            guna2Button2.TabIndex = 1;
            guna2Button2.Text = "Register";
            guna2Button2.Click += guna2Button2_Click;
            guna2Button2.MouseHover += guna2Button2_MouseHover;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Bottom;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.OrangeRed;
            guna2Button1.BorderRadius = 30;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Coral;
            guna2Button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.MistyRose;
            guna2Button1.Location = new Point(185, 183);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(223, 65);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "Login";
            guna2Button1.Click += guna2Button1_Click_1;
            guna2Button1.MouseHover += guna2Button1_MouseHover;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MistyRose;
            label1.Location = new Point(56, 72);
            label1.Name = "label1";
            label1.Size = new Size(802, 52);
            label1.TabIndex = 3;
            label1.Text = "!Your Shopping Adventure Starts Here";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(391, 271);
            label2.Name = "label2";
            label2.Size = new Size(108, 32);
            label2.TabIndex = 4;
            label2.Text = "Skip -->";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(guna2Button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(guna2Button1);
            panel1.Location = new Point(255, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 338);
            panel1.TabIndex = 5;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1406, 722);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "HomePage";
            Text = "HomePage";
            TransparencyKey = Color.Transparent;
            Load += HomePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}