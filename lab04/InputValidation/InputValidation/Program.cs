using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValidation
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ask a question
            string answer;
            do
            {
                Console.Write("Are you sure you want to delete the record? (y/n) ");
                answer = Console.ReadLine().ToLower();

                if (answer != "y" && answer != "n")
                {
                    Console.WriteLine("Sorry, you must answer 'y' or 'n'.");
                }

            }
            while (answer != "y" && answer != "n");
            
            // Write an appropriate response
            if (answer == "y")
            {
                Console.WriteLine("Record deleted.");
            }
            else
            {
                Console.WriteLine("Record was not deleted.");
            }

            // Pause
            Console.ReadLine();
            Console.Clear();

            // Ask another question
            int year;
            bool valid;
            do
            {
                Console.Write("What year were you born? ");
                valid = int.TryParse(Console.ReadLine(), out year);

                if (valid == false || year < 1 || year > 2020)
                {
                    Console.WriteLine("Sorry, please enter a valid year.");
                }

            }
            while (valid == false || year < 1 || year > 2020);

            // Respond
            Console.WriteLine("You are around {0} years old.", 2020 - year);

            // Pause
            Console.ReadLine();
            Console.Clear();

        }
    }
}
