using E_Commerce.PL.Admin.ChildForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.PL.Admin.ChildForm
{
    public class Category
    {
        public static List<Category> categories=new List<Category>();
        public Category()
        {
          
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public void Add(Category c)
        {
            categories.Add(c);
        }
    }
}
