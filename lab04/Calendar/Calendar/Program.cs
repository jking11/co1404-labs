using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ask for a year
            int year;

            bool valid;
            do
            {
                Console.Write("Enter a year: ");
                valid = int.TryParse(Console.ReadLine(), out year);
                if (valid == false)
                {
                    Console.WriteLine("Must be a number.");
                }
                else if (year < 1 || year > 9999)
                {
                    Console.WriteLine("Must be in range 1-9999.");
                }
            }
            while (valid == false || year < 1 || year > 9999);

            // Scan through the months
            for (int month = 1; month <= 12; month++)
            {
                Console.WriteLine();

                string monthName = new DateTime(year, month, 1).ToString("MMMM");
                Console.WriteLine("{0}", monthName);

                int numDays = DateTime.DaysInMonth(year, month);
                for (int day = 1; day <= numDays; day++)
                {
                    string shortDayName = new DateTime(year, month, day).ToString("ddd");
                    Console.Write("{0} {1}", shortDayName, day);
                    if (day < numDays)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();

            }

            // Pause
            Console.ReadLine();

        }
    }
}
