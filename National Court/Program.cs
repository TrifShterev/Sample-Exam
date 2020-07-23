using System;

namespace National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1PerHour = int.Parse(Console.ReadLine());
            int employee2PerHour = int.Parse(Console.ReadLine());
            int employee3PerHour = int.Parse(Console.ReadLine());
            int totalPeople = int.Parse(Console.ReadLine());

            int totalAnsweredPeoplePerHour = employee1PerHour + employee2PerHour + employee3PerHour;
            

            int hoursOfAnswering = 0;
           
                while (totalPeople > 0)
                {

                    totalPeople -= totalAnsweredPeoplePerHour;
                hoursOfAnswering++;
                if (hoursOfAnswering%4==0)
                {
                    totalPeople += totalAnsweredPeoplePerHour;
                    
                }
                   



                }
            
            Console.WriteLine($"Time needed: { hoursOfAnswering}h.");
        }
    }
}
