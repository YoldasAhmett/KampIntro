using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category(){CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category(){CategoryId = 2, CategoryName = "Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32 GB Ram",
                 UnitInStock = 4, UnitPrice = 10000},
                new Product{ ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "16 GB Ram",
                 UnitInStock = 12, UnitPrice = 8000},
                new Product{ ProductId = 3, CategoryId = 1, ProductName = "Hp Laptop", QuantityPerUnit = "8 GB Ram",
                 UnitInStock = 25, UnitPrice = 7000},
                new Product{ ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "3 GB Ram",
                 UnitInStock = 8, UnitPrice = 2000},
                new Product{ ProductId = 5, CategoryId = 2, ProductName = "Apple Telefon", QuantityPerUnit = "4 GB Ram",
                 UnitInStock = 9, UnitPrice = 6000}
            };

            Console.WriteLine("-----------Algoritmik");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 5)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("---------------Linq");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 5);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 5)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 5).ToList();
        }

        class Product
        {
            public int ProductId { get; set; }
            public int CategoryId { get; set; }
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }
            public decimal UnitPrice { get; set; }
            public int UnitInStock { get; set; }
        }

        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }
    }
}
