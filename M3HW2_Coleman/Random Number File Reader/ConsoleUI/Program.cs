using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* 10/03/19
* CSC 253
* Kevin Coleman
* This program reads data from the Random Numbers file.
*/
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            do
            {
                ReadFileLibrary.StandardMessages myMessages = new ReadFileLibrary.StandardMessages();

                Console.WriteLine(myMessages.PromptInfo);

                ReadFileLibrary.RandomNumberClass myClass = ReadFileLibrary.ClassFromLoadedFile.CreateClass();

                Console.WriteLine();

                Console.ReadLine();
            } while (run == true);

            
        }
    }
}
