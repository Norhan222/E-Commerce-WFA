using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Interfaces
{
    public interface IproductService
    {
        public List<Product> GetAllProducts  (int pagenumber = 1, int pagesize = 10); //CategoryDTO

        public void CreateProduct(Product product); //CreatecategoryDTOS

        public void DeleteProduct(Product product);

        public void UpdateProduct(Product product);

        public int Save();

    }
}
