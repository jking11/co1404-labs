using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthYear
{
    class Program
    {
        static void Main(string[] args)
        {

            int year;
            string inputString;
            
            Console.Write("Enter your year you were born: ");
            inputString = Console.ReadLine();
            year = int.Parse(inputString);
            
            if (year % 4 == 0)
            {
                Console.WriteLine("You were born in a leap year");
            }
            else
            {
                Console.WriteLine("You were not born in a leap year");
            }

            if (year == 1969)
            {
                Console.WriteLine("You were born in the same year as me");
            }
            else
            {
                Console.WriteLine("You weren't born in the same year as me");
            }

            Console.ReadLine();

        }
    }
}
