using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitForEnter();

            Console.WriteLine("How wide do you want the line? ");
            int width = ReadNumberFromUser();
            DrawHorizontalLine(width);
            
            WaitForEnter();
        }

        static void WaitForEnter()
        {
            Console.Write("Press 'enter' to continue...");
            Console.ReadLine();
        }

        static void DrawHorizontalLine(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("-");
            }
            Console.ReadLine();
        }

        static int ReadNumberFromUser()
        {
            int answer = int.Parse(Console.ReadLine());
            return answer;
        }

    }
}
