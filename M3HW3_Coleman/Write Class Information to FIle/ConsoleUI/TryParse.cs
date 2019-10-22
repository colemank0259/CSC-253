using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class TryParse
    {
        public static int IntParse(string variable)
        {
            int number;

            if (int.TryParse(variable, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Not a valid response. Must be greater than 0.");
                return 0;
            }
        }
    }
}
