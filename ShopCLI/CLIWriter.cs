using System;
using System.Collections.Generic;
using Models;
using ShopCLI.Interfaces;

namespace ShopCLI
{
    public class CLIWriter : ICLIWriter
    {
        public void ShowMenu()
        {
            Console.WriteLine("Choose menu item: ");
            Console.WriteLine("1. Show all products from catalog");
            Console.WriteLine("2. Show info about product");
            Console.WriteLine("3. Choose product you want to order");
            Console.WriteLine("4. Show all destinations");
            Console.WriteLine("5. Choose destination where we need to deliver the order");
            Console.WriteLine("6. Confirm order");
            Console.WriteLine("7. Exit application");
        }

        public void ShowCatalog(IEnumerable<ProductModel> products)
        {
            Console.WriteLine("------------Catalog-------------");
            Dictionary<string, int> titles = new Dictionary<string, int>()
            {
                {"Id", 2}, {"Name", 4}, {"Price", 5}
            };
            foreach (ProductModel product in products)
            {
                titles["Id"] = Math.Max(titles["Id"], product.Id.ToString().Length);
                titles["Name"] = Math.Max(titles["Name"], product.Name.Length);
                titles["Price"] = Math.Max(titles["Price"], product.Price.ToString().Length);
            }

            Console.Write("| ");
            foreach (var item in titles)
            {
                string spacer = new string(' ', item.Value - item.Key.Length);
                Console.Write($"{item.Key}{spacer} | ");
            }
            Console.WriteLine();
            foreach (ProductModel product in products)
            {
                string spacer = new string(' ', titles["Id"] - product.Id.ToString().Length);
                Console.Write($"| {product.Id}{spacer} | ");
                spacer = new string(' ', titles["Name"] - product.Name.ToString().Length);
                Console.Write($"{product.Name}{spacer} | ");
                spacer = new string(' ', titles["Price"] - product.Price.ToString().Length);
                Console.WriteLine($"{product.Price}{spacer} | ");
            }
            Console.WriteLine("--------------------------------");
        }

        public void ShowProduct(ProductModel product)
        {
            Console.WriteLine("---------Product--------");
            Console.WriteLine($"Id: {product.Id}");
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Product Type: {product.ProductTypeModel.Name}");
            Console.WriteLine($"Price: {product.Price}");
            Console.WriteLine($"Width: {product.Width}");
            Console.WriteLine($"Height: {product.Height}");
            Console.WriteLine($"Length: {product.Length}");
            Console.WriteLine($"Weight: {product.Weight}");
            Console.WriteLine("------------------------");
        }

        public void ShowDeliveryMap(IEnumerable<DestinationModel> destinations)
        {
            Console.WriteLine("---------Delivery Map----------");
            Dictionary<string, int> titles = new Dictionary<string, int>()
            {
                {"Id", 2}, {"Name", 4}, {"Distance", 8}
            };
            foreach (DestinationModel destination in destinations)
            {
                titles["Id"] = Math.Max(titles["Id"], destination.Id.ToString().Length);
                titles["Name"] = Math.Max(titles["Name"], destination.Name.Length);
                titles["Distance"] = Math.Max(titles["Distance"], destination.Distance.ToString().Length);
            }

            Console.Write("| ");
            foreach (var item in titles)
            {
                string spacer = new string(' ', item.Value - item.Key.Length);
                Console.Write($"{item.Key}{spacer} | ");
            }
            Console.WriteLine();
            foreach (DestinationModel destination in destinations)
            {
                string spacer = new string(' ', titles["Id"] - destination.Id.ToString().Length);
                Console.Write($"| {destination.Id}{spacer} | ");
                spacer = new string(' ', titles["Name"] - destination.Name.Length);
                Console.Write($"{destination.Name}{spacer} | ");
                spacer = new string(' ', titles["Distance"] - destination.Distance.ToString().Length);
                Console.WriteLine($"{destination.Distance}{spacer} | ");
            }
            Console.WriteLine("-------------------------------");
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        
        public void ShowMessage(bool warning, string message)
        {
            if (warning)
            {
                Console.Write("Warning!!! ");
            }
            Console.WriteLine(message);
        }

        public void ShowDestination(DestinationModel destination)
        {
            Console.WriteLine("--------Delivery Place---------");
            Console.WriteLine($"Id: {destination.Id}");
            Console.WriteLine($"Name: {destination.Name}");
            Console.WriteLine($"Distance: {destination.Distance}");
            Console.WriteLine("-------------------------------");
        }
        public void ShowOrder(OrderModel order)
        {
            Console.WriteLine("------------Order-------------");
            Console.WriteLine($"Id: {order.Id}");
            Console.WriteLine($"Product: {order.ProductModel.Name}");
            Console.WriteLine($"Price: {order.ProductModel.Price}");
            Console.WriteLine($"Vehicle: {order.VehicleModel.Name}");
            Console.WriteLine($"Destination: {order.DestinationModel.Name}");
            Console.WriteLine($"Date: {order.StartDate}");
            Console.WriteLine($"Delivery start: {order.DeliveryStartDate}");
            Console.WriteLine($"Delivery end: {order.DeliveryEndDate}");
            Console.WriteLine("------------------------------");
        }
    }
}