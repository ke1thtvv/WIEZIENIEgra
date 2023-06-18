using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIEZIENIEgra
{
    internal class ConsoleUtils
    {
        public static void BackToDialog()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }
        public static void Info1()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.WriteLine("You want to escape prison so you have to find a way to do that.\nYou are in prison cell with one prisoner,\nmaybe you should ask him, whether he know something.\n\n");
            ConsoleUtils.BackToDialog();
        }
        public static void Info2()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.WriteLine("You left you cell and headed to prison yard.\nYou noticed that some men fighting over there\nand decided to talk about fight with them in order to get cigarettes\n\n");
            ConsoleUtils.BackToDialog();
        }
        public static void Info3()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.WriteLine("You've gone for broke.\nIf you win, you receive cigarettes..BUT..if you lose,\nthey'll understand that you lied to them and...\n\n");
            ConsoleUtils.BackToDialog();
        }
        public static void Info4()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.WriteLine("You know there's no time to waste so you\ninstatly decided to go to canteen in order\nto find Gustavo and talk to him\n\n");
            ConsoleUtils.BackToDialog();
        }
        public static void Info5()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.WriteLine("With the lighter and screwdriver in your hand,\nit's time to put these tools to good use.\nWait till night, and go to vent located\nin corridor and try escape.\n\n");
            ConsoleUtils.BackToDialog();
        }
    }
}
