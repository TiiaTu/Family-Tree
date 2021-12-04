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
            Console.WriteLine("Welcome to the .... family tree");

            Console.WriteLine(@" [1] - 
[2] - 
[3] - 
[4] - 
[5] - 
[6] - 
[7] - 
[8] - ");

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
