using System;
using System.Collections.Generic;

namespace InventoryManagementSystem
{
    class Program
    {
        static List<string> inventory = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Inventory Management System\n");
                Console.WriteLine("1. View Inventory");
                Console.WriteLine("2. Add Item");
                Console.WriteLine("3. Remove Item");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ViewInventory();
                        break;
                    case "2":
                        AddItem();
                        break;
                    case "3":
                        RemoveItem();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void ViewInventory()
        {
            Console.Clear();
            Console.WriteLine("Inventory:\n");

            if (inventory.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
            }
            else
            {
                for (int i = 0; i < inventory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {inventory[i]}");
                }
            }

            Console.WriteLine("\nPress any key to return to the menu.");
            Console.ReadKey();
        }

        static void AddItem()
        {
            Console.Clear();
            Console.Write("Enter the name of the item to add: ");
            string item = Console.ReadLine();
            inventory.Add(item);
            Console.WriteLine($"{item} has been added to the inventory.");
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }

        static void RemoveItem()
        {
            Console.Clear();
            Console.Write("Enter the number of the item to remove: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= inventory.Count)
            {
                string item = inventory[index - 1];
                inventory.RemoveAt(index - 1);
                Console.WriteLine($"{item} has been removed from the inventory.");
            }
            else
            {
                Console.WriteLine("Invalid item number.");
            }
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }
    }
}
