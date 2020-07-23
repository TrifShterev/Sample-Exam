using System;

namespace SeaTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFoodPerDay = double.Parse(Console.ReadLine());
            double moneyForSouvenirsPerDay = double.Parse(Console.ReadLine());
            double moneyForHotelPerDay = double.Parse(Console.ReadLine());
            // da izchilsq putq i razhodite
            double fuelExpences = (420.0 / 100.0) * 7.0;
            double fuelCosts = fuelExpences * 1.85;

            // 3 dni prestoi v hotel  1=10% 2=15% 3=20% namalenie

            double firstDay = moneyForHotelPerDay * 0.9;
            double secondDay = moneyForHotelPerDay * 0.85;
            double thirdDay = moneyForHotelPerDay * 0.80;
            double totalMoneyForHotel = firstDay + secondDay + thirdDay;

            double totalExpences= 3 * (moneyForFoodPerDay + moneyForSouvenirsPerDay )+ totalMoneyForHotel;
            double total = totalExpences + fuelCosts;
            Console.WriteLine($"Money needed: {total:F2}");
           
        }
    }
}
