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
        void PlaceOrder(Order order);
        IEnumerable<Order> GetOrders();
        Order GetOrder(int id);
    }
}
