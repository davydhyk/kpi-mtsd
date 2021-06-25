using System;
using ShopCLI.Interfaces;

namespace ShopCLI
{
    public class CLIReader : ICLIReader
    {
        public int GetMenuItemNumber()
        {
            Console.Write("Input menu item number: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        
        public int GetProductId() {
            Console.Write("Input product Id: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        
        public int GetDestinationId()
        {
            Console.Write("Input destination Id: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        
        public bool GetConfirm()
        {
            Console.Write("Confirm the action (y/n)?");
            string input = Console.ReadLine().ToLower();
            return String.Compare(input, "y") == 0;
        }
    }
}