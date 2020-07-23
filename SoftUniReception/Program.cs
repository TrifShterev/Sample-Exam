using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int emplyee1 = int.Parse(Console.ReadLine());
            int emplyee2 = int.Parse(Console.ReadLine());
            int emplyee3 = int.Parse(Console.ReadLine());
            double totalStudents = double.Parse(Console.ReadLine());

            double totalPerHour = emplyee1 + emplyee2 + emplyee3;

            int hoursCount = 0;
            int untilBreakCount = 0;
            while (totalStudents != 0)
            {
                totalStudents -= totalPerHour;
                hoursCount++;
                untilBreakCount++;
                
                if (untilBreakCount %4==0)
                {
                    untilBreakCount++;
                    hoursCount++;
                }
                if (totalStudents < 0)
                {

                    break;

                }
            }
            Console.WriteLine($"Time needed: {hoursCount}h.");

        }
    }
}
