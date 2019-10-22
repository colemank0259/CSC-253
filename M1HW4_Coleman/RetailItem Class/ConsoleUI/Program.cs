using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* 9/01/19
* CSC 253
* Kevin Coleman
* This program stores information about retail items.
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

                // Declare variable to hold user input
                string input = Console.ReadLine();

                if (input == "1")
                {
                    // Constants
                    const int SIZE = 3;

                    // Local variables
                    StoreLibrary.RetailItem retailItem = new StoreLibrary.RetailItem();
                    StoreLibrary.RetailItem[] retailItems = new StoreLibrary.RetailItem[SIZE];

                    // Display description of the program
                    StandardMessages.DisplayProgramDescription();

                    // Consume the next line for appearance
                    Console.WriteLine("");

                    // Get the information for first retail item
                    retailItems[0] = StoreLibrary.Work.GetRetailItemInfo();

                    // Consume the next line for appearance
                    Console.WriteLine("");

                    // Get the information for first retail item
                    retailItems[1] = StoreLibrary.Work.GetRetailItemInfo();

                    // Consume the next line for appearance
                    Console.WriteLine("");

                    // Get the information for first retail item
                    retailItems[2] = StoreLibrary.Work.GetRetailItemInfo();

                    // Consume the next line for appearance
                    Console.WriteLine("");

                    // Display the output
                    for (int index = 0; index < retailItems.Length; index++)
                    {
                        Console.WriteLine($"Item {index + 1}");
                        Console.WriteLine("Description: " + retailItems[index].Description);
                        Console.WriteLine("Units on Hand: " + retailItems[index].UnitsOnHand);
                        Console.WriteLine("Price: $" + retailItems[index].Price.ToString("n2"));

                        // Consume the next line for appearance
                        Console.WriteLine("");
                    }


                }
                else if (input == "2")
                {
                    exit = true;
                }
                else
                {
                    // Display error message
                    StandardMessages.DisplayMenuError();
                }

            } while (exit == false);
        }
    }
}
