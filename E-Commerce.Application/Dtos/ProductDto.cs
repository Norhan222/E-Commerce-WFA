using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Product Name Is Required ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description  Is Required ")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Price Is Required")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public int Stock { get; set; } = 1;
        [Required(ErrorMessage = "Image Is Required")]
        public string ImageUrl { get; set; }
        public string CategoryName { get; set; }
        public bool IsAvailable => Stock > 0;
    }
}
