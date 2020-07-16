using System;
using System.Collections.Generic;
using System.Text;


namespace TechnologyNS
{
    class Computer
    {
        public bool OnSale { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        /// <summary>
        /// **Static**
        /// </summary>
        public static int HowManySold { get; set; }

        public Computer(string name, bool onSale, double price)
        {
            OnSale = onSale;
            Name = name;
            Price = price;
        }

        /// <summary>
        /// returns "Good Deal" if onSlae is true
        /// </summary>
        public string IsOnSale()
        {
            if (OnSale)
            {
                return "Good Deal";
            }
            else
            {
                return "Regular Price";
            }
        }

        /// <summary>
        /// returns new price after 10% is taken off from price
        /// </summary>
        public double ApplyEmployeeDiscount()
        {
            return Price - Price*0.1;
        }

    }
}
