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
    public class CartRepo : ICartRepo
    {
        AppDbContext _Context;

        public CartRepo( AppDbContext context)
        {
            _Context = context;
        }

        public void CreateCart(Cart cart)
        {
            _Context.Carts.Add(cart);
        }

        public Cart GetCartByUserId(int userId)
        {
            return _Context.Carts.Include(c => c.CartItems).ThenInclude(c => c.Product).FirstOrDefault(c => userId == c.UserId);
        }

        public void Save()
        {
            _Context.SaveChanges();
        }

        public void UpdateCart(Cart cart)
        {
            _Context.Carts.Update(cart);
        }
    }
}
