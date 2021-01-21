using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] weekdays = new string[7]
            {
                "Monday", 
                "Tuesday", 
                "Wednesday", 
                "Thursday", 
                "Friday", 
                "Saturday", 
                "Sunday"
            };

            // Days using separate commands
            Console.WriteLine(weekdays[0]);
            Console.WriteLine(weekdays[1]);
            Console.WriteLine(weekdays[2]);
            Console.WriteLine(weekdays[3]);
            Console.WriteLine(weekdays[4]);
            Console.WriteLine(weekdays[5]);
            Console.WriteLine(weekdays[6]);
            Console.WriteLine();

            // Days using loop
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(weekdays[i]);
            }
            Console.WriteLine();

            Console.ReadLine();
            Console.Clear();

            // Days starting with letter
            for (int i = 0; i < 7; i++)
            {
                string dayName = weekdays[i];
                if (dayName[0] == 'S' || dayName[0] == 'T')
                {
                    Console.WriteLine(dayName);
                }
            }
            Console.WriteLine();

            Console.ReadLine();
            Console.Clear();

            // User input
            Console.Write("How many numbers are you entering? ");
            int size = int.Parse(Console.ReadLine());
            
            int[] userArray = new int[size];
            for (int index = 0; index < size; index++)
            {
                Console.Write("Enter number: ");
                userArray[index] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("In reverse order... ");
            for (int index = size - 1; index >= 0; index--)
            {
                Console.Write("{0} ", userArray[index]);
            }
            Console.WriteLine();

            Console.WriteLine("Sorted... ");
            Array.Sort(userArray);
            for (int index = 0; index < size; index++)
            {
                Console.Write("{0} ", userArray[index]);
            }
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
