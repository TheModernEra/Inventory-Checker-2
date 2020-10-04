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
                    Console.WriteLine("exit - exits the program");
                    Console.WriteLine("");
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

                    var initialJson = File.ReadAllText(@"c:\items.json");
                    var array = JArray.Parse(initialJson);


                    Item example = new Item();
                    example.Itemname = itemname;
                    example.Itemtype = itemtype;

                    string objjsonData = JsonConvert.SerializeObject(example);
                    Console.Write(objjsonData);
                    System.IO.File.WriteAllText(@"C:\items.json", objjsonData);
                }
                command = Console.ReadLine();
            }
        }
    }
}
