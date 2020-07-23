using System;

namespace Sushi
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameRestourant = Console.ReadLine();
            string sushiKindOf = Console.ReadLine();
            
            double portions = double.Parse(Console.ReadLine());
            string order = Console.ReadLine();


            double priceOfOrder = 0;
            double discountedPrice = 0;

            if (nameRestourant == "sashimi")
            {
                if (order == "Y")
                {
                    switch (sushiKindOf)
                    {
                        case "Sushi Zone":
                            discountedPrice += portions*4.99;
                            break;
                        case "Sushi Time":
                            discountedPrice += portions*5.49;
                            break;
                        case "Sushi Bar":
                            discountedPrice +=portions* 5.25;
                            break;
                        case "Asian Pub":
                            discountedPrice +=portions* 4.50;
                            break;

                    }
                }
                else
                {
                    switch (sushiKindOf)
                    {
                        case "Sushi Zone":
                            priceOfOrder +=portions* 4.99;
                            break;        
                        case "Sushi Time":
                            priceOfOrder +=portions* 5.49;  
                            break;           
                        case "Sushi Bar":
                            priceOfOrder +=portions* 5.25;
                            break;
                        case "Asian Pub":
                            priceOfOrder += portions*4.50;
                            break;
                    }
                }
            }
            else if (nameRestourant == "maki")
            {
                if (order == "Y")
                {
                    switch (sushiKindOf)
                    {
                        case "Sushi Zone":
                            discountedPrice +=portions* 5.29;
                            break;              
                        case "Sushi Time":      
                            discountedPrice +=portions* 4.69;
                            break;
                        case "Sushi Bar":
                            discountedPrice +=portions* 5.55;
                            break;
                        case "Asian Pub":
                            discountedPrice +=portions* 4.80;
                            break;

                    }
                }
                else
                {
                    switch (sushiKindOf)
                    {
                        case "Sushi Zone":
                            priceOfOrder +=portions* 5.29;
                            break; 
                        case "Sushi Time":        
                            priceOfOrder +=portions * 4.69;  
                            break;                  
                        case "Sushi Bar":
                            priceOfOrder +=portions* 5.55;
                            break;
                        case "Asian Pub":
                            priceOfOrder +=portions* 4.80;
                            break;
                    }
                }
            }
            else if (nameRestourant == "uramaki")
            {
                if (order == "Y")
                {
                    switch (sushiKindOf)
                    {
                        case "Sushi Zone":
                            discountedPrice += portions * 5.99 ;
                            break; 
                        case "Sushi Time":                               
                            discountedPrice += portions * 4.49 ;    
                                                                         
                            break;
                        case "Sushi Bar":
                            discountedPrice += portions * 6.25 ;
                            break;
                        case "Asian Pub":
                            discountedPrice += portions * 5.50 ;
                            break;

                    }
                }
                else
                {
                    switch (sushiKindOf)
                    {
                        case "Sushi Zone":
                            priceOfOrder += portions * 5.99;
                            break; 
                        case "Sushi Time":                         
                            priceOfOrder += portions * 4.49;        
                            break;                                 
                        case "Sushi Bar":
                            priceOfOrder += portions * 6.25;
                            break;
                        case "Asian Pub":
                            priceOfOrder += portions * 5.50;
                            break;
                    }
                }
            }
            else if (nameRestourant == "temaki")
            {
                if (order == "Y")
                {
                    switch (sushiKindOf)
                    {
                        case "Sushi Zone":
                            discountedPrice += portions * 4.29 ;
                            break;
                        case "Sushi Time":
                            
                            discountedPrice += portions * 5.19 ;     
                            break;                                        
                        case "Sushi Bar":                                 
                            discountedPrice += portions * 4.75 ;
                            break;
                        case "Asian Pub":
                            discountedPrice += portions * 5.50 ;
                            break;

                    }
                }
                else
                {
                    switch (sushiKindOf)
                    {
                        case "Sushi Zone":
                            priceOfOrder += portions * 4.29; 
                            break;                           
                        case "Sushi Time":                   
                            priceOfOrder += portions * 5.19;
                            break;
                        case "Sushi Bar":
                            priceOfOrder += portions * 4.75;
                            break;
                        case "Asian Pub":
                            priceOfOrder += portions * 5.50;
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"{nameRestourant} is invalid restaurant!");
                return;
            }
            if (order=="Y")
            {
                Console.WriteLine($"Total price: {Math.Ceiling( discountedPrice*1.2)} lv.");
            }
            else
            {
                Console.WriteLine($"Total price: {Math.Ceiling(priceOfOrder)} lv.");
            }
        }
    }
}


       
    

