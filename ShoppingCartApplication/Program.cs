using System;
using System.Collections.Generic;
using System.Linq;


namespace ShoppingCartApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============== Welcome to Hamdan Mall ===============");

            ShoppingCart cart = new ShoppingCart();
            GroceryStore groceryStore = new GroceryStore();
            ClothingStore clothingStore = new ClothingStore();
            ElectronicsStore electronicsStore = new ElectronicsStore();

            while (true)
            {
                Console.WriteLine("1. Shop at Grocery Store");
                Console.WriteLine("2. Shop at Clothing Store");
                Console.WriteLine("3. Shop at Electronics Store");
                Console.WriteLine("4. Show Random Products from All Categories");
                Console.WriteLine("5. View Shopping Cart");
                Console.WriteLine("6. Checkout and Exit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        cart.Shop(groceryStore);
                        break;
                    case "2":
                        cart.Shop(clothingStore);
                        break;
                    case "3":
                        cart.Shop(electronicsStore);
                        break;
                    case "4":
                        cart.ShowRandomProducts();
                        break;
                    case "5":
                        cart.ViewCart();
                        break;
                    case "6":
                        cart.Checkout();
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
