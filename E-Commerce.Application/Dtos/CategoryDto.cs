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
        public int CatId { get; set; }

        [Required(ErrorMessage ="Category Name Is Requird")]
        [StringLength(50)]
        public string CatName { get; set; }

        [Required(ErrorMessage = "Category Description Is Requird")]
        [StringLength(500)]
        public string CatDescription { get; set; }
      
    }
}
