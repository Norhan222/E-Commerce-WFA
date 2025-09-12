using Autofac;
using E_Commerce.Infrastrucrure.Data;
using E_Commerce.PL.Admin;
using E_Commerce.PL.Admin.ChildForm;
using E_Commerce.PL.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;

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


            var builder = new ContainerBuilder();
            builder.Register(c =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
                return new AppDbContext(optionsBuilder.Options);
            }).As<AppDbContext>().InstancePerLifetimeScope();
            builder.Build();

            Application.Run(new Dashbord());
        }
    }
}