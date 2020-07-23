using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();

            string input;

            while ((input = Console.ReadLine())!= "Craft!")
            {
                string[] command =input.Split(" - ");
                string item = command[1];
                switch (command[0])
                {
                    case "Collect":
                        if (!inventory.Contains(item))
                        {
                            inventory.Add(item);
                        }
                        break;
                    case "Drop":
                        if (inventory.Contains(item))
                        {
                            inventory.Remove(item);
                        }

                            break;
                    case "Combine Items":

                        string[] itemsSeparator = input.Split(new string[] { " - ", ":" }, StringSplitOptions.RemoveEmptyEntries);
                        string oldItem = itemsSeparator[1];
                        string newItem = itemsSeparator[2];

                        if (inventory.Contains(oldItem))
                        {
                            inventory.Insert(inventory.IndexOf(oldItem), newItem);
                            inventory.Remove(oldItem);
                            inventory.Insert(inventory.IndexOf(newItem), oldItem);
                            
                        }
                            break;
                    case "Renew":
                        if (inventory.Contains(item))
                        {
                            inventory.Remove(item);
                            inventory.Add(item);
                        }
                            break;
                }
            }
            Console.WriteLine(String.Join(", ",inventory));
        }
    }
}
