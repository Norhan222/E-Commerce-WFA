using E_Commerce.Application.Dtos;
using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Interfaces
{
    public interface ICategoryservice
    {
        public IEnumerable<CategoryDto> GetAllcategoryies(); //CategoryDTO

        public void createcategory(CategoryDto cat); //CreatecategoryDTOS

        public void deletecategory(CategoryDto cat);

        public void updatecategory(CategoryDto cat);

        public CategoryDto getcategory(int id);

        public int save();


    }
}
