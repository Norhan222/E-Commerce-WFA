using E_Commerce.Application.Dtos;
using E_Commerce.Application.Interfaces;
using E_Commerce.Core.Entites;
using E_Commerce.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Services
{
    public class OrderService : IOrderService
    {
        IOrderRepo _OrderRepo;
        ICartRepo _CartRepo;


        public OrderService(IOrderRepo orderRepo, ICartRepo cartRepo)
        {
            _OrderRepo = orderRepo;
            _CartRepo = cartRepo;
        }

        public Order CreateOrderFromCart(int useerId)
        {
            var cart = _CartRepo.GetCartByUserId(useerId);
             if (cart == null || !cart.CartItems.Any())
                throw new InvalidOperationException("Cart is empty!");

            var order = new Order()
            {
                UserId = useerId,
                OrderDate = DateTime.Now,
                Status = OrderStatus.Processing,
                OrderItems = cart.CartItems.Select(ci=>new OrderItem
                {
                    ProductId = ci.ProductId,
                    Quantity = ci.Quantity,
                    Price = ci.Product.Price
                  
                })
               .ToList()
            };
            throw new InvalidOperationException("Cart is empty!");

        }

        public void PlaceOrder(OrderDto orderDto)
        {
            orderDto.OrderDate = DateTime.Now;
            orderDto.Status = OrderStatus.Processing;
            orderDto.TotalAmount = orderDto.OrderItems.Sum(i => i.TotalPrice);
            var order = new Order()
            {
                UserId= orderDto.UserId,
                OrderDate = orderDto.OrderDate,
                Status = orderDto.Status,
                TotalAmount = orderDto.TotalAmount,
            };
            order.OrderItems = orderDto.OrderItems.Select(o => new OrderItem
            {
                ProductId=o.ProductId,
                Quantity = o.Quantity,
                Price=o.UnitPrice,

            }).ToList();
            _OrderRepo.Add(order);
        }


        public IEnumerable<Order> GetOrders() => _OrderRepo.GetAll();

        public Order GetOrder(int id) => _OrderRepo.GetById(id);

        public void Save()
        {
            _CartRepo.Save();
        }

        public IEnumerable<OrderDto> GetOrdersForUser(int userid)
        {
          var orders= _OrderRepo.GetOrdersByUserId(userid);
            var orderDto = orders.Select(o => new OrderDto()
            {
                Id = o.Id,
                UserId = o.UserId,
                OrderDate = o.OrderDate,
                Status = o.Status,
                TotalAmount = o.TotalAmount,

                OrderItems = o.OrderItems.Select(o => new OrderItemDto
                {
                    ProductId = o.ProductId,
                    Quantity = o.Quantity,
                    UnitPrice = o.Product.Price,
                    TotalPrice=o.Quantity*o.Price,

                }).ToList()
            });
            return orderDto;

        }
    }


}
