using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius = 25;
            double fahrenheit = celcius * (9 / 5) + 32;
            Console.WriteLine("{0} C = {1} F", celcius, fahrenheit);
            Console.ReadKey();
        }
    }
}
