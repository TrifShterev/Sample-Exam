using System;
using System.Collections.Generic;
using System.Linq;

namespace School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> library = Console.ReadLine()
                .Split("&",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            while ((input=Console.ReadLine())!="Done")
            {
                string[] command = input.Split(" | ");
                string book1 = command[1];
                

                switch (command[0])
                {
                    case "Add Book":
                        if (!(library.Contains(book1)))
                        {
                            library.Insert(0, book1);
                        }
                          break;
                    case "Take Book":
                        if (library.Contains(book1))
                        {
                            library.Remove(book1);
                        }
                        break;
                    case "Swap Books":
                        string book2 = command[2];
                        if (library.Contains(book1)&&library.Contains(book2))
                        {
                            SwapMethod(book1, book2, library);
                           
                        }
                        break;
                    case "Insert Book":
                        library.Add(book1);
                        break;
                    case "Check Book":
                        int index = int.Parse(book1);
                        if (index<=library.Count-1&&index>=0)
                        {
                            Console.WriteLine(library.ElementAt(index));
                        }
                        break;
                }
            }
            Console.WriteLine(String.Join(", ", library));
        }
        static void SwapMethod(string element1, string element2, List<string> list)
        {
            var indexElement1 = list.IndexOf(element1);
            var indexElement2 = list.IndexOf(element2);
            var temp = list[indexElement1];
            list[indexElement1] = list[indexElement2];
            list[indexElement2] = temp;
        }
        
    }
}
