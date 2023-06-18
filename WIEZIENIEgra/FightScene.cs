using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WIEZIENIEgra
{
    internal class FightScene : Scene
    {
        public FightScene(Game game) : base(game)
        {
        }
        public override void Run()
        {
            string prompt = @"
Fight has started, in a fraction of second he started attackin.
You see he's gonna try to punch you with left hand.

        |||||||||
        | _   _ |                         
       (  ' _ '  )
        |  ___  |
         |_____|                   
  _______/     \_______         
 /                     \               
|   |\             /|   |
|   ||  .       .  ||   |     
|   / \           / \   |
\  |   | |_ | _| |   |  /     
|==|   | |_ | _| |   |==|
/  /_ _|_|__|__|_|_ _\  \
|___| /            \|___|
      |     |      |
      |     |      |
      |MEX  |   MEX|         
      |     |      |           
      ""|""""|""""""|          
       |  |   |  |      
       |  |   |  |
      /   )   (   \
     Ooooo     ooooO
";
            string[] attacks = { "Dodge back, then right hook", "Block his punch (low chance of succes)" };
            Menu menu = new Menu(prompt, attacks);
            int SelectedIndex = menu.Run();
            switch (SelectedIndex)
            {
                case 0:
                    Console.Clear();
                    AttackOne();                  
                    break;
                case 1:
                    Console.Clear();
                    Lose();
                    ConsoleUtils.BackToDialog();
                    MyGame.MyCreditsScene.Run();
                    break;
            }            
        }

        private void Lose()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string death = @"
   ___             ___
  //  \           //  \
 //    )         //    )
 ||  _/          ||  _/                   __
 ||  \\_,&__     ||  \\                  (  \
 )|   ^  /  ``---,_\_/ &                 _>  )
 \|___,__\__       `\_  \_              (   /
            \__,-,    `\__\_             >_/
                 \_    /    `\_         / /
                   \_ /        \__    _/ /
                     `\          `\_,/  /
                 _     \__,-,  `   (_  /
              __( \        ,)__   _/ \/
             /     `-,___,-'   \_(  O `\
             \     /_|___   ____/ \  \ =}
              `---'      `-'       \_=_/{}
                                  .{}{}{}{.
                                  {}{}{}{}{
                                  }{}{}{}{}
                                  `}{}{}{}'
                                   `}{}{}'

You got knockouted, after that they found out, that you lied them and they cut you and you bleeded to death";
            Console.WriteLine(death);
        }

        private void AttackOne()
        {
            string fight = @"
                /////'
               '  # o
               C   - |
  ___          '  =__'        ___
 (` _ \_       |   |        _/  ')
  \  (__\  ,---- _ |----.  /__)- |
   \__  ( (           /  ) )  __/
     |_X_\/ \.   #  _.|  \/_X_|
       |  \ /(   /    /\ /  |
        \ /  (  ,    /  \ _/
             /______/
            [:::::::]
           /*%*%*%*%*\
           >%*%#%*%*%|
          /%*%*#*%*%*\
         ######^######

You hit him. He's barely holding on and he's trying to kick you.
";
            string[] attacks2 = { "Try to hit him with your left hand", "Catch his leg and try to knock him down" };
            Menu menu1 = new Menu(fight, attacks2);
            int SelectedIndex1 = menu1.Run();
            switch (SelectedIndex1)
            {
                case 0:
                    Console.Clear();
                    AttackTwo();
                    break;
                case 1:
                    Console.Clear();
                    Win();
                    ConsoleUtils.BackToDialog();
                    ConsoleUtils.Info4();
                    MyGame.MyCanteenScene.Run();
                    break;
            }

        }

        private void AttackTwo()
        {
            string fight2 = @"
                /////'
               '  # o
               C   - |
  ___          '  =__'        ___
 (` _ \_       |   |        _/  ')
  \  (__\  ,---- _ |----.  /__)- |
   \__  ( (           /  ) )  __/
     |_X_\/ \.   #  _.|  \/_X_|
       |  \ /(   /    /\ /  |
        \ /  (  ,    /  \ _/
             /______/
            [:::::::]
           /*%*%*%*%*\
           >%*%#%*%*%|
          /%*%*#*%*%*\
         ######^######

He was faster and kicked you. Now he's trying to finish you.
";
            string[] attacks3 = { "Run into him on your last legs", "Cower your head with hands", };
            Menu menu2 = new Menu(fight2, attacks3);
            int SelectedIndex2 = menu2.Run();
            switch (SelectedIndex2)
            {
                case 0:
                    Console.Clear();
                    Win();
                    ConsoleUtils.BackToDialog();
                    ConsoleUtils.Info4();
                    MyGame.MyCanteenScene.Run();
                    break; 
                case 1:
                    Console.Clear();
                    Lose();
                    ConsoleUtils.BackToDialog();
                    MyGame.MyCreditsScene.Run();
                    break;
            }
        }
        private void Win()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string win = @"
You did it, it was best idea to run into him, you knocked him down and finished him.
Here's your three packs of cigarretes for winning. Now you can go to Gustavo.

   _______________________        _______________________        _______________________ 
  /|_|_\ /__,''___ /____ /|      /|_|_\ /__,''___ /____ /|      /|_|_\ /__,''___ /____ /|
 |HHHHHH|   \_/   |HHHHH|/|     |HHHHHH|   \_/   |HHHHH|/|     |HHHHHH|   \_/   |HHHHH|/|    
 |``````|_________|`````| |     |``````|_________|`````| |     |``````|_________|`````| |
 |    ~~~~~~~~~~~~~~    | |     |    ~~~~~~~~~~~~~~    | |     |    ~~~~~~~~~~~~~~    | | 
 |        .-/\-,        | |     |        .-/\-,        | |     |        .-/\-,        | |
 |        _\\//_        | |     |        _\\//_        | |     |        _\\//_        | |
 |       |  /(_)|       | |     |       |  /(_)|       | |     |       |  /(_)|       | |
 |_______|_||.-.|_______|/|     |_______|_||.-.|_______|/|     |_______|_||.-.|_______|/|
 |HHHHHHH| ||:_ |HHHHHHH|/|     |HHHHHHH| ||:_ |HHHHHHH|/|     |HHHHHHH| ||:_ |HHHHHHH|/|
 |```````|_||:_)|```````| |     |```````|_||:_)|```````| |     |```````|_||:_)|```````| |
 |       |______|       | |     |       |______|       | |     |       |______|       | |
 |        ______        | |     |        ______        | |     |        ______        | |
 |       (__24__)       | |     |       (__24__)       | |     |       (__24__)       | |
 |       ~~~~~~~~       | |     |       ~~~~~~~~       | |     |       ~~~~~~~~       | |
 | blabla cancer blabla | |     | blabla cancer blabla | |     | blabla cancer blabla | |
 |______________________|/      |______________________|/      |______________________|/
";
            Console.WriteLine(win);
        }
    }
}  
