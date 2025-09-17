namespace E_Commerce.PL.Admin.ChildForm.Order
{
    partial class OrderMangment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGridView = new DataGridView();
            btnupdateSataus = new Button();
            guna2ComboBoxStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.White;
            dataGridView.Location = new Point(26, 90);
            dataGridView.Margin = new Padding(8);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dataGridView.RowTemplate.Height = 45;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(768, 380);
            dataGridView.TabIndex = 7;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // btnupdateSataus
            // 
            btnupdateSataus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnupdateSataus.BackColor = Color.OrangeRed;
            btnupdateSataus.Cursor = Cursors.Hand;
            btnupdateSataus.Font = new Font("Microsoft Sans Serif", 10F);
            btnupdateSataus.ForeColor = Color.White;
            btnupdateSataus.Location = new Point(816, 333);
            btnupdateSataus.Name = "btnupdateSataus";
            btnupdateSataus.Padding = new Padding(2);
            btnupdateSataus.Size = new Size(252, 42);
            btnupdateSataus.TabIndex = 3;
            btnupdateSataus.Text = "Update Status";
            btnupdateSataus.UseVisualStyleBackColor = false;
            btnupdateSataus.Click += btnupdateSataus_Click;
            // 
            // guna2ComboBoxStatus
            // 
            guna2ComboBoxStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ComboBoxStatus.BackColor = Color.Transparent;
            guna2ComboBoxStatus.BorderColor = Color.FromArgb(255, 192, 192);
            guna2ComboBoxStatus.BorderRadius = 15;
            guna2ComboBoxStatus.CustomizableEdges = customizableEdges1;
            guna2ComboBoxStatus.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBoxStatus.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBoxStatus.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBoxStatus.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2ComboBoxStatus.ForeColor = Color.FromArgb(64, 64, 64);
            guna2ComboBoxStatus.ItemHeight = 30;
            guna2ComboBoxStatus.Location = new Point(818, 90);
            guna2ComboBoxStatus.Name = "guna2ComboBoxStatus";
            guna2ComboBoxStatus.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ComboBoxStatus.Size = new Size(239, 36);
            guna2ComboBoxStatus.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(35, 31);
            label1.Name = "label1";
            label1.Size = new Size(209, 29);
            label1.TabIndex = 9;
            label1.Text = "Order Mangment";
            // 
            // OrderMangment
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1080, 504);
            Controls.Add(label1);
            Controls.Add(guna2ComboBoxStatus);
            Controls.Add(btnupdateSataus);
            Controls.Add(dataGridView);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "OrderMangment";
            Text = "Order Mangment";
            Load += OrderMangment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button btnupdateSataus;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxStatus;
        private Label label1;
    }
}