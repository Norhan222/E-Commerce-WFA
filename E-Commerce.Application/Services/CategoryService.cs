using E_Commerce.Application.Dtos;
using E_Commerce.Application.Interfaces;
using E_Commerce.Core.Entites;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Services
{
    public class CategoryService : ICategoryservice
    {
        private readonly ICategoryRepo _categoryRepo;

        public CategoryService(ICategoryRepo  categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

<<<<<<< HEAD
        public void createcategory(CategoryDto cat)
        {
            var catmapped = cat.Adapt<Category>();
            _categoryRepo.Create(catmapped);

        }

        public void deletecategory(CategoryDto cat)
        {
           // _categoryRepo.Delete(cat);
=======
        public void Createcategory(Category cat)
        {
            //Category newcat = Category.Adapt<category>();
            _CategoryRepo.CreateRepo(cat);

        }

        public void Deletecategory(Category cat)
        {
            _CategoryRepo.DeleteRepo(cat);
>>>>>>> fedcc878f2a5a737932d817d8d78a2909cf62096
        }

        public IEnumerable<CategoryDto> GetAllcategoryies()
        {
            //IQueryable<Category> allcatquery = _categoryRepo.GetAll();
            //var allcategories = allcatquery.Where(c => c.Products.Count > 0)
            //    .Skip((pagenumber - 1) * pagesize).Take(pagesize).ToList();
            ////.Adapt<List<CategoryDTO>>();
            ///
            var allcategories = _categoryRepo.GetAll();
            var Allcategorymapped=allcategories.Adapt<IEnumerable<CategoryDto>>();
            return Allcategorymapped;

        }

        public CategoryDto getcategory(int id)
        {
          var category= _categoryRepo.GetById(id);
          return category.Adapt<CategoryDto>();
        }

        public int Save()
        {
<<<<<<< HEAD
            return _categoryRepo.Save();
        }

        public void updatecategory(CategoryDto cat)
        {
            var mappedcat= cat.Adapt<Category>();
            _categoryRepo.Update(mappedcat);
=======
            return _CategoryRepo.SaveRepo();
        }

        public void Updatecategory(Category cat)
        {
            _CategoryRepo.UpdateRepo(cat);
>>>>>>> fedcc878f2a5a737932d817d8d78a2909cf62096
        }
    }
}
