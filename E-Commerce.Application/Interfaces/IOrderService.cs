using E_Commerce.Application.Dtos;
using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Interfaces
{
    public interface IOrderService
    {
        void PlaceOrder(OrderDto orderDto);
        public IEnumerable<Order> GetOrders();
        public IEnumerable<OrderDto> GetOrdersForUser(int userid);

        public Order GetOrder(int id);
        public void Save();
    }
}
