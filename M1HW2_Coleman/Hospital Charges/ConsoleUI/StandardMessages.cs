using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class StandardMessages
    {
        public static void DisplayOpeningMenu()
        {
            Console.WriteLine("Enter 1 or 2 to select: ");
            Console.WriteLine("1. Run Program");
            Console.WriteLine("2. Exit");
        }

        public static void DisplayOpeningMenuError()
        {
            Console.WriteLine("You must enter 1 or 2.");
        }

        public static void DisplayProgramDescription()
        {
            Console.WriteLine("This program calculates hospital charges.");

            // Consume the next line for appearance
            Console.WriteLine("");
        }
    }
}
