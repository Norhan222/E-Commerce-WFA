using E_Commerce.Core.Entites;
using E_Commerce.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Processing;
        public decimal TotalAmount { get; set; }
        public ICollection<OrderItemDto> OrderItems { get; set; }
    }
}
