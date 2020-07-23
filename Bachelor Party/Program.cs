using System;

namespace Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGuests = 0;
            double price = 0;
            double sumForArtist = double.Parse(Console.ReadLine());
            string people = Console.ReadLine();
            while (people!= "The restaurant is full")
            {
                int guests = int.Parse(people);
                 
                if (guests<5)
                {
                    price += guests * 100;
                }
                else if (guests>=5)
                {
                    price += guests * 70;
                }
                countGuests += guests;
                people = Console.ReadLine();
            }
            if (price>=sumForArtist)
            {
              Console.WriteLine($"You have {countGuests} guests and {price-sumForArtist} leva left.");
            }
            else
            {
          Console.WriteLine($"You have {countGuests} guests and {price} leva income, but no singer.");
            }
        }


    }
}
