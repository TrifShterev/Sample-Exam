using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopingList = Console.ReadLine().Split("!" ,StringSplitOptions.RemoveEmptyEntries).ToList();

            string input;
            while ((input=Console.ReadLine())!="Go Shopping!")
            {
                string[] command = input.Split();
                string item = command[1];
               
              
                


                    switch (command[0])
                    {
                        case "Urgent":
                        if (!(shopingList.Contains(item))) {
                            shopingList.Insert(0, item);
                        }
                            
                            break;
                        case "Unnecessary":
                        if (shopingList.Contains(item))
                        { shopingList.Remove(item); }
                            break;
                        case "Correct":
                        if (shopingList.Contains(item))
                        {
                            string newItem = command[2];
                           
                            shopingList.Insert(shopingList.IndexOf(item), newItem);
                            shopingList.Remove(item);
                        }
                            break;
                        case "Rearrange":
                        if (shopingList.Contains(item))
                        {
                            shopingList.Remove(item);
                            shopingList.Add(item);
                            
                        }
                        break;  
                    }
                
            }
            Console.WriteLine(String.Join(", ",shopingList));





        }
    }
}
