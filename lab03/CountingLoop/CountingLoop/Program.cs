using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.ReadLine();

            counter = 0;
            while (counter < 100)
            {
                Console.Write(counter);
                Console.Write(", ");
                counter += 2;
            }

            Console.ReadLine();

            counter = 100;
            while (counter >= 0)
            {
                Console.Write(counter);
                Console.Write(", ");
                counter -= 2;
            }

            Console.ReadLine();

        }
    }
}
