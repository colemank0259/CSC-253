using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* 9/02/19
* CSC 253
* Kevin Coleman
* This program calculates hospital charges.
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
                StandardMessages.DisplayOpeningMenu();

                // Declare varible to hold user input
                string input = Console.ReadLine();
                if (input == "1")
                {
                    // Local variables
                    HospitalLibrary.Charges charges = new HospitalLibrary.Charges();

                    // Display description of the program
                    StandardMessages.DisplayProgramDescription();

                    // Get charges from user and display the output
                    charges = HospitalLibrary.Work.GetCharges();

                } else if ( input == "2")
                {
                    exit = true;
                }
                else
                {
                    StandardMessages.DisplayOpeningMenuError();
                }
            } while (exit == false);
        }
    }
}
