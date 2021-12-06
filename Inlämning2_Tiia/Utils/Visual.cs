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
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.WriteLine("Welcome to the Targaryen family tree");

            Console.WriteLine(@" [1] - Create a person
[2] - Get mother 
[3] - Get father
[4] - Update information
[5] - Delete
[6] - Show the family tree
[7] - Exit
[8] - ");
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
        }
    }
}
