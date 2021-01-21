using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up tax
            int tax = 20;
            Console.WriteLine("Tax is {0}", tax);
            // Read cost from user
            int cost;
            Console.Write("Enter cost between 1 and 100: ");
            cost = int.Parse(Console.ReadLine());
            // Check the user's input **Not good validation! For testing only**
            if (cost > 1 && cost < 100)
            {
                Console.WriteLine("Correct, your cost is between 1 and 100");
            }
            else
            {
                Console.WriteLine("You're not taking me seriously. I quit");
                Console.ReadLine();
                return; // This line quits the Main method, which exits the program
            }
            // Add tax to cost
            cost = cost = tax;
            Console.WriteLine("Total cost is {0}", cost);
        }
    }
}
