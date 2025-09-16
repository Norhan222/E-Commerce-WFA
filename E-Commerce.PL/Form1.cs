using Autofac;
using E_Commerce.Application.Interfaces;
using E_Commerce.PL.User;
using Guna.UI2.WinForms;

namespace E_Commerce.PL
{
    public partial class Form1 : Form
    {
        private readonly IComponentContext _context;
        private readonly IAuthService _authService;
        private readonly ICategoryservice _categoryservice;
        private readonly IproductService _productService;
        private Form currentChildForm;

        public Form1(IComponentContext context,IAuthService authService , ICategoryservice categoryservice,IproductService productService)
        {
            InitializeComponent();
            _context = context;
            _authService = authService;
           _categoryservice = categoryservice;
            _productService = productService;
            OpenChildForm(_context.Resolve<Login>());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
       
        }


        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
           childForm.FormBorderStyle = FormBorderStyle.None;
           childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
