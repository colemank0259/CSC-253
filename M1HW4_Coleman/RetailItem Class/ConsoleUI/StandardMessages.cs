using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class StandardMessages
    {
        public static void DisplayOpeningMenu()
        {
            Console.WriteLine("Enter 1 or 2 to select: ");
            Console.WriteLine("1. Run Program");
            Console.WriteLine("2. Exit");
        }
        public static void DisplayMenuError()
        {
            Console.WriteLine("You must enter 1 or 2.");
        }

        public static void DisplayIntError()
        {
            Console.WriteLine("You must enter an integer.");
        }

        public static void DisplayProgramDescription()
        {
            Console.WriteLine("This program stores information about retail items.");
        }
    }
}
