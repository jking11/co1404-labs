using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedNumberGrid
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("{0:00} ", counter);
                    counter++;
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
