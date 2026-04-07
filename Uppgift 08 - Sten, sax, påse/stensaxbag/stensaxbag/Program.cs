using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stensaxbag
{
    class Program
    {
        static void Main()
        {
            int spelarPengar = 100;
            int datorPengar = 100;
            Random slump = new Random();

            Console.WriteLine("Välommen till Sten Sax Påse!");
           

            while (spelarPengar > 0 && datorPengar > 0)
            {
                Console.WriteLine("\nDu har: " + spelarPengar + " kr");
                Console.WriteLine("Datorn har: " + datorPengar + " kr");
                
                Console.Write("Hur mycket vill du satsa? ");
                int satsning = int.Parse(Console.ReadLine());

                if (satsning > spelarPengar)
                {
                    Console.WriteLine("Du kan inte satsa mer än du har!");
                    continue;
                }

                
                Console.Write("Välj (1=Sten, 2=Sax, 3=Påse): ");
                int spelarVal = int.Parse(Console.ReadLine());

                
                int datorVal = slump.Next(1, 4);

                Console.WriteLine("Datorn valde: " + datorVal);

                
                if (spelarVal == datorVal)
                {
                    Console.WriteLine("Oavgjort!");
                }
                else if ((spelarVal == 1 && datorVal == 2) ||
                (spelarVal == 2 && datorVal == 3) ||
                (spelarVal == 3 && datorVal == 1))
                {
                    Console.WriteLine("Du vann!");
                    spelarPengar += satsning;
                    datorPengar -= satsning;
                }
                else
                {
                    Console.WriteLine("Du förlorade!");
                    spelarPengar -= satsning;
                    datorPengar += satsning;
                }
            }

            
            if (spelarPengar <= 0)
            {
                Console.WriteLine("\nDu förlorade spelet!");
            }
            else
            {
                Console.WriteLine("\nDu vann spelet!");
            }
        }
    }
}