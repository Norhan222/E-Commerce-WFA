using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Entites
{
<<<<<<< HEAD
    public class Product:BaseModel<int>
    {
=======
    public class Product : BaseModel<int>
    {
        //public int Id { get; set; }
>>>>>>> fedcc878f2a5a737932d817d8d78a2909cf62096
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
