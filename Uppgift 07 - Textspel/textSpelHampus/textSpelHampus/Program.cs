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

            string playerName;
            int playerHp = 100;
            int enemyHp = 100;  


            WriteLine("Welcome Adventurer");
            WriteLine("This is a TextGame where you will choose 1 of 3 weapons to inflict damage on your enemy");
            WriteLine("You and the enemy have 100 hp each and the damage inflicted is randomized");
            WriteLine("First one to 0 loses");
            WriteLine("But first of all, what is your name?");
            playerName = Console.ReadLine();
            WriteLine("Welcome " + playerName + "! Now choose your weapon. \n 1.Axe \n 2.Sword \n 3.Hammer");
           
            string selectedWeapon = null;

            while (true)
            {
                string wChoice = (Console.ReadLine());
                if (wChoice == "axe" || wChoice == "Axe" || wChoice == "1")
                {
                    selectedWeapon = "Axe";
                    WriteLine("You have chosen the Axe!");
                    break;
                }
                else if (wChoice == "sword" || wChoice == "Sword" || wChoice == "2")
                {
                    selectedWeapon = "Sword";
                    WriteLine("You have chosen the Sword!");
                    break;
                }
                else if (wChoice == "hammer" || wChoice == "Hammer" || wChoice == "3")
                {
                    selectedWeapon = "Hammer";
                    WriteLine("You have chosen the Hammer!");
                    break;

                }
                else
                {
                    WriteLine("Invalid choice");

                }
            }

           
            while (playerHp > 0 && enemyHp > 0)
            {
                WriteLine($"Your HP: {playerHp}  -  Enemy HP: {enemyHp}");
                WriteLine("Press Enter to attack...");

                
                ConsoleKey key;
                do
                {
                    var k = Console.ReadKey(true);
                    key = k.Key;
                } while (key != ConsoleKey.Enter);

                
                int playerDamage;
                switch (selectedWeapon)
                {
                    case "Axe":
                        playerDamage = rnd.Next(8, 21);
                        break;
                    case "Hammer":
                        playerDamage = rnd.Next(10, 26);
                        break;
                    default: 
                        playerDamage = rnd.Next(5, 16); 
                        break;
                }

                enemyHp -= playerDamage;
                if (enemyHp < 0) enemyHp = 0;
                WriteLine($"You hit the enemy with your {selectedWeapon} for {playerDamage} damage! Enemy HP is now {enemyHp}.");

                if (enemyHp == 0)
                {
                    WriteLine("Enemy defeated! You win!");
                    break;
                }

                int enemyDamage = rnd.Next(5, 16); 
                playerHp -= enemyDamage;
                if (playerHp < 0) playerHp = 0;
                WriteLine($"Enemy strikes back for {enemyDamage} damage! Your HP is now {playerHp}.");

                if (playerHp == 0)
                {
                    WriteLine("You have been defeated...");
                    break;
                }
            }

            WriteLine("Press any key to exit.");
            Console.ReadKey(true);
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

