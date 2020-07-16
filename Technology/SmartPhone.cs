using System;
using System.Collections.Generic;
using System.Text;

namespace TechnologyNS
{
    class SmartPhone : Computer
    {
        public string Dimensions { get; set; }

        public SmartPhone(string name, bool onSale, double price, string dimensions) : base(name, onSale, price)
        {
            Dimensions = dimensions;
        }



        /// <summary>
        /// returns true if name is "iphone"
        /// </summary>
        public bool IsOverPiced()
        {
            throw new System.NotImplementedException();
        }
    }
}
