using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* 8/29/19
* CSC 253
* Kevin Coleman
* This program creates, accelerates and brakes cars.
*/
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            GarageLibrary.Car car = new GarageLibrary.Car();

            do
            {
                // Display the opening menu
                StandardMessages.Menu();

                // Declare variable to hold user input
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // Consume the next line for appearance
                        Console.WriteLine("");

                        // Allow the user to create a car
                        car = GarageLibrary.Work.GetCar();

                        // Display the name of the car the user has created
                        Console.WriteLine($"You are driving a {car.Year} {car.Make}.");

                        // Consume the next line for appearance
                        Console.WriteLine("");

                        break;
                    case "2":
                        // Consume the next line for appearance
                        Console.WriteLine("");

                        // Accelerate the car the user has created
                        car.Accelerate();

                        // Display how much the car has accelerated
                        Console.WriteLine($"The {car.Year} {car.Make} is going {car.Speed} mile per hour.");

                        // Consume the next line for appearance
                        Console.WriteLine("");

                        break;
                    case "3":
                        // Consume the next line for appearance
                        Console.WriteLine("");

                        // Brake the car the user has created
                        car.Brake();

                        // Display how much the car has slowed down
                        Console.WriteLine($"The {car.Year} {car.Make} is going {car.Speed} mile per hour.");

                        // Consume the next line for appearance
                        Console.WriteLine("");

                        break;
                    case "4":
                        // Exit the program
                        exit = true;
                        break;
                }
            } while (exit == false);
        }
    }
}
