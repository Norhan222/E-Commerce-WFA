using E_Commerce.Application.Interfaces;
using E_Commerce.Core.Entites;
using E_Commerce.Infrastrucrure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastrucrure.Repositories
{
    public class OrderRepo : IOrderRepo
    {
        AppDbContext _context;

        public OrderRepo(AppDbContext context)
        {
         _context = context;   
        }

        public void CreateOrder(Order order)
        {
            _context.Orders.Add(order);
        }
        // هنا هنرجع عنصر واحد  

        public Order GetOrderById(int orderId)
        {
            return _context.Orders.Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .FirstOrDefault(o=>o.Id == orderId);
        }

        public IEnumerable<Order> GetOrdersByUserId(int userId)
        {
            return _context.Orders.Include(o => o.OrderItems)
                   .ThenInclude(oi => oi.Product)
                   .Where(c=>c.UserId == userId)
                   .ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
        }

        public void Add(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public IEnumerable<Order> GetAll()
        {
            var orders = _context.Orders
                           .Include(o => o.OrderItems).Include(o => o.User);
            return orders;
        }
        public void Update(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }
        public Order GetById(int id)
        {
            return _context.Orders.Include(o => o.OrderItems).ThenInclude(oi => oi.Product)
                .FirstOrDefault(o => o.Id == id);
        }


    }
}
