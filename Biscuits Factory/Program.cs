using System;

namespace Biscuits_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            double biscuitsDayWorker = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double biscuitsOtherFactoryProduction = double.Parse(Console.ReadLine());

            double biscuitsPerMonth = 0;
            for (int i = 0; i < 30; i++)
            {
                if (i%3==0)
                {
                    biscuitsPerMonth += Math.Floor((biscuitsDayWorker * workers) * 0.75);
                }
                else
                {
                    biscuitsPerMonth += Math.Floor(biscuitsDayWorker * workers);
                }
            }
            var result = Math.Abs(biscuitsPerMonth - biscuitsOtherFactoryProduction);
            var percentDiference = (result / biscuitsOtherFactoryProduction) * 100;
            Console.WriteLine($"You have produced {biscuitsPerMonth} biscuits for the past month.");
            if (biscuitsOtherFactoryProduction>biscuitsPerMonth)
            {
                Console.WriteLine($"You produce {percentDiference:f2} percent less biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percentDiference:f2} percent more biscuits.");
            }
        }
    }
}
