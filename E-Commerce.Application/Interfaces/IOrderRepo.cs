using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Interfaces
{
    public interface IOrderRepo
    {
        void Add(Order order);
        Order GetById(int id);
        IEnumerable<Order> GetAll();
        void Update(Order order);
        void Delete(int id);


    }
}
