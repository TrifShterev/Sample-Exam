using System;
using System.Collections.Generic;
using System.Linq;

namespace Friendlist_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friendsList = Console.ReadLine().Split(", ").ToList();
            var countLost = 0;
            var countBlacklisted = 0;
            string input;
            while ((input=Console.ReadLine())!= "Report")
            {
                string[] commands = input.Split();

                switch (commands[0])
                {
                    case "Blacklist":
                        if (friendsList.Contains(commands[1]))
                        {
                            Console.WriteLine($"{commands[1]} was blacklisted.");
                            friendsList.Insert(friendsList.IndexOf(commands[1]), "Blacklisted");
                            friendsList.Remove(commands[1]);
                            countBlacklisted++;
                        }
                        else
                        {
                            Console.WriteLine($"{commands[1]} was not found.");
                        }
                        break;
                    case "Error":
                        int indexOfElement = int.Parse(commands[1]);
                        string nameOfElement = friendsList.ElementAt(indexOfElement);
                        if (nameOfElement!="Blacklisted"&& nameOfElement !="Lost")
                        {
                            Console.WriteLine($"{nameOfElement} was lost due to an error.");
                            friendsList.Insert(indexOfElement, "Lost");
                            friendsList.Remove(nameOfElement);
                            countLost++;
                        }
                        break;
                    case "Change":
                        int index = int.Parse(commands[1]);
                        string newName = commands[2];
                        if (index>=0&&index<friendsList.Count)
                        {

                            Console.WriteLine($"{friendsList.ElementAt(index)} changed his username to {newName}.");
                            friendsList.Insert(index, newName);
                            friendsList.RemoveAt(index + 1);
                        }
                        break;
                }
            }
            Console.WriteLine($"Blacklisted names: {countBlacklisted}");
            Console.WriteLine($"Lost names: {countLost}");
            Console.WriteLine(String.Join(" ",friendsList));
        }
    }
}
