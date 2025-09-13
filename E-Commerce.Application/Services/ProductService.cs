using E_Commerce.Application.Interfaces;
using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Services
{
    public class ProductService : IproductService
    {
        IGenericRepo<Product, int> _ProductRepo;

        public ProductService(IGenericRepo<Product, int> ProductRepo)
        {
            _ProductRepo = ProductRepo;
        }

        public void CreateProduct(Product product)
        {
            _ProductRepo.CreateRepo(product);
            
        }

        public void DeleteProduct(Product product)
        {
            _ProductRepo.DeleteRepo(product);   
        }

        public List<Product> GetAllProducts(int pagenumber = 1, int pagesize = 10)
        {
            IQueryable<Product> AllProductQuery = _ProductRepo.GetAll();
            var AllProduct = AllProductQuery.Where(c => c.Category != null )
             .Skip((pagenumber - 1) * pagesize).Take(pagesize).ToList();
            //.Adapt<List<ProductDTO>>();

            return AllProduct;

        }

        public int Save()
        {
           return _ProductRepo.SaveRepo();
            
        }

        public void UpdateProduct(Product product)
        {
            _ProductRepo.UpdateRepo(product);
        }
    }
}
