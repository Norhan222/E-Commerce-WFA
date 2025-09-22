using Autofac;
using E_Commerce.Application.Interfaces;
using E_Commerce.Application.Services;
using E_Commerce.Infrastrucrure.Data;
using E_Commerce.Infrastrucrure.Repositories;
using E_Commerce.PL.Admin;
using E_Commerce.PL.Admin.ChildForm;
using E_Commerce.PL.Admin.ChildForm.Order;
using E_Commerce.PL.Admin.ChildForm.Product;
using E_Commerce.PL.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Windows;
using System.Windows.Forms;

namespace E_Commerce.PL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var containerBuilder = new ContainerBuilder();
            containerBuilder.Register(ctx =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
              string connection=  ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;  
                optionsBuilder.UseSqlServer(connection);

                var context = new AppDbContext(optionsBuilder.Options);

                DbSeeder.Seed(context);

                return context;


            }).As<AppDbContext>()
            .InstancePerDependency();

            containerBuilder.RegisterType<UserRepo>().As<IUserRepo>().SingleInstance();
            containerBuilder.RegisterType<AuthService>().As<IAuthService>().SingleInstance();
            containerBuilder.RegisterType<CategoryService>().As<ICategoryservice>().SingleInstance();
            containerBuilder.RegisterType<CategoryRepo>().As<ICategoryRepo>().SingleInstance();
            containerBuilder.RegisterType<ProductRepo>().As<IProductRepo>().SingleInstance();
            containerBuilder.RegisterType<ProductService>().As<IproductService>().SingleInstance();

            containerBuilder.RegisterType<CartRepo>().As<ICartRepo>().SingleInstance();
            containerBuilder.RegisterType<CartService>().As<ICartService>().SingleInstance();
            containerBuilder.RegisterType<OrderRepo>().As<IOrderRepo>().SingleInstance();
            containerBuilder.RegisterType<OrderService>().As<IOrderService>().SingleInstance();

            containerBuilder.RegisterType<Register>();
            containerBuilder.RegisterType<Login>();
            containerBuilder.RegisterType<UpdateProduct>();
            containerBuilder.RegisterType<ProductDetails>();
            containerBuilder.RegisterType<Item>();
            containerBuilder.RegisterType<EcommerceForm>();
            containerBuilder.RegisterType<CartDetails>();
            containerBuilder.RegisterType<CartItem>();
            containerBuilder.RegisterType<FormCategory>();
            containerBuilder.RegisterType<AllProductForm>();
            containerBuilder.RegisterType<Dashbord>();
            containerBuilder.RegisterType<AddProduct>();
            containerBuilder.RegisterType<FormAddCategory>();
            containerBuilder.RegisterType<OrderMangment>();
            containerBuilder.RegisterType<HomePage>();
            containerBuilder.RegisterType<CheckoutForm>();
            containerBuilder.RegisterType<OrderForm>();

            containerBuilder.RegisterType<OrderDetailsForm>();

            var container = containerBuilder.Build();
    
            System.Windows.Forms.Application.Run(container.Resolve<HomePage>());
        }
    }
}