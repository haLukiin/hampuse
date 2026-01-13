using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace textSpelHampus
{
    internal class Program
    {
    
        static void Main(string[] args)
        {

            Random rnd = new Random();

            string playerName = "";
            int playerHP = 100;
            string weaponType = "";
            int weaponChoice;
            int pMaxDamage;
            int pMinDamage;
            int playerDamage;
            int enemyHP = 100;
            int eMaxDamage = 10;
            int eMinDamage = 5;
            int enemyDamage;
            
            WriteLine("Welcome Adventurer");
            WriteLine("This is a TextGame where you will choose 1 of 3 weapons to inflict damage on your enemy");
            WriteLine("You and the enemy have 100 hp each and the damage inflicted is randomized");
            WriteLine("First one to 0 loses");



        }
        
        static void WriteLine(string text, int sleepMs = 35)
        {
            bool skip = false;
            const int chunk = 10;
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);

                if (skip)
                {
                    if (i < text.Length - 1)
                        Console.Write(text.Substring(i + 1));
                    break;
                }

                int waited = 0;
                while (waited < sleepMs)
                {
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Enter)
                        {
                            skip = true;
                            if (i < text.Length - 1)
                                Console.Write(text.Substring(i + 1));
                            break;
                        }
                    }

                    int toSleep = Math.Min(chunk, sleepMs - waited);
                    Thread.Sleep(toSleep);
                    waited += toSleep;

                    if (skip) break;
                }

                if (skip) break;
            }

            Console.Write("\n");
        }
    }
}

