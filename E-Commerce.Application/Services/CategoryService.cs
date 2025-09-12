using E_Commerce.Application.Interfaces;
using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Services
{
    public class CategoryService : ICategoryservice
    {
        IGenericRepo<Category, int> _CategoryRepo;

        public CategoryService(IGenericRepo<Category, int> categoryRepo)//Dependency Injection
        {
            _CategoryRepo = categoryRepo;
        }

        public void createcategory(Category cat)
        {
            //Category newcat = Category.Adapt<category>();
            _CategoryRepo.createcategory(cat);

        }

        public void deletecategory(Category cat)
        {
            _CategoryRepo.delete(cat);
        }

        public List<Category> GetAllcategoryies(int pagenumber = 1, int pagesize = 3)
        {
            IQueryable<Category> allcatquery = _CategoryRepo.GetAll();
            var allcategories = allcatquery.Where(c => c.Products.Count > 0)
                .Skip((pagenumber - 1) * pagesize).Take(pagesize).ToList();
            //.Adapt<List<CategoryDTO>>();

            return allcategories;

        }

        public int save()
        {
            return _CategoryRepo.save();
        }

        public void updatecategory(Category cat)
        {
            _CategoryRepo.update(cat);
        }
    }
}
