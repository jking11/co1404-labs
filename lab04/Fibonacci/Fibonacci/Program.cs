using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            // n1, n2 are two adjacent values in the series, starting at 0, 1

            // Method 1 -- sequential calculations
            int n1 = 0;
            int sum;
            for (int n2 = 1; n1 < 1000; sum = n1 + n2, n1 = n2, n2 = sum)
            {
                Console.Write("{0}, ", n1);
            }
            Console.WriteLine();

            // Method 2 -- this is the "comma operator" method that Dan mentions in his sheet
            n1 = 0;
            for (int n2 = 1; n1 < 1000; (n1, n2) = (n2, n1 + n2))
            {
                Console.Write("{0}, ", n1);
            }
            Console.WriteLine();

            // Method 3 -- taking advantage of operator precedence
            n1 = 0;
            for (int n2 = 1; n1 < 1000; n2 = n1 + (n1 = n2))
            {
                Console.Write("{0}, ", n1);
            }
            Console.WriteLine();

            // Pause
            Console.ReadLine();

        }
    }
}
