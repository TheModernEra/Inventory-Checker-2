using System;

namespace Inventory_Checker_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inventory Manager by Bennett Rosenthal");
            Console.WriteLine("Enter a command to get started! type \"help\" for a list of commands :)");
            var command = Console.ReadLine();
            var checker = true;

            while (checker == true)
            {
                if (command.Equals("help"))
                {
                    Console.WriteLine("");
                    Console.WriteLine("help - lists all commands available");
                    Console.WriteLine("list - lists all items added to the inventory");
                    Console.WriteLine("add - starts process to add an item to the inventory");
                    Console.WriteLine("exit - exits the program");
                    Console.WriteLine("");
                }

                if (command.Equals("exit"))
                {
                    checker = false;
                    Console.WriteLine("Press any key to exit. See you next time!");
                    Console.WriteLine("yuh");
                }

                command = Console.ReadLine();
            }
        }
    }
}
