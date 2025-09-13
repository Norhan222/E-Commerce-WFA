using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Interfaces
{
    public interface ICartRepo
    {
        public Cart GetCartByUserId(int userId);
        public void CreateCart(Cart cart);
        public void UpdateCart(Cart cart);
        public void Save();




       

    }
}
