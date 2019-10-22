using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Work
    {
        public static RetailItem GetRetailItemInfo()
        {
            RetailItem retailItem = new RetailItem();

            // Get the item's description
            InfoPrompts.Description();
            retailItem.Description = Console.ReadLine();

            // Get the number of units on hand
            InfoPrompts.UnitsOnHand();
            retailItem.UnitsOnHand = int.Parse(Console.ReadLine());

            // Get retail price of the item
            InfoPrompts.Price();
            retailItem.Price = decimal.Parse(Console.ReadLine());

            return retailItem;
        }
    }
}
