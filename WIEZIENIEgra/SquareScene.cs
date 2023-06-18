using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIEZIENIEgra
{
    internal class SquareScene : Scene
    {
        public SquareScene(Game game) : base(game)
        {
        }

        public override void Run()
        {
            ConsoleUtils.Info2();
            string prompt = "Manuel:  'What are you looking for'\nLuigi:   'I heard there are fights with bets'\nManuel:  'Oh-ho-ho, I see, you want to fight. Are you up for a fight in exchange for three packs of cigarettes?\n" +
                "          What are you putting on a line?'\n";
            string[] options = { "I have 2 toothpastes in my cell", "What about my playing cards, it's rare having them in prison." };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();

            string[] options1 = { "What about my playing cards, it's rare having them in prison." };
            string[] options2 = { "I have 2 toothpastes in my cell" };
            string[] options3 = { "(Shhh.. I need to figure something out quickly) Yeah, okay I have some drugs\n(what if they find out I don't have them, it will be over. I HAVE TO WIN)" };
            Menu menu1 = new Menu(null, options1);
            Menu menu2 = new Menu(null, options2);
            Menu menu3 = new Menu(null, options3);

            switch (selectedIndex)
            {
                case 0:
                    AnswerOne();
                    menu1.RunWithoutClearing();
                    AnswerTwo();
                    menu3.RunWithoutClearing();
                    ConsoleUtils.Info3();
                    MyGame.MyFightScene.Run();
                    break;
                case 1:
                    AnswerTwo();
                    menu2.RunWithoutClearing();
                    AnswerOne();
                    menu3.RunWithoutClearing();
                    MyGame.MyFightScene.Run();
                    break;
            }
            
        }
        private void AnswerOne()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nManuel:  'Are you kidding me, I don't need your toothpaste.'");
        }
        private void AnswerTwo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nManuel:  'I give you last chance, enough of jokes.'");
        }
        private void AnswerThree()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("'(Shhh.. I need to figure something out quickly) Yeah, okay I have some drugs\n(what if they find out I don't have them, it will be over. I HAVE TO WIN)'");
        }
    }
}
