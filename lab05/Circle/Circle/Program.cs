using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {

            int radius;
            Console.Write("What is the radius of your circle? ");
            radius = int.Parse(Console.ReadLine());

            for (int row = -radius; row <= radius; row++)
            {
                for (int col = -radius; col <= radius; col++)
                {
                    double distance = Math.Sqrt(row * row + col * col);
                    if (distance <= radius) 
                    {
                        Console.Write("X");
                    } 
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
