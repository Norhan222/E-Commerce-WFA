using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage ="Username Is Required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        public string Password { get; set; }
    }
}
