using System;
using System.Collections.Generic;
using System.Text;

namespace TechnologyNS
{
    class Laptop : Computer
    {
        public bool TwoInOne {get; set;}

        public Laptop(string name, bool onSale, double price, bool twoInOne) : base(name, onSale, price)
        {
            TwoInOne = twoInOne;
        }



        /// <summary>
        /// returns "Hurry up! good deal here" if onSale and twoInOne are true
        /// </summary>
        public bool GoodDeal()
        {
            if (TwoInOne && OnSale)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
