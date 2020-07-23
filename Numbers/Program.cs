using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            double totalSum = numbers.Sum();
            double averageSum = totalSum / numbers.Count;

            List<int> biggerThanAverageNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]>averageSum)
                {
                    biggerThanAverageNumbers.Add(numbers[i]);
                }
            }
            biggerThanAverageNumbers.Sort();
            biggerThanAverageNumbers.Reverse();
            if (biggerThanAverageNumbers.Count<=5&&biggerThanAverageNumbers.Count>0)
            {
                Console.WriteLine(String.Join(" ",biggerThanAverageNumbers));
            }
            else if (biggerThanAverageNumbers.Count > 5 && biggerThanAverageNumbers.Count > 0)
            {
                List<int> topFive = new List<int>();
                for (int i = 0; i < biggerThanAverageNumbers.Count; i++)
                {
                    if (i<5)
                    {
                        topFive.Add(biggerThanAverageNumbers[i]);
                    }
                }
                Console.WriteLine(String.Join(" ",topFive));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
