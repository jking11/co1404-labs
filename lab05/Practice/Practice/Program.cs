using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            int fileCount = 0;
            int fileSize;
            fileCount++;
            fileSize = 1000;
            Console.WriteLine("The number of files is {0}; the file size is [{1}].", fileCount, fileSize);

            Console.ReadKey();
            Console.Clear();

            Console.Write("What is your age? ");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("You are a child");
            }
            else if (age < 65)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are a pensioner");
            }

            Console.ReadKey();
            Console.Clear();

            Random r = new Random();
            int target = r.Next(1, 100);
            Console.WriteLine("I'm thinking of a number between 1 and 100");
            int guess = 0;
            do
            {
                Console.Write("What do you think it is? ");
                guess = int.Parse(Console.ReadLine());
                if (guess < target)
                {
                    Console.WriteLine("Too small!");
                }
                else if (guess > target)
                {
                    Console.WriteLine("Too big!");
                }
                else
                {
                    Console.WriteLine("That's correct!");
                }
            }
            while (guess != target);

            Console.ReadKey();
            Console.Clear();

            for (int a = 1; a <= 12; a++)
            {
                for (int b = 1; b <= 12; b++)
                {
                    Console.WriteLine("{0} x {1} = {2}", a, b, a * b);
                }
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("1. Jump to the beat");
            Console.WriteLine("2. Feel the heat");
            Console.WriteLine("3. Get up to get down");
            Console.WriteLine("4. Boogie-oogie-oogie");
            Console.WriteLine("5. Do the conga");
            int choice;
            bool valid;
            do
            {
                Console.Write("Which would you like to do? ");
                valid = int.TryParse(Console.ReadLine(), out choice);
            }
            while (valid && choice >= 1 && choice <= 5);

            Console.ReadKey();
            Console.Clear();

        }
    }
}
