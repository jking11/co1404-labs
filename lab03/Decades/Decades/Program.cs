using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decades
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 20 && age <= 29)
            {
                Console.WriteLine("You are in your twenties");
            }
            else if (age >= 30 && age <= 39)
            {
                Console.WriteLine("You are in your thirties");
            }
            else if (age >= 40 && age <= 49)
            {
                Console.WriteLine("You are in your forties");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a teenager");
            }
            else
            {
                Console.WriteLine("You are not in a recognised age range");
            }

            Console.ReadLine();

        }
    }
}
