using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIEZIENIEgra
{
    internal class CreditsScene : Scene
    {
        public CreditsScene(Game game) : base(game)
        {
        }

        public override void Run()
        {
            string prompt = "Thanks for playing 'Prison Break'. I hope it was enjoyable\n" +
                "Would you like to play again?\n";
            string[] options = { "Yes", "No" };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();
            switch (selectedIndex)
            {
                case 0:
                    MyGame.Start();
                    break;
                case 1:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
