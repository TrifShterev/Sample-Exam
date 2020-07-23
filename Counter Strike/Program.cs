using System;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int battleWonCount = 0;
            while (command!="End of battle" && energy >= 0)
            {
                int distance = int.Parse(command);
                if ((energy - distance) < 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battleWonCount} won battles and {energy} energy");
                    return;

                }
                energy -= distance;
               
               
                battleWonCount++;
                if (battleWonCount%3==0)
                {
                    energy += battleWonCount;
                }
               

                command = Console.ReadLine();

            }
           
            Console.WriteLine($"Won battles: {battleWonCount}. Energy left: {energy}");
           
        }
    }
}
