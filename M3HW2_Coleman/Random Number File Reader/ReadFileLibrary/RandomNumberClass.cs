using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileLibrary
{
    public class RandomNumberClass
    {
        public RandomNumberClass()
        {
            RandomNumber = 0;
            NumberCount = 0;
        }

        public RandomNumberClass(int randomNumber, int numberCount)
        {
            RandomNumber = randomNumber;
            NumberCount = numberCount;
        }

        public int RandomNumber { get; set; }
        public int NumberCount { get; set; }
    }
}
