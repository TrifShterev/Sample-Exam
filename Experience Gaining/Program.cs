using System;

namespace Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExp = double.Parse(Console.ReadLine());
            double numOfBattles = double.Parse(Console.ReadLine());
            double experience = 0;
            int battleCount = 0;
            for (int i = 1; i <= numOfBattles; i++)
            {
                double currentBattle = double.Parse(Console.ReadLine());

                if (i%3==0)
                {
                    currentBattle += (currentBattle*0.15);
                }
                if (i%5==0)
                {
                    currentBattle -= currentBattle * 0.10;
                }
                experience += currentBattle;
                battleCount++;
                if (experience>=neededExp)
                {
                    break;
                }
            }
            if (experience >= neededExp)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battleCount} battles.");
            }
            else
            {
                var neededExperience = neededExp - experience;
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperience:f2} more needed.");
            }
        }
    }
}
