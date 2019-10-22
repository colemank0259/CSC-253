using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* 9/01/19
* CSC 253
* Kevin Coleman
* This program predicts the approximate size of a population of organisms.
*/
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            do
            {
                Console.WriteLine("Enter 1 or 2 to select: ");
                Console.WriteLine("1. Run Program");
                Console.WriteLine("2. Exit");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    // Local varibles
                    double organisms = 0;
                    double dailyIncrease = 0;
                    int days = 0;

                    // Describe the program to the user
                    Console.WriteLine("This program predicts the approximate size of a population of organisms.");

                    // Get the starting number of organisms
                    Console.Write("Enter the starting number of organisms: ");
                    organisms = double.Parse(Console.ReadLine());

                    // Get the daily rate of population increase
                    Console.Write("Enter the daily rate of population increase as a percentage: ");
                    dailyIncrease = double.Parse(Console.ReadLine());
                    dailyIncrease = dailyIncrease * .01;

                    // Get the number of days to multiply
                    Console.Write("Enter the number of days for the population to multiply > ");
                    days = int.Parse(Console.ReadLine());

                    // Calculate the population increase and display the output

                    for (int index = 1; index <= days; index++)
                    {
                        Console.WriteLine($"Day {index} Approximate Population: {organisms}");
                        organisms = organisms + (organisms * dailyIncrease);
                    }
                }
                else if (input == "2")
                {
                    exit = true;
                }
                else
                {
                    Console.Write("Not an Option");
                }

            } while (exit == false);
        }
    }
}
