using E_Commerce.Application.Interfaces;
using E_Commerce.Core.Entites;
using E_Commerce.Infrastrucrure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastrucrure.Repositories
{
    public class ProductRepo : GenericRepository<Product,int>, IProductRepo
    {
        private readonly AppDbContext _dbContext;

        public ProductRepo(AppDbContext dbContext):base(dbContext)
        {
           _dbContext = dbContext;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _dbContext.Products.Include(p => p.Category);
        }
    }
}
