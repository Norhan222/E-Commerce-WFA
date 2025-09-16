using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Dtos
{
    public class CartDto
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
       public ICollection<CartItem> Cartitems { get; set; }=new HashSet<CartItem>();
    }
}
