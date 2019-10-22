using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/**
 * Kevin Coleman
 * 10/06/19
 * CSC 253
 * This program will create a Person Class from user information read from a file
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

            do
            {
                

                // Display the program description
                Console.WriteLine(myMessages.PromptInfo);

                // Consume next line for appearance
                Console.WriteLine();

                // Get the information by reading the file
                PersonClassLibrary.Person person = CreateClass();

                Console.ReadLine();
            } while (run == true);
        }

        public static PersonClassLibrary.Person CreateClass()
        {
            // Local variables
            int personCount = 0;
            string firstName = null;
            string lastName = null;
            int age = 0;

            try
            {
                StreamReader inputFile;

                inputFile = File.OpenText("UserInformation.txt");

                while (!inputFile.EndOfStream)
                {
                    personCount++;
                    Console.WriteLine($"Person {personCount}:");
                    firstName = inputFile.ReadLine();
                    lastName = inputFile.ReadLine();
                    age = int.Parse(inputFile.ReadLine());
                    Console.WriteLine($"{firstName} {lastName}, age {age}");
                    Console.WriteLine("");
                }

                inputFile.Close();

                PersonClassLibrary.Person person = new PersonClassLibrary.Person(firstName, lastName, age);

                return person;
            }
            catch (Exception ex)
            {
                return new PersonClassLibrary.Person("File Read Error", "File Read Error", 0);
            }
        }
    }
}
