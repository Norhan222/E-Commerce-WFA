using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.PL
{
    internal class Helper
    {
        public static List<ValidationResult> Validate<T>(T Dto) where T : class
        {
            var context = new ValidationContext(Dto, serviceProvider: null, items: null);
            var results= new List<ValidationResult>();
            Validator.TryValidateObject(Dto, context, results, validateAllProperties: true);
            return results;
        }
    }
}
