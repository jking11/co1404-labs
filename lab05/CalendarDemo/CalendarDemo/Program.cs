using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int month = 1; month <= 12; month++)
            {

                int k = 1;
                int sofar = 1;

                for (int i = 1; i <= 31; i++)
                {
                    Console.Write("{0} ", k);
                    k++;

                }
                Console.WriteLine();


            }



            Console.ReadLine();
        }
    }
}
