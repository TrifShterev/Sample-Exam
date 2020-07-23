using System;
using System.Collections.Generic;
using System.Linq;

namespace Wizard_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(":").ToList();
            List<string> newDeck = new List<string>();

            string input;
            while ((input=Console.ReadLine())!="Ready")
            {
                string[] command = input.Split();
                string card = command[1];
                if (command[0]== "Shuffle"&&card=="deck")
                {
                    newDeck.Reverse();
                }
                switch (command[0])
                {
                    case "Add":
                        if (cards.Contains(card))
                        { 
                            newDeck.Add(card);
                           
                        }
                        else
                        {
                            Console.WriteLine("Card not found.");
                        }
                        break;
                    case "Insert":
                        int indexToInsert = int.Parse(command[2]);
                        if (cards.Contains(card)&&newDeck.Count>indexToInsert&&indexToInsert>=0)
                        {
                            
                            newDeck.Insert(indexToInsert, card);
                            

                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        
                        break;
                    case "Remove":
                        if (newDeck.Contains(card))
                        {
                            newDeck.Remove(card);
                        }
                        else
                        {
                            Console.WriteLine("Card not found.");
                        }
                        break;
                    case "Swap":
                        string card2 = command[2];
                        SwapingCards(card, card2, newDeck);
                        break;
                }
            }
            Console.WriteLine(String.Join(" ",newDeck));
        }
        static void SwapingCards(string element1, string element2, List<string> list)
        {
            var indexElement1 = list.IndexOf(element1);
            var indexElement2 = list.IndexOf(element2);
            var temp = list[indexElement1];
            list[indexElement1] = list[indexElement2];
            list[indexElement2] = temp;
        }
    }
}
