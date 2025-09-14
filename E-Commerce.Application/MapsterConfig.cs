using E_Commerce.Application.Dtos;
using E_Commerce.Core.Entites;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application
{
    public  class MapsterConfig
    {
        public static void RegisterMapsterconfiguration ()
        {
            TypeAdapterConfig<Product, ProductDto>.NewConfig()
                .Map(dest => dest.CategoryName, src => src.Category.Name);


            //TypeAdapterConfig<Product, CreateProductDto>.NewConfig()
            //    .Map(dest => dest.ProdName, src => src.Name)
            //    .Map(dest => dest.ProdUnitPrice, src => src.Price)
            //    .Map(dest => dest.ProdDescription, src => src.Description).TwoWays();

            //TypeAdapterConfig<Category, CategoryDto>.NewConfig()
            //    .Map(dest => dest.CatId, src => src.Id)
            //    .Map(dest => dest.CatName, src => src.Name)
            //    .Map(dest => dest.CatDescription, src => src.Description).TwoWays();

            TypeAdapterConfig<Category, CreateCategoryDto>.NewConfig()
                .Map(dest => dest.CatName, src => src.Name)
                .Map(dest => dest.CatDescription, src => src.Description);

            TypeAdapterConfig<OrderItem, OrderItemDto>.NewConfig();
            TypeAdapterConfig<OrderItem, CreateOrderItemDto>.NewConfig();
            TypeAdapterConfig<Order, OrderDto>.NewConfig();
            TypeAdapterConfig<Order, CreateOrderDto>.NewConfig();
            TypeAdapterConfig<Cart, CartDto>.NewConfig();
            TypeAdapterConfig<CartItem, CartItemDto>.NewConfig();
            TypeAdapterConfig<User, UserDto>.NewConfig();
        }

    }
}
