using E_Commerce.Application.Interfaces;
<<<<<<< HEAD
using E_Commerce.Core.Entites;
using E_Commerce.Infrastrucrure.Data;
=======
>>>>>>> fedcc878f2a5a737932d817d8d78a2909cf62096
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastrucrure.Repositories
{
<<<<<<< HEAD
    public class CategoryRepo : GenericRepository<Category, int>,ICategoryRepo
    { 
        public CategoryRepo(AppDbContext dbContext):base(dbContext) { }
=======
    public class CategoryRepo : ICategoryRepo
    {


>>>>>>> fedcc878f2a5a737932d817d8d78a2909cf62096
    }
}
