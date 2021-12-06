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
        public static void Menu(string firstName, string lastName, string fName, string lName, string momFirstName, string momLastName, string dadFirstName, string dadLastName)
        {
            Visual.SpoilerAlert();
            Visual.MainMenu();
            
            int menuChoise = UserInput();

            switch (menuChoise)
            {
                case 1:
                    PersonCrud.FindAndCreate(firstName, lastName);
                    break;
                case 2:
                    PersonCrud.FindParents(firstName, lastName,momFirstName,momLastName,dadFirstName,dadLastName);
                    break;
                case 3:
                    PersonCrud.Update(firstName,lastName, fName, lName);
                    break;
                case 4:
                    PersonCrud.ShowSiblings(); //inte klart
                    break;
                case 5:
                    PersonCrud.ShowChildren(); //inte klart
                    break;
                case 6:
                    PersonCrud.ShowGrandparents(); //inte klart 
                    break;
                case 7:
                    PersonCrud.DisplayAll(people, name);
                    break;
                case 8:
                    PersonCrud.ListByLetter();
                    break;
                case 9:
                    PersonCrud.Delete();

                    break;
                case 10:
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

