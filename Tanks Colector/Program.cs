using System;
using System.Collections.Generic;
using System.Linq;

namespace Tanks_Colector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfTanks = Console.ReadLine().Split(", ").ToList();

            int numOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split(", ");

                switch (commands[0])
                {
                    case "Add":
                        if (listOfTanks.Contains(commands[1]))
                        {
                            Console.WriteLine("Tank is already bought");
                        }
                        else
                        {
                            listOfTanks.Add(commands[1]);
                            Console.WriteLine("Tank successfully bought");
                        }
                        break;
                    case "Remove":
                        if (listOfTanks.Contains(commands[1]))
                        {
                            Console.WriteLine("Tank successfully sold");
                            listOfTanks.Remove(commands[1]);
                        }
                        else
                        {
                            Console.WriteLine("Tank not found");
                        }
                        break;
                    case "Remove At":
                        int indexToRemove = int.Parse(commands[1]);
                        
                        if (indexToRemove>=0&&indexToRemove<listOfTanks.Count)
                        {
                            Console.WriteLine("Tank successfully sold");
                            listOfTanks.RemoveAt(indexToRemove);
                            
                            
                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                        }
                        break;
                    case "Insert":
                        int indexToInsert = int.Parse(commands[1]);
                        string newName = commands[2];
                        if (indexToInsert >= 0 && indexToInsert < listOfTanks.Count )
                        {
                            if (listOfTanks.Contains(newName))
                            {
                                Console.WriteLine("Tank is already bought");
                            }
                            else
                            {
                                listOfTanks.Insert(indexToInsert, newName);
                                Console.WriteLine("Tank successfully bought");
                                
                            }

                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                            
                        }

                        break;

                }
            }
            Console.WriteLine(String.Join(", ",listOfTanks));
        }
    }
}
