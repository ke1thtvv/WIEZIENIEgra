using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIEZIENIEgra
{
    internal class Player
    {
        public static bool HasTorch { get; set; }
        public static bool HasScewdriver { get; set; }
        
        public Player()
        {
            HasTorch = false;
            HasScewdriver = false;
        }
        public void PickUpTorch()
        {
            HasTorch = true;
            Console.WriteLine("(You got lighter)");
        }
        public void PickUpCrowBar()
        {
            HasScewdriver = true;
            Console.WriteLine("(You got screwbar)");
        }
    }
}
