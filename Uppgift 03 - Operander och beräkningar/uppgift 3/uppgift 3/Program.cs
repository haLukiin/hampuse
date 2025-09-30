using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_3
{
    

    internal class Program
    {
        


        static void Greet(string name)
        {

            Console.WriteLine("Hello " );
        }


        static void Main(string[] args)
        {

            int current_year = 2025;
            int birth_year = 0;
            Console.WriteLine("Hello, whats your name?");
             string name = Console.ReadLine();
            Console.WriteLine("whats ur age?");
            int age;
            age = Convert.ToInt32(Console.ReadLine());         
          
            birth_year = current_year - age;

            Console.WriteLine("hello " + name + "\nborn " + birth_year );


        }
    }
}
