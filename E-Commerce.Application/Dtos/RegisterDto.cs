using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Dtos
{
    internal class RegisterDto
    {
        [Required(ErrorMessage ="Username Is Requird")]
        public string  UserName { get; set; }

        [Required(ErrorMessage ="Email is Requird")]
        [EmailAddress(ErrorMessage ="Enter Valid Email")]
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage ="Password Is Requird")]
        [RegularExpression("^[a-zA-Z]+[0-9]+",ErrorMessage ="Password have atleast one number")]
        public string Password { get; set; }

    }
}
