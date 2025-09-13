using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Entites
{
<<<<<<< HEAD
    public class CartItem:BaseModel<int>
    {
=======
    public class CartItem : BaseModel<int>
    {
        //public int Id { get; set; }
>>>>>>> fedcc878f2a5a737932d817d8d78a2909cf62096
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
