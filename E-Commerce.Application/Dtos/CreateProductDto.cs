using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Dtos
{
    public class CreateProductDto
    {
        [Required]
        [StringLength(50)]
        public string ProdName { get; set; }
        [StringLength(500)]
        public string ProdDescription { get; set; }
        public decimal ProdUnitPrice { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
