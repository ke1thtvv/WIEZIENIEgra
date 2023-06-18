using System;

namespace WIEZIENIEgra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 30;
            Console.WindowWidth = 135;
            Console.Title = "PRISON BREAK";
            Console.CursorVisible = false;
            Game Prison = new Game();
            Prison.Start();
        }
    }
}