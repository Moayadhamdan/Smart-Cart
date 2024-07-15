using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ProductGenerator
    {
        private List<Product> allProducts;

        public ProductGenerator()
        {
            allProducts = new List<Product>
        {
            // Food Products
            new Product { Name = "Apple", Price = 0.5m, Category = ProductCategory.Food, Discount = 0 },
            new Product { Name = "Banana", Price = 0.3m, Category = ProductCategory.Food, Discount = 0 },
            new Product { Name = "Bread", Price = 1.0m, Category = ProductCategory.Food, Discount = 10 },
            new Product { Name = "Milk", Price = 0.8m, Category = ProductCategory.Food, Discount = 5 },
            new Product { Name = "Cheese", Price = 2.5m, Category = ProductCategory.Food, Discount = 0 },
            new Product { Name = "Chicken", Price = 5.0m, Category = ProductCategory.Food, Discount = 15 },
            new Product { Name = "Beef", Price = 7.0m, Category = ProductCategory.Food, Discount = 10 },
            new Product { Name = "Fish", Price = 6.0m, Category = ProductCategory.Food, Discount = 0 },
            new Product { Name = "Yogurt", Price = 1.2m, Category = ProductCategory.Food, Discount = 5 },
            new Product { Name = "Eggs", Price = 1.5m, Category = ProductCategory.Food, Discount = 0 },

            // Clothing Products
            new Product { Name = "Shirt", Price = 20.0m, Category = ProductCategory.Clothing, Discount = 10 },
            new Product { Name = "Pants", Price = 30.0m, Category = ProductCategory.Clothing, Discount = 0 },
            new Product { Name = "Dress", Price = 50.0m, Category = ProductCategory.Clothing, Discount = 20 },
            new Product { Name = "Shoes", Price = 40.0m, Category = ProductCategory.Clothing, Discount = 15 },
            new Product { Name = "Hat", Price = 15.0m, Category = ProductCategory.Clothing, Discount = 0 },
            new Product { Name = "Socks", Price = 5.0m, Category = ProductCategory.Clothing, Discount = 0 },
            new Product { Name = "Jacket", Price = 60.0m, Category = ProductCategory.Clothing, Discount = 25 },
            new Product { Name = "Gloves", Price = 10.0m, Category = ProductCategory.Clothing, Discount = 0 },
            new Product { Name = "Scarf", Price = 12.0m, Category = ProductCategory.Clothing, Discount = 0 },
            new Product { Name = "Belt", Price = 18.0m, Category = ProductCategory.Clothing, Discount = 0 },

            // Electronics Products
            new Product { Name = "Laptop", Price = 1000.0m, Category = ProductCategory.Electronics, Discount = 30 },
            new Product { Name = "Smartphone", Price = 800.0m, Category = ProductCategory.Electronics, Discount = 25 },
            new Product { Name = "Tablet", Price = 600.0m, Category = ProductCategory.Electronics, Discount = 20 },
            new Product { Name = "Smartwatch", Price = 200.0m, Category = ProductCategory.Electronics, Discount = 15 },
            new Product { Name = "Headphones", Price = 100.0m, Category = ProductCategory.Electronics, Discount = 0 },
            new Product { Name = "Speaker", Price = 150.0m, Category = ProductCategory.Electronics, Discount = 0 },
            new Product { Name = "Camera", Price = 500.0m, Category = ProductCategory.Electronics, Discount = 20 },
            new Product { Name = "Printer", Price = 120.0m, Category = ProductCategory.Electronics, Discount = 5 },
            new Product { Name = "Mouse", Price = 20.0m, Category = ProductCategory.Electronics, Discount = 0 },
            new Product { Name = "Keyboard", Price = 30.0m, Category = ProductCategory.Electronics, Discount = 0 },
        };
        }

        public List<Product> GenerateRandomProducts()
        {
            Random random = new Random();
            List<Product> randomProducts = new List<Product>();

            List<Product> shuffledProducts = allProducts.OrderBy(x => random.Next()).ToList();

            for (int i = 0; i < 10 && i < shuffledProducts.Count; i++)
            {
                randomProducts.Add(shuffledProducts[i]);
            }

            return randomProducts;
        }

        public List<Product> GenerateFoodProducts()
        {
            return allProducts.Where(p => p.Category == ProductCategory.Food).Take(10).ToList();
        }

        public List<Product> GenerateClothingProducts()
        {
            return allProducts.Where(p => p.Category == ProductCategory.Clothing).Take(10).ToList();
        }

        public List<Product> GenerateElectronicsProducts()
        {
            return allProducts.Where(p => p.Category == ProductCategory.Electronics).Take(10).ToList();
        }
    }
}