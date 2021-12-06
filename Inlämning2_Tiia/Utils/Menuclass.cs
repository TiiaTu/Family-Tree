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
            int menuChoise = UserInput();

            //switch (menuChoise)
            //{
            //    case 1:
            //        PersonCrud.Create();
            //        Console.Clear();
            //        break;
            //    case 2:
            //        PersonCrud.FindParents();
            //        Console.Clear();
            //        break;
            //    case 3:
            //        PersonCrud.ReadFirstLetter();
            //        Console.Clear();
            //        break;
            //    case 4:
            //        PersonCrud.ReadBirthYear();
            //        Console.Clear();
            //        break;
            //    case 5:
            //        PersonCrud.Update();
            //        Console.Clear();
            //        break;
            //    case 6:
            //        PersonCrud.Delete();
            //        Console.Clear();
            //        break;
            //    case 7:
            //        // parents
            //        Console.Clear();
            //        break;
            //    case 8:
            //        // children
            //        Console.Clear();
            //        break;
            //    case 9:
            //        //siblings
            //        Console.Clear();
            //        break;


            //    default:
            //        Console.WriteLine("Enter a number between 1-10.");
            //        Console.ReadKey();
            //        break;

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

        private static int UserInput()
        {
            int.TryParse(Console.ReadLine(), out int menuChoise);
            return menuChoise;
        }
    }
}

