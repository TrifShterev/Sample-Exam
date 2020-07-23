using System;

namespace Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            double lectures = double.Parse(Console.ReadLine());
            double additionalBonus = double.Parse(Console.ReadLine());
            int visitedLectures = 0;
            double maxBonus = 0;
            for (int i = 0; i < students; i++)
            {
                int attendamce = int.Parse(Console.ReadLine());
                if (attendamce>visitedLectures)
                {
                    visitedLectures = attendamce;
                }
                double totalBonus = (attendamce / lectures) * (5 + additionalBonus);
                if (totalBonus>maxBonus)
                {
                    maxBonus = totalBonus;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {visitedLectures} lectures.");
        }
    }
}
