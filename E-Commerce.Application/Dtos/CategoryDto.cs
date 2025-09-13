using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Category Name Is Requird")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Category Description Is Requird")]
        public string Description { get; set; }
      
    }
}
