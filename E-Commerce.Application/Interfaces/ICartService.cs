using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Interfaces
{
    public interface ICartService
    {
        public void AddToCart(int UserId , int ProductId ,int Quantity);
        public Cart GetCartById (int UserId);
        public void RemoveFromCart (int UserId, int ProductId);
    
        public void ClearCart (int UserId);
    }
}
