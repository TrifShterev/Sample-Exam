using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;
            while ((input=Console.ReadLine())!="end")
            {
                string[] command = input.Split();
               
                switch (command[0])
                {
                    case "swap":
                        int index1 = int.Parse(command[1]);
                        int index2 = int.Parse(command[2]);
                        SwapMethod(index1, index2, integers);
                        break;
                    case "multiply":
                        int index1multiply = int.Parse(command[1]);
                        int index2multiply = int.Parse(command[2]);
                        MultiplyMethod(index1multiply, index2multiply, integers);

                        break;
                    case "decrease":
                        DecreaseMethod(integers);
                        break;
                }
            }
            Console.WriteLine(String.Join(", ",integers));
        }static void DecreaseMethod(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] -= 1;
            }
        }
        static void MultiplyMethod (int index1, int index2, List<int> list)
        {
            var firstElement = list[index1];
            var secondElement = list[index2];
            var result = firstElement * secondElement;
            list[index1] = result;
        }
        static void SwapMethod(int index1, int index2, List<int> list)
        {
          
            var temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
        
    }
}
