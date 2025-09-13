using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Dtos
{
    public class CreateOrderDto
    {
        public int UserId { get; set; }
        public ICollection<CreateOrderItemDto> Items { get; set; }
    }
}
