using System;
using System.Collections.Generic;
using System.Globalization;
using CourseProductImportedUsed.Entities;

namespace CourseProductImportedUsed {
    class Program {
        static void Main(string[] args) {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                switch (type) {
                    case 'c':
                        Product p1 = new Product(name, price);
                        products.Add(p1);
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        Product p2 = new UsedProduct(name, price, date);
                        products.Add(p2);
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Product p3 = new ImportedProduct(name, price, fee);
                        products.Add(p3);
                        break;
                }

            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product p in products) {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
