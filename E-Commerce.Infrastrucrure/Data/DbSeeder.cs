using E_Commerce.Application.Services;
using E_Commerce.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace E_Commerce.Infrastrucrure.Data
{
    public static class DbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            var categoriesPath = Path.Combine(AppContext.BaseDirectory,"Data", "SeedData", "categories.json");
            var productsPath = Path.Combine(AppContext.BaseDirectory, "Data", "SeedData", "products.json");


            // @"E:\.net\Visual-C#\E-Commerce-WFA\E-Commerce.Infrastrucrure\Data\SeedData\products.json";
            // 🟢 Seed Categories
            if (!context.Categories.Any()) //  كدا مش هيضيف غير لو الجدول فاضي
            {
                if (File.Exists(categoriesPath))
                {
                    var json = File.ReadAllText(categoriesPath);
                    var categories = JsonSerializer.Deserialize<List<Category>>(json);

                    if (categories != null)
                    {
                        foreach (var cat in categories) //بعدين بيعمل loop على كلCategory 
                        {
                            if (!context.Categories.Any(c => c.Id == cat.Id))  //بيتأكد هل في داتا بنفس الـ Id موجودة أصلاً في الداتابيز ولا لأ.
                                context.Categories.Add(cat);  //لو مش موجودة (يعني جديدة) → يضيفها.
                        }
                    }
                }
                context.SaveChanges();
            }

            if (!context.Products.Any()) //  برضو يتأكد الأول إن الجدول فاضي
            {
                // 🟢 Seed Products
                if (File.Exists(productsPath))
                {
                    var json = File.ReadAllText(productsPath);
                    var products = JsonSerializer.Deserialize<List<Product>>(json);

                    if (products != null)
                    {
                        foreach (var prod in products)
                        {
                            if (!context.Products.Any(p => p.Id == prod.Id))
                                context.Products.Add(prod);
                        }
                    }
                }

                context.SaveChanges();
            }
      

        }

    }
}
