using System;
using System.Collections.Generic;
using System.Linq;

namespace Mu_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            var health = 100;
            var bitcoins = 0;

            List<string> rooms = Console.ReadLine().Split("|").ToList();


            for (int i = 0; i < rooms.Count; i++)
            {
                
                string[] command = rooms[i].Split(new string[] {" ","|" }, StringSplitOptions.RemoveEmptyEntries);
                int amount = int.Parse(command[1]);

                switch (command[0])
                {
                    case "potion":
                        int currentHealth = health;
                        health += amount;
                        
                        if (health>=100)
                        { 
                            health = 100;
                            var resultHealth = 100 - currentHealth;
                            Console.WriteLine($"You healed for {resultHealth} hp.");

                        }
                        else
                        {
                            Console.WriteLine($"You healed for {amount} hp.");
                        }
                        

                        
                        Console.WriteLine($"Current health: {health} hp.");
                        break;
                    case "chest":
                        bitcoins += amount;
                        Console.WriteLine($"You found {amount} bitcoins.");
                        break;
                    default:
                        health -= amount;
                        if (health<=0)
                        {
                            Console.WriteLine($"You died! Killed by {command[0]}.");
                            Console.WriteLine($"Best room: {i+1}");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"You slayed {command[0]}.");
                        }
                        break;
                }

            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}"); 
            Console.WriteLine($"Health: {health}");
            

            
        }
    }
}
