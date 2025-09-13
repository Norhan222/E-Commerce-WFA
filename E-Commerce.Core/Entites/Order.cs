using E_Commerce.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Entites
{
<<<<<<< HEAD
    public class Order:BaseModel<int>
    {
=======
    public class Order : BaseModel<int>
    {
        //public int Id { get; set; }
>>>>>>> fedcc878f2a5a737932d817d8d78a2909cf62096
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public OrderStatus Status { get; set; }=OrderStatus.Processing;
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
