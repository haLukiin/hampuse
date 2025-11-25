using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_6
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int money = 100;            
            string köptaGlassar = "";
            while (money > 1)
            {
                Console.WriteLine("What Ice Cream Would you like to buy? \n 1. Piggelin (10 kr) \n 2. Magnum (20 kr) \n 3. Daimstrut (30 kr) ");
                int choice = Convert.ToInt32(Console.ReadLine());
                                
                Console.WriteLine($"Du har köpt{köptaGlassar} och har {money}kr kvar");
                
                switch (choice)
                {
                   case 1:
                        money -= 10;
                        köptaGlassar = köptaGlassar + " Piggelin";
                        Console.WriteLine("Du har valt piggelin");
                        break;  
                   case 2:
                        money -= 20;
                        köptaGlassar = köptaGlassar + " Magnum";
                        Console.WriteLine("Du har valt Magnum");
                        break;
                   case 3:
                        money -= 30;
                        köptaGlassar = köptaGlassar + " Daimstrut";
                        Console.WriteLine("Du har valt Daimstrut");
                        break;  

                    default: Console.WriteLine("Ogiltigt Alternativ");
                        break;
                }

            }
            while (money < 1)
            {
                Console.WriteLine("Tyvärr är dina pengar slut, återkom gärna en annan dag");
                Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
