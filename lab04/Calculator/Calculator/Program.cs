using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string yesNo;

            do
            {
                Console.Clear();

                // Ask which operation?
                string operation;
                do
                {
                    Console.Write("Which operation do you want? (+ or -) ");
                    operation = Console.ReadLine();
                }
                while (operation != "+" && operation != "-");

                // Get first number
                double userNum1;
                bool valid;
                do
                {
                    Console.Write("Enter first number: ");
                    valid = double.TryParse(Console.ReadLine(), out userNum1);
                }
                while (valid == false);

                // Get second number
                double userNum2;
                do
                {
                    Console.Write("Enter second number: ");
                    valid = double.TryParse(Console.ReadLine(), out userNum2);
                }
                while (valid == false);

                // Calulate total
                double userTotal;
                if (operation == "+")
                {
                    userTotal = userNum1 + userNum2;
                }
                else
                {
                    userTotal = userNum1 - userNum2;
                }
                Console.WriteLine("{0} + {1} = {2}", userNum1, userNum2, userTotal);

                // Should we repeat?
                do
                {
                    Console.Write("Do you want another go (y/n): ");
                    yesNo = Console.ReadLine().ToLower();
                }
                while (yesNo != "y" && yesNo != "n");

            }
            while (yesNo == "y");

        }
    }
}
