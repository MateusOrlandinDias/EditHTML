using System;
using System.IO;
using System.Text;

namespace EditHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("->EDITOR MODE");
            Console.WriteLine("-----------");
            Console.WriteLine("-Press ESC in a new line to turn to viewer mode.");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Viewer.Show(file.ToString());

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("------------");
            Console.WriteLine("->Do you want to save the file? 'y' or 'n'");
            char save = Console.ReadKey().KeyChar;

            if (save.Equals('y'))
            {
                Save(file.ToString());
            }
            else if (save.Equals('n'))
            {
                Menu.Show();
            }
        }

        public static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("->Write the Path to save the file:");
            Console.WriteLine("-Make sure you dont forget the name of file and your txt extention.");

            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"File {path} was successfully saved!");
            Console.ReadKey();
            Menu.Show();
        }
    }
}