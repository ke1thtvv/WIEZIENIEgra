using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIEZIENIEgra
{
    internal class CanteenScene : Scene
    {
        public CanteenScene(Game game) : base(game)
        {
        }
        public override void Run()
        {
            string prompt = "You entered canteen but there is a lot of prisoners.\n You see five guys sitting alone and probably Gustavo is one of them.\n(Do you remember how he looks?)\n\n";
            string[] guys = { "First has short dark hair and looks very massive", "Second is slim and has plenty of enigmatic tatoos",
                "Third is also bald but have no tatoos", "Fourth is bald and has tiger tatoo on his arm", "Fifth is big guy with big moustache and long hair" };
            Menu menu = new Menu(prompt, guys);
            int selectedIndex = menu.Run();
            switch (selectedIndex)
            {
                case 0:
                    Console.Clear();
                    GuyOne();
                    ConsoleUtils.BackToDialog();
                    MyGame.MyCanteenScene.Run();
                    break;
                case 1:
                    Console.Clear();
                    GuyTwo();
                    ConsoleUtils.BackToDialog();
                    MyGame.MyCanteenScene.Run();
                    break;
                case 2:
                    Console.Clear();
                    GuyThree();
                    ConsoleUtils.BackToDialog();
                    MyGame.MyCanteenScene.Run();
                    break;
                case 3:
                    Console.Clear();
                    GuyFour();
                    ConsoleUtils.BackToDialog();
                    ConsoleUtils.Info5();
                    MyGame.MyCorridorScene.Run();
                    break;
                case 4:
                    Console.Clear();
                    GuyFive();
                    ConsoleUtils.BackToDialog();
                    MyGame.MyCanteenScene.Run();
                    break;
            }

        }
        private void GuyOne()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Luigi: 'Hey, I'm looking for Gustavo. Is that you?'\n");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Guy 1: 'Huh, you're looking for Gustavo huh? No it's not me.\nYou don't know how he looks and you're trying to find him?'\n");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Luigi: 'I was told I can find him here but I didn't ask how he looks.'\n");
            Thread.Sleep(3500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Guy 1: 'That's not my problem. You'd better go'");
        }
        private void GuyTwo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Luigi: 'Hey, you. I've been looking for Gustavo. Are you him?'\n");
            Thread.Sleep(3700);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Guy 2: 'Uh, sorry, buddy. You must have mistaken me for someone else. I'm just trying to mind my own business here'\n");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Luigi: 'Well, I guess my search continues then. Well, good luck with minding your own business'\n");
        }
        private void GuyThree()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Luigi: 'Hey, excuse me. I've been trying to find someone. Are you Gustavo?'\n");
            Thread.Sleep(4000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Guy 3: 'Sorry, pal, I think you've got the wrong guy. I'm just trying to survive in this place'\n");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Luigi: 'Ah, my mistake. I'll keep searching elsewhere'\n");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Guy 3: 'No worries, man. Just be careful who you approach in here. It's a rough place'\n");
            Thread.Sleep(4500);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Luigi: 'I'll stay on my guard. Take care, and good luck in here'\n");
        }
        private void GuyFour()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Luigi: 'Hey, you. I've been looking for Gustavo. Are you him?'\n");
            //Thread.Sleep(3500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Guy 4: 'Can't you see that? What do you want'\n");
            //Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Luigi: 'I heard you're the guy to talk to if I need something. I've got something I think you might be interested in'\n");
            //Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Guy 4: 'Well, well, well, what do you have there? Show me what you got, and we'll see if we can make a deal.'\n");
            //Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Luigi: 'Three packs of cigarettes, unopened and ready to go.'\n");
            //Thread.Sleep(3500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Guy 4: 'Cigarettes, huh? That's a valuable currency in here. Show me what you got, and we'll talk.'\n");
            //Thread.Sleep(4700);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Luigi: 'Here they are, three packs of premium smokes. Guaranteed to satisfy. I'm looking to trade them for a torch and screwdriver.\n       I think it's good exchange'\n");
            //Thread.Sleep(7000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Guy 4: 'Well, cigarettes are in high demand, my friend. I can get you that lighter and screwdriver you're after. Let's shake on it.'\n");
            //Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Luigi: Great! We've got ourselves a deal. I'll hand over the cigarettes once I have the items in my hands.");
            MyGame.MyPlayer.PickUpTorch();
            MyGame.MyPlayer.PickUpCrowBar();
        }
        private void GuyFive()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Luigi: 'Hey, you. I've been looking for Gustavo. Are you him?'\n");
            Thread.Sleep(4000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Guy 5: 'You've got some nerve coming up to me like that. What makes you think I'd know anything about your precious someone?'\n");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Luigi: 'Look, I didn't mean to offend. I'm just trying to find some answers. No need to get hostile.'\n");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Guy 5: 'Save your sob story, pal. I don't have time for your problems. Find someone else to bother.'\n");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Luigi: 'Fine, I'll leave you alone.'\n");
        }
    }
}
