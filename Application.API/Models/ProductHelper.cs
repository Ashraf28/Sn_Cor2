using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.API.Models
{
    public static class ProductHelper
    {
        private static List<Product> Products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Java",
                Description = "Great"
            },
            new Product()
            {
                Id = 2,
                Name = "cS",
                Description = "Good"
            },


        };
        public static Product AddProduct(Product product)
        {
            product.Id = Products.Count + 1;
            Products.Add(product);
            return product;
        }
        public static Product GetAProduct(int id)
        {
            return Products.FirstOrDefault(x => x.Id == id);


        }
        public static List<Product> Get()
        {
            
            return Products;
        }
        public static Product Update(int id, Product product)
        {
            var fproduct =  Products.FirstOrDefault(x => x.Id == id);
            fproduct.Name = product.Name;
            fproduct.Description = product.Description;

            return fproduct;


        }
        public static Product DeleteAProduct(int id)
        {
            var dproduct = Products.FirstOrDefault(x => x.Id == id);
            var products = Products.Where(x => x.Id != id).ToList();
            Products = products;
            return dproduct;


        }

    }
}
