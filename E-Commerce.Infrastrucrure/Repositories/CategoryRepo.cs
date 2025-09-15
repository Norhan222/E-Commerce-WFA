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
    public class CategoryRepo : GenericRepository<Category, int>,ICategoryRepo
    {
        AppDbContext _context;

        public CategoryRepo(AppDbContext dbContext):base(dbContext)
        {
            _context = dbContext;
        }

        public Category GetCategoryWithProductsByName(string name)
        {
            return _context.Categories
                .Include(c => c.Products)
                .FirstOrDefault(c => c.Name.Contains(name));
        }

    }
}
