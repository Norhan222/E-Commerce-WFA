using E_Commerce.Application.Dtos;
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
        public IEnumerable<ProductDto> GetAllProducts  ();

        public void CreateProduct(ProductDto productdto);

        public void DeleteProduct(ProductDto productdto);

        public void UpdateProduct(ProductDto productdto);

        public int Save();

    }
}
