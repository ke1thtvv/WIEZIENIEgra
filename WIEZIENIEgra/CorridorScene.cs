using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIEZIENIEgra
{
    internal class CorridorScene : Scene
    {
        public CorridorScene(Game game) : base(game)
        {
        }

        public override void Run()
        {
            Dictionary<string, bool> screw = new Dictionary<string, bool>() { { "Top left screw", false }, { "Top right screw", false }, { "Bottom right screw", false }, { "Bottom left screw", false } };
            string prompt = @"
████████████████████████████████████████████
█O█______________________________________█O█
███______________________________________███
███______________________________________███
███______________________________________███
███______________________________________███
███______________________________________███
███______________________________________███
███______________________________________███
███______________________________________███
███______________________________________███
███______________________________________███
███______________________________________███
█O█______________________________________█O█
████████████████████████████████████████████

             Unscrew the screws          
";
            Menu menu = new Menu(prompt, screw);
            while (screw.Values.Any(v => v == false))
            {
                int Select = menu.RunScrew();
                screw.Remove(screw.ElementAt(Select).Key);          
            }
            
            Console.Clear();


        }
    }
}
