using System;
using System.Collections.Generic;
using System.Linq;

namespace Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> particles = Console.ReadLine().Split("|").ToList();

            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] command = input.Split();


                if (command[0] == "Move" && command[1] == "Left")
                {
                    int index = int.Parse(command[2]);
                    int newIndex = index - 1;
                    if (particles.Count>newIndex&&newIndex>=0)
                    {
                        var part1 = particles.ElementAt(index);
                        var part2 = particles.ElementAt(newIndex);
                        SwapingElements(part1, part2, particles);
                    }
                }
                else if (command[0] == "Move" && command[1] == "Right")
                {
                    int index = int.Parse(command[2]);
                    int newIndex = index + 1;
                    if (particles.Count > newIndex && newIndex >= 0)
                    {
                        var part1 = particles.ElementAt(index);
                        var part2 = particles.ElementAt(newIndex);
                        SwapingElements(part1, part2, particles);
                    }
                }
                else if (command[0] == "Check" && command[1] == "Even")
                {
                    Console.WriteLine(FindEvens(particles));
                }
                else if (command[0] == "Check" && command[1] == "Odd")
                {

                    Console.WriteLine(FindOdds(particles));
                }
            }
            Console.WriteLine($"You crafted {String.Join("",particles)}!");
        }
        static string FindOdds(List<string> list)
        {
            List<string> oddsList = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 1)
                {
                    oddsList.Add(list[i]);
                }
            }
            return String.Join(" ", oddsList);
        }
        static string FindEvens(List<string> list)
        {
            List<string> evenList = new List<string>();
            for (int i = 0; i <list.Count; i++)
            {
                if (i%2==0)
                {
                    evenList.Add(list[i]);
                }
            }
            return String.Join(" ", evenList);
        }
        static void SwapingElements(string element1, string element2, List<string> list)
        {
            var index = list.IndexOf(element1);
            var newIndex = list.IndexOf(element2);
            var temp = list[index];
            list[index] = list[newIndex];
            list[newIndex] = temp;
        }
    }
}
