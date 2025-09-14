using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Interfaces
{
    public interface IProductRepo :IGenericRepo<Product,int>
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);

        public IEnumerable<Product> SearchByName(string name);

    }
}
