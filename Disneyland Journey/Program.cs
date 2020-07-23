using System;

namespace Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfHoliday = double.Parse(Console.ReadLine());
            int amountMonths = int.Parse(Console.ReadLine());

            double savedMoney = 0;

            for (int i = 1; i <= amountMonths; i++)
            {
                
                if (i%2==1&& i>1)
                {
                    savedMoney -= savedMoney * 0.16;
                }
                if (i%4==0)
                {
                    savedMoney += savedMoney * 0.25;
                }
                savedMoney += priceOfHoliday * 0.25;
            }
            if (savedMoney>priceOfHoliday)
            { var moneyFOrSouveniers = savedMoney - priceOfHoliday;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {moneyFOrSouveniers:f2}lv. for souvenirs.");
            }
            else
            {
                var needMoney = priceOfHoliday - savedMoney;
                Console.WriteLine($"Sorry. You need {needMoney:f2}lv. more.");
            }

        }
    }
}
