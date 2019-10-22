using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* 9/16/19
* CSC 253
* Kevin Coleman
* This program counts the number of words in a string.
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
                // Ask user to either run the program or exit
                Console.WriteLine("1. Run the program");
                Console.WriteLine("2. Exit");
                Console.Write("Enter 1 or 2 to select: ");

                // Declare varible to hold user input
                string input = Console.ReadLine();

                if (input == "1")
                {
                    // Local variables
                    string[] words;
                    int wordCount;

                    // Consume the next line for appearance
                    Console.WriteLine("");

                    // Display description of the program
                    Console.WriteLine("This program counts the number of words in a string.");

                    // Consume the next line for appearance
                    Console.WriteLine("");

                    // Get the string from the user
                    Console.Write("Enter a sentence  or phrase: ");
                    input = Console.ReadLine();

                    // Consume the next line for appearance
                    Console.WriteLine("");

                    // Separate the words from the user's input in an array
                    words = input.Split(null);

                    // Count the number of words in the user's string
                    wordCount = words.Length;
                    Console.WriteLine($"Number of Words: {wordCount}");

                    // Consume the next line for appearance
                    Console.WriteLine("");

                }
                else if (input == "2")
                {
                    exit = true;
                }
                else
                {
                    // Consume the next line for appearance
                    Console.WriteLine("");

                    // Display the error message
                    Console.WriteLine("ERROR: You must enter 1 or 2.");

                    // Consume the next line for appearance
                    Console.WriteLine("");
                }

            } while (exit == false);
        }
    }
}
