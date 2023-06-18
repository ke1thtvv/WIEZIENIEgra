using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIEZIENIEgra
{
    internal class Menu
    {
        private string Prompt;
        private string[] Options;
        private int SelectedIndex;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }

        private void PossibleOptions()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if (i == SelectedIndex)
                {
                    prefix = "->";
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"{prefix} {currentOption}");
            }
            Console.ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                PossibleOptions();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
                else if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
            }
            while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;
        }
        public int RunWithoutClearing()
        {
            ConsoleKey keyPressed;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            PossibleOptions();
            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
                else if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
            }
            while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;
        }



        private Dictionary<string, bool> Dictionary;
        public Menu(string prompt, Dictionary<string,bool>dictionary)
        {
            Prompt = prompt;
            Dictionary = dictionary;
            SelectedIndex = 0;
        }
        private void PossibleOptionsScrew()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < Dictionary.Count; i++)
            {
                string currentOption = Dictionary.ElementAt(i).Key;
                string prefix;

                if (i == SelectedIndex)
                {
                    prefix = "->";
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                if (!Dictionary.ElementAt(i).Value)
                {
                    Console.WriteLine($"{prefix} {currentOption}");

                }               
            }
            Console.ResetColor();
        }
        public int RunScrew()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                PossibleOptionsScrew();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Dictionary.Count)
                    {
                        SelectedIndex = 0;
                    }
                    if (Dictionary.ElementAt(SelectedIndex).Value)
                    {
                        SelectedIndex++;
                    }
                }
                else if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Dictionary.Count - 1;
                    }
                    if (Dictionary.ElementAt(SelectedIndex).Value)
                    {
                        SelectedIndex--;
                    }
                }
            }
            while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;
        }
    }
}
