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
    public class ProductService : IproductService
    {
        private readonly IProductRepo _ProductRepo;

        public ProductService(IProductRepo ProductRepo)
        {
            _ProductRepo = ProductRepo;
        }

        public void CreateProduct(CreateProductDto product)
        {
            var prodmapped = product.Adapt<Product>();
            _ProductRepo.Create(prodmapped);
            
        }

        public void DeleteProduct(ProductDto product)
        {
            var prodmapped = product.Adapt<Product>();

            _ProductRepo.Delete(prodmapped);
        }

        public IEnumerable<ProductDto> GetAllProducts()
        {
           var AllProduct = _ProductRepo.GetAllProducts();
            //var AllProduct = AllProductQuery.Where(c => c.Category != null )
            // .Skip((pagenumber - 1) * pagesize).Take(pagesize).ToList();
            ////.Adapt<List<ProductDTO>>();
            var AllProductMapped = AllProduct.Adapt<IEnumerable<ProductDto>>();
            return AllProductMapped;

        }

        public int Save()
        {
           return _ProductRepo.Save();
            
        }

        public void UpdateProduct(ProductDto product)
        {
            var prodmapped = product.Adapt<Product>();
            _ProductRepo.Update(prodmapped);
        }
    }
}
