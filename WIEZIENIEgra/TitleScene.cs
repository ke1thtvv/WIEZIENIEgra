using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIEZIENIEgra
{
    internal class TitleScene : Scene
    {
        public TitleScene(Game game) : base(game)
        {
        }

        public override void Run()
        {
            string prompt = @"
   ▄███████▄    ▄████████  ▄█     ▄████████  ▄██████▄  ███▄▄▄▄        ▀█████████▄     ▄████████    ▄████████    ▄████████    ▄█   ▄█▄ 
  ███    ███   ███    ███ ███    ███    ███ ███    ███ ███▀▀▀██▄        ███    ███   ███    ███   ███    ███   ███    ███   ███ ▄███▀ 
  ███    ███   ███    ███ ███    ███    █▀  ███    ███ ███   ███        ███    ███   ███    ███   ███    █▀    ███    ███   ███ ██▀   
  ███    ███  ▄███▄▄▄▄██▀ ███    ███        ███    ███ ███   ███       ▄███▄▄▄██▀   ▄███▄▄▄▄██▀  ▄███▄▄▄       ███    ███  ▄█████▀    
▀█████████▀  ▀▀███▀▀▀▀▀   ███  ▀███████████ ███    ███ ███   ███      ▀▀███▀▀▀██▄  ▀▀███▀▀▀▀▀   ▀▀███▀▀▀     ▀███████████ ▀▀█████▄    
  ███        ▀███████████ ███           ███ ███    ███ ███   ███        ███    ██▄ ▀███████████   ███    █▄    ███    ███   ███ ██▄   
  ███          ███    ███ ███     ▄█    ███ ███    ███ ███   ███        ███    ███   ███    ███   ███    ███   ███    ███   ███ ▀███▄ 
 ▄████▀        ███    ███ █▀    ▄████████▀   ▀██████▀   ▀█   █▀       ▄█████████▀    ███    ███   ██████████   ███    █▀    ███   ▀█▀ 
               ███    ███                                                            ███    ███                             ▀         

";

            string[] options = { "Play", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    ConsoleUtils.Info1();
                    PlayGame();
                    break;
                case 1:
                    ExitGame();
                    break;
            }
        }

        private void PlayGame() 
        {
            MyGame.MyCorridorScene.Run();
        }
        private void ExitGame()
        {
            string prompt = "\nAre you sure you want to exit?\n";
            string[] options = { "Yes", "No" };
            Menu exitMenu = new Menu(prompt, options);
            int selectedIndex = exitMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Run();
                    break;

            }

        }
    }
}
