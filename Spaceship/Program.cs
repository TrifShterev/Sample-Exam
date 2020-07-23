using System;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double shipWidth = double.Parse(Console.ReadLine());
            double shiplenght = double.Parse(Console.ReadLine());
            double shipHeight= double.Parse(Console.ReadLine());
            double astrHeight = double.Parse(Console.ReadLine());

            double roomArea = 2 * 2 * (astrHeight + 0.40);
            double shipArea = shipWidth * shiplenght * shipHeight;

            double astr = shipArea/roomArea;

            if (astr>=3 && astr<=10)
            {
                Console.WriteLine($"The spacecraft holds {Math.Floor(astr)} astronauts.");
            }
            else if (astr<3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        
           
        }
    }
}
