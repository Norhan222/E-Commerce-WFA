using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Core.Entites;

namespace E_Commerce.Infrastrucrure.Data
{
    internal class AppDbContextFactory: IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=.; Database=EcommerceDb; Trusted_Connection=true;  TrustServerCertificate=True; MultipleActiveResultSets=True;" );
          //  optionsBuilder.UseSqlServer("Data Source=DESKTOP-SVASVG3\\SQLEXPRESS ; Initial Catalog = MyecommerceProject ; Integrated Security = true; Encrypt = false");

            return new AppDbContext(optionsBuilder.Options);
        }
  

    }
}
