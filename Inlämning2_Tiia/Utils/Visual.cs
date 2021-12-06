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
[2] - Find parents
[3] - Find father
[4] - Update information
[5] - 
[6] - List by first letter
[7] - List all
[8] - Show 
[7] - Delete person
[8] - Exit");
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
        }
    }
}
