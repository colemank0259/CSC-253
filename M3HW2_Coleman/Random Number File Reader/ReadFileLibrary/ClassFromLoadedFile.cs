using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFileLibrary
{
    public class ClassFromLoadedFile
    {
        public static RandomNumberClass CreateClass()
        {
            // Local variables
            int randomNumber = 0;
            int numberCount = 0;
            int total = 0;
            try
            {
                StreamReader inputFile;

                inputFile = File.OpenText("RandomNumbers.txt");

                //string[] lines = inputFile.ReadLine().Split(' ');

                while (!inputFile.EndOfStream)
                {
                    randomNumber = int.Parse(inputFile.ReadLine());
                    Console.WriteLine(randomNumber);
                    numberCount++;
                    total += randomNumber;
                }
               
                Console.WriteLine($"Number of Random Numbers: {numberCount}");
                Console.WriteLine($"Total: {total}");

                inputFile.Close();

                RandomNumberClass myRandomNumber = new RandomNumberClass(randomNumber, numberCount);

                return myRandomNumber;
            }
            catch (Exception ex)
            {
                return new RandomNumberClass(0,0);
            }
        }
    }
}
