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
        public List<Category> GetAllcategoryies(int pagenumber = 1, int pagesize = 3); //CategoryDTO

        public void createcategory(Category cat); //CreatecategoryDTOS

        public void deletecategory(Category cat);

        public void updatecategory(Category cat);

        public int save();


    }
}
