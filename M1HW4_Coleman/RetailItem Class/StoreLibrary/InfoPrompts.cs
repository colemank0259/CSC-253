using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class InfoPrompts
    {
        public static void Description()
        {
            Console.Write("Enter the description of the product > ");
        }

        public static void UnitsOnHand()
        {
            Console.Write("Enter the number of units of the product available on hand > ");
        }

        public static void Price()
        {
            Console.Write("Enter the retail price of the product in dollars > $");
        }
    }
}
