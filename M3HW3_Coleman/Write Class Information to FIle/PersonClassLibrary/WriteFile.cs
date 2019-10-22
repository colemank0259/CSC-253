using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PersonClassLibrary
{
    public class WriteFile
    {
        public static void CreateFile(Person person)
        {
            try
            {
                StreamWriter outputFile;

                outputFile = File.AppendText("UserInformation.txt");

                outputFile.WriteLine(person.FirstName);
                outputFile.WriteLine(person.LastName);
                outputFile.WriteLine(person.Age);

                outputFile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: The information has NOT been written to the file. Try again.");
            }
        }
    }
}
