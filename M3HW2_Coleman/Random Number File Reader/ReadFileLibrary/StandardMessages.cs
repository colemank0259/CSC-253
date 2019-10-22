using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileLibrary
{
    public class StandardMessages
    {
        public string PromptInfo
        {
            get
            {
                return "This program will load data from the Random Numbers file.";
            }
        }

        public static string DisplayRandomNumbers(RandomNumberClass myRandomNumbers)
        {
            return $"{myRandomNumbers.RandomNumber}";
        }
    }
}
