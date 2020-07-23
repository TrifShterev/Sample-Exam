using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                int index = int.Parse(command[1]);
                int value = int.Parse(command[2]);

                switch (command[0])
                {
                    case "Shoot":
                        if (index >= 0 && index <= targets.Count - 1)
                        {
                            ReturnsResultOfShoting(index, value, targets);
                            break;
                        }
                        break;
                    case "Add":
                        if (index >= 0 && index <= targets.Count - 1)
                        {
                            targets.Insert(index, value);

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":

                        if (index >= 0 && index <= targets.Count - 1)

                        { var startAtIndex = index - value;
                            var endAtIndex = index + value;

                            if (startAtIndex>=0&& endAtIndex<=targets.Count-1)
                            {
                                targets.RemoveRange(startAtIndex, value*2+1);
                            }
                            else
                            {
                                Console.WriteLine("Strike missed!");
                            }
                            

                        }break;
                      
                }

            }
            Console.WriteLine(String.Join("|",targets));

        }
        static void ReturnsResultOfShoting(int index,int value, List<int> listOfTargets)
        {
            listOfTargets[index] -= value;
            if (listOfTargets[index]<=0)
            {
                listOfTargets.RemoveAt(index);
            }
          
        }
    }
}
