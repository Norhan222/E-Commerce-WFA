using Autofac;
using E_Commerce.Application.Interfaces;
using E_Commerce.Application.Services;
using E_Commerce.Infrastrucrure.Data;
using E_Commerce.Infrastrucrure.Repositories;
using E_Commerce.PL.Admin;
using E_Commerce.PL.Admin.ChildForm;
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
            var containerBuilder=new ContainerBuilder();
            containerBuilder.Register(ctx =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                optionsBuilder.UseSqlServer("Server=.; Database=EcommerceDb; Trusted_Connection=true;  TrustServerCertificate=True; MultipleActiveResultSets=True;");
                return new AppDbContext(optionsBuilder.Options);
            }).As<AppDbContext>()
            .InstancePerDependency();

            containerBuilder.RegisterType<UserRepo>().As<IUserRepo>().SingleInstance();
            containerBuilder.RegisterType<AuthService>().As<IAuthService>().SingleInstance();
            containerBuilder.RegisterType<CategoryService>().As<ICategoryservice>().SingleInstance();
            containerBuilder.RegisterType<CategoryRepo>().As<ICategoryRepo>().SingleInstance();
            containerBuilder.RegisterType<ProductRepo>().As<IProductRepo>().SingleInstance();
            containerBuilder.RegisterType<ProductService>().As<IproductService>().SingleInstance();


            containerBuilder.RegisterType<Register>();
            containerBuilder.RegisterType<Login>();
            containerBuilder.RegisterType<Form1>();
            containerBuilder.RegisterType<UpdateProduct>();




            var container =containerBuilder.Build();
            using (var scope = container.BeginLifetimeScope())
            {
                var form = scope.Resolve<Form1>();
                System.Windows.Forms.Application.Run(form);
            }
        }
    }
}