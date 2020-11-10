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
            else
            {
                Console.WriteLine("You are NOT in your twenties");
            }

            Console.ReadLine();

        }
    }
}
