using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* 9/29/19
* CSC 253
* Kevin Coleman
* This program generates random numbers and writes them to a file.
*/
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            // Local variables
            RandomNumberLibrary.StandardMessages myMessages = new RandomNumberLibrary.StandardMessages();
            RandomNumberLibrary.RandomNumberClass myRandomNumber = new RandomNumberLibrary.RandomNumberClass();
            Random rand = new Random();

            do
            {
                // Display the program description
                Console.WriteLine(myMessages.PromptInfo);

                bool isNumber = false;

                do
                {
                    // Get the number of random numbers for the file to hold
                    Console.Write(myMessages.PromptNumberCount);
                    int input = TryParse.IntParse(Console.ReadLine());

                    if (input > 0)
                    {
                        myRandomNumber.NumberCount = input;
                        isNumber = true;
                    }
                } while (isNumber == false);

                // Write the random number(s) to the file
                for (int count = 1; count <= myRandomNumber.NumberCount; count++)
                {
                    myRandomNumber.RandomNumber = rand.Next(1, 100);
                    RandomNumberLibrary.WriteFile.CreateFile(myRandomNumber);
                    
                }

                // Display confirmation that the file was written
                Console.WriteLine(myMessages.PromptFileComplete);

            } while (run == true);
        }
    }
}
