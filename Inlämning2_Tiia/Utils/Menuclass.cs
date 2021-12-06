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
        public static void Menu()
        {
            Visual.SpoilerAlert();
            Visual.MainMenu();
            
            int menuChoise = UserInput();

            switch (menuChoise)
            {
                case 1:
                    PersonCrud.FindAndCreate();
                    Console.Clear();
                    break;
                //case 2:
                //    PersonCrud.FindParents();
                //    Console.Clear();
                //    break;
                //case 3:
                //    PersonCrud.ReadFirstLetter();
                //    Console.Clear();
                //    break;
                //case 4:
                //    PersonCrud.ReadBirthYear();
                //    Console.Clear();
                //    break;
                //case 5:
                //    PersonCrud.Update();
                //    Console.Clear();
                //    break;
                //case 6:
                //    PersonCrud.Delete();
                //    Console.Clear();
                //    break;
                case 7:
                    // parents

                    break;
                case 8:
                    // children

                    break;
                case 9:
                    //siblings

                    break;


                default:
                    Console.WriteLine("Enter a number between 1-10.");
                    Console.ReadKey();
                    break;

            }
            Console.Clear();
        }

        

        private static int UserInput()
        {
            int.TryParse(Console.ReadLine(), out int menuChoise);
            return menuChoise;
        }
    }
}

