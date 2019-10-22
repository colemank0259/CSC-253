using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberLibrary
{
    public class StandardMessages
    {
        public string PromptInfo
        {
            get
            {
                return "This program generates random numbers and writes them to a file.";
            }
        }

        public string PromptNumberCount
        {
            get
            {
                return "Enter the number of random numbers for the program to write to the file: ";
            }
        }

        public string PromptFileComplete
        {
            get
            {
                return "The file has been created!";
            }
        }
    }
}
