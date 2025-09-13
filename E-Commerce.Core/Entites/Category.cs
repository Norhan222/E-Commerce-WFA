using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Entites
{
<<<<<<< HEAD
    public class Category:BaseModel<int>
    {
=======
    public class Category : BaseModel<int>
    {
        //public int Id { get; set; }
>>>>>>> fedcc878f2a5a737932d817d8d78a2909cf62096
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
