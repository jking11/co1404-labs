using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedShapes
{
    class Program
    {
        static void Main(string[] args)
        {

            int height = 10;
            int width = 5;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
