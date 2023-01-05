using System;
using System.Text.RegularExpressions;

namespace EditHTML
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("->VIEWER MODE");
            Console.WriteLine("-----------");
            Console.WriteLine("-Press ESC to turn to save menu.");
            Console.WriteLine("-----------");
            Replace(text);
            Console.ReadKey();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"(?<=<strong>)[\s\S]*?(?=</strong>)");
            var words = text.Split(' ');

            // // Long string  
            // string authors = "Mahesh Chand, Raj Kumar, Mike Gold, Allen O'Neill, Marshal Troll";

            // // Get all matches  
            // MatchCollection matchedAuthors = strong.Matches(authors);

            // // Print all matched authors  
            // for (int count = 0; count < matchedAuthors.Count; count++)
            //     Console.WriteLine(matchedAuthors[count].Value);

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))
                            )
                        );
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }

    }
}