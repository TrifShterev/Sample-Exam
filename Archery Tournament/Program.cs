using System;
using System.Collections.Generic;
using System.Linq;

namespace Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split("|").Select(int.Parse).ToList();
            var points = 0;
            string input;
            while ((input = Console.ReadLine()) != "Game over")
            {
                string[] command = input.Split("@");



                switch (command[0])
                {

                    case "Shoot Left":
                        int startIndex = int.Parse(command[1]);
                        int length = int.Parse(command[2]);
                        if (startIndex >= 0 && startIndex < targets.Count)
                        {
                            var targetIndex = SearchLeftIndex(targets, startIndex, length);
                            if (targets[targetIndex] <= 5)
                            {
                                points += targets[targetIndex];
                                targets[targetIndex] = 0;
                            }
                            else
                            {
                                targets[targetIndex] -= 5;
                                points += 5;
                            }
                        }
                        break;
                    case "Shoot Right":
                        int startIndexRight = int.Parse(command[1]);
                        int lengthRight = int.Parse(command[2]);
                        if (startIndexRight >= 0 && startIndexRight < targets.Count)
                        {
                            var targetIndexRight = SearchRightIndex(targets, startIndexRight, lengthRight);
                            if (targets[targetIndexRight] <= 5)
                            {
                                points += targets[targetIndexRight];
                                targets[targetIndexRight] = 0;
                            }
                            else
                            {
                                targets[targetIndexRight] -= 5;
                                points += 5;
                            }

                        }
                        break;

                    case "Reverse":
                        targets.Reverse();
                        break;

                }
            }
            Console.WriteLine(String.Join(" - ", targets));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
        static int SearchLeftIndex(List<int> targets, int index, int count)
        {
            var leftIndex = index - count;
            while (leftIndex < 0)
            {

                leftIndex = targets.Count + leftIndex;

            }


            return leftIndex;

        }
        static int SearchRightIndex(List<int> targets, int index, int count)
        {
            var rightIndex = index + count;
            while (rightIndex > targets.Count)
            {
                rightIndex = rightIndex - targets.Count;

            }
            return rightIndex;
        }
    }
}
