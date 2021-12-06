using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2_Tiia
{
    class Menuclass
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.WriteLine("Welcome to the Stark family tree");

            Console.WriteLine(@" [1] - Create a person
[2] - Get mother 
[3] - Get father
[4] - Update information
[5] - Delete
[6] - Show the family tree
[7] - Exit
[8] - ");
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");

            _ = int.TryParse(Console.ReadLine(), out int input);

            switch (input)
            {
                case 1: break;
                case 2: break; 
                case 3: break; 
                case 4: break; 
                case 5: break; 
                case 6: break; 
                case 7: break; 
                case 8: break; 
            }

        }
        
    }
}
