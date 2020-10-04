using System;
using Newtonsoft.Json;
using System.IO;


namespace Inventory_Checker_2
{
    public class Item
    {
        public String Itemname { get; set; }
        public String Itemtype { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inventory Manager by ModernEra");
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
                    Console.WriteLine("clear - clears list of items in inventory");
                    Console.WriteLine("exit - exits the program");
                    Console.WriteLine("");
                    Console.WriteLine("Please enter another command.");
                }

                if (command.Equals("exit"))
                {
                    checker = false;
                    Console.WriteLine("Press any key to exit. See you next time!");
                }

                if (command.Equals("add"))
                {
                    Console.WriteLine("What is the item called?");
                    var itemname = Console.ReadLine();
                    Console.WriteLine("What is the item classified as? (appliance, utility, entertainment, etc.)");
                    var itemtype = Console.ReadLine();

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\items.txt", true))
                    {
                        file.WriteLine("Name: " + itemname + "\n" + "Type: "  + itemtype + "\n");
                    }

                    Console.WriteLine("Item added!");
                    Console.WriteLine("Please enter another command.");
                }

                if (command.Equals("clear"))
                {
                    Console.WriteLine("Are you sure?");
                    var uhoh = Console.ReadLine();
                    if (uhoh.Equals("yes"))
                    {
                        File.Delete(@"C:\items.txt");
                        Console.WriteLine("Inventory cleared!");
                        Console.WriteLine("Please enter another command.");
                    } else
                    {
                        Console.WriteLine("Inventory not cleared.");
                        Console.WriteLine("Please enter another command.");
                    }
                }

                if (command.Equals("list"))
                {
                    if (File.Exists(@"c:\items.txt") == false)
                    {
                        Console.WriteLine("No items have been added! Add one using the \"add\" command");
                        Console.WriteLine("Please enter another command.");
                    } else
                    {
                        string[] lines = System.IO.File.ReadAllLines(@"C:\items.txt");
                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Please enter another command.");
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
