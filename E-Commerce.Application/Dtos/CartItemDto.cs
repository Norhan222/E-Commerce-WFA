using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Dtos
{
    public class CartItemDto
    {
        public int CartId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
