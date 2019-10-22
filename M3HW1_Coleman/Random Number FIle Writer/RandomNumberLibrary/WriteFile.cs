using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberLibrary
{
    public class WriteFile
    {
        public static void CreateFile(RandomNumberClass myRandomNumber)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.AppendText("RandomNumbers.txt");

                outputFile.WriteLine(myRandomNumber.RandomNumber);

                outputFile.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("File not created!");
            }
        }
    }
}
