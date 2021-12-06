using Inlämning2_Tiia.Utils;
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
            SpoilerAlert();
            Visual.MainMenu();

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

        

        private void SpoilerAlert()
        {
            Console.Clear();
            Console.WriteLine("|>>>>>>> SPOILER ALERT <<<<<<<|");
            Console.WriteLine(@"This family tree you are about to see 
contains spoilers for the series Game of Thrones!");
            Console.WriteLine(" press enter to continue");
            Console.ReadLine();
        }
    }
}
