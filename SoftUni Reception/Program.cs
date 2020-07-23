using System;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int emplyee1 = int.Parse(Console.Readline());
            int emplyee2 = int.Parse(Console.Readline());
            int emplyee3 = int.Parse(Console.Readline());
            int totalStudents = int.Parse(Console.Readline());

            double totalPerHour = emplyee1 + emplyee2 + emplyee3;

            int hoursCount = 0;
            int breaks = 0;
            while (totalStudents!=0)
            {
                totalStudents -= totalPerHour;
                hoursCount++;
                breaks++;
                if (totalStudents<0)
                {
                    hoursCount++;
                    break;

                }
                if (breaks==4)
                {
                    hoursCount++;
                }
            }
            global::System.Console.WriteLine($"Time needed: {hoursCount}h.");

        }
    }
}
