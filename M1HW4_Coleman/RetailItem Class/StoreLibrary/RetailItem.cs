using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class RetailItem
    {
        private string _description;
        private int _unitsOnHand;
        private decimal _price;

        public RetailItem()
        {
            Description = "";
            UnitsOnHand = 0;
            Price = 0;
        }

        public RetailItem (string description, int unitsOnHand, decimal price)
        {
            Description = description;
            UnitsOnHand = unitsOnHand;
            Price = price;
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public int UnitsOnHand
        {
            get
            {
                return _unitsOnHand;
            }

            set
            {
                _unitsOnHand = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }
    }
}
