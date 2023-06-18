using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIEZIENIEgra
{
    internal class Torch
    {
        private bool LightOn { get; set; }
        public Torch()
        {
            LightOn = false;
        }
        public bool SwitchOnOff()
        {
            if (Player.HasTorch == true)
            {
                LightOn = !LightOn;
                if (LightOn == false)
                {
                    Console.WriteLine("Torch is turned off.");
                }
                else if (LightOn == true)
                {
                    Console.WriteLine("Torch is turned on.");
                }
                return LightOn;
            }
            else
            {
                Console.WriteLine("You don't have torch.");
                return false;
            }
        }
    }
}
