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

        public ProductDto GetProductById (int id);
        public void CreateProduct(CreateProductDto productdto);

        public void DeleteProduct(ProductDto productdto);

        public void UpdateProduct(UpdateProductDto productdto);

        public IEnumerable<ProductDto> SearchProducts(string name);

        public IEnumerable<ProductDto> GetProductsWithCategory(string categoryname);

        public int Save();

    }
}
