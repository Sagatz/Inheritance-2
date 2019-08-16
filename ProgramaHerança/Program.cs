using System;
using System.Collections.Generic;
using ProgramaHerança.Entities;

namespace ProgramaHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char check = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (check == 'c' || check == 'C')
                {
                    Product product = new Product(name, price);
                    products.Add(product);
                }
                else if (check == 'u' || check == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    Product product = new UsedProduct(name, price, manufactureDate);
                    products.Add(product);
                }
                else if (check == 'i' || check == 'I')
                {
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    Product product = new ImportedProduct(name, price, customFee);
                    products.Add(product);
                }
                Console.WriteLine();
            }
            Console.WriteLine("PRICE TAGS:");
            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
