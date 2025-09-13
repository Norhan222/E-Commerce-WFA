using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Entites
{
<<<<<<< HEAD
    public class Cart:BaseModel<int>
    {
=======
    public class Cart :BaseModel <int>
    {
        //public int Id { get; set; }
>>>>>>> fedcc878f2a5a737932d817d8d78a2909cf62096
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
