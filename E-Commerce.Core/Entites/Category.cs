using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Entites
{
    public class Category:BaseModel<int>
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public ICollection<Product>? Products { get; set; }

    }
}
