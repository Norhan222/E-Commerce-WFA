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
            return _dbContext.Products.Include(p => p.Category).AsNoTracking();
        }

        public Product GetProduct(int id)
        {
            return _dbContext.Products.AsNoTracking().Include(p => p.Category).FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProductsWithCategoryName(string categoryName)
        {
            return _dbContext.Products.Where(p=>p.Category.Name== categoryName).AsNoTracking();
        }

        public IEnumerable<Product> SearchByName(string name)
        {
            return _dbContext.Products.Include(p=>p.Category)
                .Where(p=>p.Name.Contains(name)).AsNoTracking().ToList();
        }
    }
}
