using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIEZIENIEgra
{
    internal class Vent
    {
        private bool Screwed { get; set; }
        public Vent(Player player)
        {
            Screwed = true;
        }
        private Dictionary<string, bool> screws;
        public bool ScrewedYesNo(Dictionary<string, bool> a, int b)
        {
            screws = a;
            if (Player.HasScewdriver == true)
            {
                //Screwed = !Screwed;
                screws[screws.ElementAt(b).Key] = !screws[screws.ElementAt(b).Key];
                if (Screwed == true)
                {
                    Console.WriteLine("Grid is screwed.");
                }
                else if (Screwed == false)
                {
                    Console.WriteLine("Grid is unscrewed.");
                }
                return Screwed;
            }
            else
            {
                Console.WriteLine("You don't have screwdriver.");
                return true;
            }
        }
    }
}
