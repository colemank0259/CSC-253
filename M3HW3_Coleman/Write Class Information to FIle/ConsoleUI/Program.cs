using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Kevin Coleman
 * 10/06/19
 * CSC 253
 * This program will create a Person Class with user information and then
 * write that class information to a file
 */
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Local variables
            bool run = true;
            PersonClassLibrary.StandardMessages myMessages = new PersonClassLibrary.StandardMessages();
            PersonClassLibrary.Person person = new PersonClassLibrary.Person();

            // Display the program description
            Console.WriteLine(myMessages.PromptInfo);

            do
            {
                // Consume the next line for appearance
                Console.WriteLine("");

                // Get the person's first name
                Console.Write(myMessages.PromptFirstName);
                person.FirstName = Console.ReadLine();

                // Get the person's last name
                Console.Write(myMessages.PromptLastName);
                person.LastName = Console.ReadLine();

                // Get the person's age
                bool isNumber = false;
                do
                {
                    Console.Write(myMessages.PromptAge);
                    int input = TryParse.IntParse(Console.ReadLine());

                    if (input > 0)
                    {
                        person.Age = input;
                        isNumber = true;
                    }
                } while (isNumber == false);

                // Write the information to a file
                PersonClassLibrary.WriteFile.CreateFile(person);

                // Confirm to the user whether the information was written to the file
                Console.WriteLine(myMessages.PromptFileComplete);

                // Consume the next line for appearance
                Console.WriteLine("");

            } while (run == true);
        }
    }
}
