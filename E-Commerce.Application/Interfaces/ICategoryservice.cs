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

        public void Createcategory(Category cat); //CreatecategoryDTOS

        public void Deletecategory(Category cat);

        public void Updatecategory(Category cat);

        public int Save();


    }
}
