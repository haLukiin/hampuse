using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgiftfem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saldo = 100;

            while (saldo > 0)
            {
                Console.WriteLine("What ice cream would you like to buy?");
                Console.WriteLine("You have " + saldo + " kr");
                Console.WriteLine("1. Piggelin (10 kr)");
                Console.WriteLine("2. Magnum (20 kr)");
                Console.WriteLine("3. DaimStrut (30 kr)");
                Console.Write("Your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    saldo -= 10;
                    Console.WriteLine("You have " + saldo + " kr left.");
                }
                else if (choice == 2)
                {
                    saldo -= 20;
                    Console.WriteLine("You have " + saldo + " kr left.");
                }
                else if (choice == 3)
                {
                    saldo -= 30;
                    Console.WriteLine("You have " + saldo + " kr left.");
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }

            Console.WriteLine("You're out of money.");
            Environment.Exit(0);
        }
    }
}
