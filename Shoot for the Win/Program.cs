using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            string input = Console.ReadLine();
            int shotTargetsCount = 0;
            while (input != "End")
            {
                int index = int.Parse(input);
                if (index >= 0 && index < targets.Count )
                {
                    var currentTarget = targets[index];

                    for (int i = 0; i < targets.Count; i++)
                    {
                        
                        
                            if (i==index&&targets[i]!=-1)
                            {
                                targets[i] = -1;
                                shotTargetsCount++;
                            continue;
                            }
                        if (currentTarget>= targets[i] && targets[i] != -1)
                        {
                            targets[i] = targets[i] + currentTarget;
                        }
                        else if (currentTarget<targets[i] && targets[i] != -1)
                        {
                            targets[i] = targets[i] - currentTarget;
                        }



                        
                    }
                }
                input = Console.ReadLine();
            }
            Console.Write($"Shot targets: {shotTargetsCount} -> ");
            Console.WriteLine(String.Join(" ",targets));
        }
        
    }
}
