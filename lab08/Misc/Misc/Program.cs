using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    class Program
    {

        const int SCREEN_WIDTH = 80;

        static void Main(string[] args)
        {

            Console.Write("Choose a character: Warrior, Mage, Scout or Adventurer: ");
            string characterType = Console.ReadLine().ToLower();

            int health;
            int strength;
            int magic;
            switch (characterType)
            {
                case "warrior":
                    health = 100;
                    strength = 125;
                    magic = 50;
                    break;
                case "mage":
                    health = 100;
                    strength = 50;
                    magic = 125;
                    break;
                case "scout":
                    health = 125;
                    strength = 80;
                    magic = 80;
                    break;
                default: // Adventurer and any other input goes here (no validation here)
                    health = 100;
                    strength = 100;
                    magic = 100;
                    break;
            }
            Console.WriteLine("You begin with {0} health", health);
            Console.WriteLine("Your have {0} strength and {1} magic", strength, magic);
            Console.ReadLine();

            DrawHorizontalLine();
            Console.WriteLine("Testing");
            DrawHorizontalLine();
            DrawCentreAlignedText("Testing");
            DrawHorizontalLine();
            DrawRightAlignedText("Testing");
            DrawHorizontalLine();

            Console.ReadLine();
        }

        static void DrawHorizontalLine()
        {
            for (int i = 0; i < SCREEN_WIDTH; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        static void DrawRightAlignedText(string text)
        {
            int leftSpaces = SCREEN_WIDTH - text.Length;
            for (int i = 0; i < leftSpaces; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(text);
        }

        static void DrawCentreAlignedText(string text)
        {
            int leftSpaces = (SCREEN_WIDTH - text.Length) / 2;
            for (int i = 0; i < leftSpaces; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(text);
        }

    }
}
