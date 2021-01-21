using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            // Count from 1 to 10
            for (int n = 1; n <= 10; n++)
            {
                Console.Write("{0}", n);
                if (n < 10)
                {
                    Console.Write(", ");
                }
            }

            // Pause
            Console.ReadLine();
            Console.Clear();

            // Show odd numbers from 9 to 49
            for (int n = 1; n <= 49; n += 2)
            {
                Console.Write("{0}", n);
                if (n < 49)
                {
                    Console.Write(", ");
                }
            }

            // Pause
            Console.ReadLine();
            Console.Clear();

            // Show even numbers from 100 to 50
            for (int n = 100; n > 50; n -= 2)
            {
                Console.Write("{0}", n);
                if (n > 52)
                {
                    Console.Write(", ");
                }
            }

            // Pause
            Console.ReadLine();
            Console.Clear();

        }
    }
}
