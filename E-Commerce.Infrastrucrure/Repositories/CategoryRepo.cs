using E_Commerce.Application.Interfaces;
using E_Commerce.Core.Entites;
using E_Commerce.Infrastrucrure.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastrucrure.Repositories
{
    public class CategoryRepo : GenericRepository<Category, int>,ICategoryRepo
    { 
        public CategoryRepo(AppDbContext dbContext):base(dbContext) { }

    }
}
