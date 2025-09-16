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

        public void PlaceOrder(Order order)
        {
            order.OrderDate = DateTime.Now;
            order.Status = OrderStatus.Processing;
            order.TotalAmount = order.OrderItems.Sum(i => i.Price * i.Quantity);

            _OrderRepo.Add(order);
        }


        public IEnumerable<Order> GetOrders() => _OrderRepo.GetAll();

        public Order GetOrder(int id) => _OrderRepo.GetById(id);
    }


}
