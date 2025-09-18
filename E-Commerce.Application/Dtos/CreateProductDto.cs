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
        [Required(ErrorMessage ="Product Name Is Requird")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description Is Requird")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Price Is Required")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public int Stock { get; set; } = 1;
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
