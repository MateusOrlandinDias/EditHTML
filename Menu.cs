using System;

namespace EditHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            DrawScreen(35, 10);
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen(int width = 30, int heigth = 10)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write(" +");
            for (int i = 0; i <= width; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= heigth; lines++)
            {
                Console.Write(" |");
                for (int i = 0; i <= width; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write(" +");
            for (int i = 0; i <= width; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("HTML Editor");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("===============");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Select one option above:");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("1 - New File");
            Console.SetCursorPosition(3, 12);
            Console.WriteLine("0 - Leave");
            Console.SetCursorPosition(3, 13);
            Console.Write("Option: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1:
                    Editor.Show();
                    break;

                case 2:
                    Console.WriteLine("View");
                    break;

                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;

                default:
                    Show();
                    break;

            }
        }
    }
}