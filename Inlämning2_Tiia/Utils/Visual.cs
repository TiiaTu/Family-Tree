using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2_Tiia.Utils
{
    class Visual
    {
        public static void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.ResetColor();

            Console.WriteLine("Welcome to the Targaryen family tree\n");

            Console.WriteLine(@"[1] - Create a person
[2] - Find parents
[3] - Update information
[4] - Show siblings
[5] - Show children
[6] - Show grandparents
[7] - List all
[8] - List by letter
[9] - Delete person
[10] - Exit");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.ResetColor();

            Console.Write(">> ");
        }

        public static void SpoilerAlert()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|>>>>>>> SPOILER ALERT <<<<<<<|\n");
            Console.ResetColor();
            Console.WriteLine(@"This family tree you are about to see 
contains spoilers for the series Game of Thrones!");
            Console.WriteLine(" \npress enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
