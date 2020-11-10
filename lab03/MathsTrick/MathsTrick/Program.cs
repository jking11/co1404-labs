using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTrick
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number, any number: ");
            int userNumber = int.Parse(Console.ReadLine());
            int startNumber = userNumber;

            Console.WriteLine("Now add 1...");
            userNumber += 1;
            Console.WriteLine("You now have {0}... (press return)", userNumber);
            Console.ReadKey();
            
            Console.WriteLine("Double it...");
            userNumber *= 2;
            Console.WriteLine("You now have {0}... (press return)", userNumber);
            Console.ReadKey();
            
            Console.WriteLine("Now add 4...");
            userNumber += 4;
            Console.WriteLine("You now have {0}... (press return)", userNumber);
            Console.ReadKey();

            Console.WriteLine("Now divide by 2...");
            userNumber /= 2;
            Console.WriteLine("You now have {0}... (press return)", userNumber);
            Console.ReadKey();
            
            Console.WriteLine("Now take away the number you first thought of...");
            userNumber -= startNumber;
            Console.WriteLine("You now have three : {0}", userNumber);
            Console.ReadKey();

        }
    }
}
