using System;
using System.Collections.Generic;

namespace survive_the_night
{
    class Program
    {
        public static void WriteLineWordWrap(string paragraph, int tabSize = 8)
        {
            string[] lines = paragraph
                .Replace("\t", new String(' ', tabSize))
                .Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            for (int i = 0; i < lines.Length; i++) {
                string process = lines[i];
                List<String> wrapped = new List<string>();

                while (process.Length > Console.WindowWidth) {
                    int wrapAt = process.LastIndexOf(' ', Math.Min(Console.WindowWidth - 1, process.Length));
                    if (wrapAt <= 0) break;

                    wrapped.Add(process.Substring(0, wrapAt));
                    process = process.Remove(0, wrapAt + 1);
                }

                foreach (string wrap in wrapped) {
                    Console.WriteLine(wrap);
                }

                Console.WriteLine(process);
            }
        }
        
        static void Main(string[] args)
        {
            // Console.Clear();
            Console.WriteLine("\n\n\n\n**************Survive The Night****************\n\n\n\n");
            Console.WriteLine("Enter Your Name:");

            string name = Console.ReadLine();
            Game newGame = new Game(name);
            Console.Clear();

            newGame.ChooseCharacter();
            
        }
    }
}
