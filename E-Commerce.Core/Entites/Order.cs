using E_Commerce.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Entites
{

    public class Order:BaseModel<int>
    {
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public OrderStatus Status { get; set; }=OrderStatus.Processing;
        public decimal TotalAmount { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
