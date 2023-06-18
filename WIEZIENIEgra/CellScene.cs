using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIEZIENIEgra
{
    internal class CellScene : Scene
    {
        public CellScene(Game game) : base(game)
        {
        }
        public override void Run()
        {
            string prompt = "Luigi:  'Hi, I'm Luigi and I need to escape this prison. Do you know someone who could help me with that?'\n" +
                "Sergio: 'Yes, there's one guy here called Gustavo. You can find him in canteen. He hase some tools,\n         that could help you with your stupid idea of escaping this prison, but he only trades for cigarretes." +
                "\n         Do you have any questions?'\n";
            string[] options = { "How does Gustavo look?", "How many cigarettes does Gustavo usually trade his tools for?" , "Are there any specific escape routes or weak points in the prison that you're aware of?" , 
            "That's all I wanted to know. I'll try to get cigarettes then."};
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();
            switch (selectedIndex)
            {
                case 0:
                    Console.Clear();
                    QuestionOne();
                    ConsoleUtils.BackToDialog();
                    MyGame.MyCellScene.Run();
                    break;
                case 1:
                    Console.Clear();
                    QuestionTwo();
                    ConsoleUtils.BackToDialog();
                    MyGame.MyCellScene.Run();
                    break;
                case 2:
                    Console.Clear();
                    QuestionThree();
                    ConsoleUtils.BackToDialog();
                    MyGame.MyCellScene.Run();
                    break;
                case 3:
                    QuestionFour();
                    break;
            }

        }
        private void QuestionOne()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.WriteLine("He's big guy. He is bald and has enourmous moustache.\nHis identification mark is tatoo of tiger on right arm.");
            
        }
        private void QuestionTwo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.WriteLine("He values himself, apparently for 3 packs of cigarettes\nyou can get a flashlight and a screwdriver from him.");
        }
        private void QuestionThree()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.WriteLine("I heard somewhere that you can try use vents.\nThey can lead you near walls of prison, but yet you're in the area of prison.");
        }
        private void QuestionFour()
        {
            MyGame.MySquareScene.Run();
        }

    }
}
