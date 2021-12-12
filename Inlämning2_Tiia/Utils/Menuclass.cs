using Inlämning2_Tiia.Utils;
using Inlämning2_Tiia.Utils.Helper;
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
                    Add();
                    break;
                case 2:
                    Parents(); break;
                case 3:
                    Update(); break;
                case 4:
                    Siblings(); //inte klart
                    break;
                case 5:
                    Children(); //inte klart
                    break;
                case 6:
                    Grandparents(); //inte klart 
                    break;
                case 7:
                    ListAll();
                    break;
                case 8:
                    ByLetter();
                    break;
                case 9:
                    Delete();
                    break;
                case 10:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Enter a number between 1-10.");
                    Console.ReadKey();
                    break;
            }
            Console.Clear();
        }

        private static void Delete()
        {
            throw new NotImplementedException();
        }

        private static void ByLetter()
        {
            throw new NotImplementedException();
        }

        private static void ListAll()
        {
            throw new NotImplementedException();
        }

        private static void Grandparents()
        {
            throw new NotImplementedException();
        }

        private static void Children()
        {
            throw new NotImplementedException();
        }

        private static void Siblings()
        {
            throw new NotImplementedException();
        }

        private static void Update()
        {
            Header("UPDATE INFORMATION OF A PERSON");

            Write("\tEnter first name of the person you want to update: ");
        }

        private static void Parents()
        {
            var lastName = ""; //inte så snyggt med alla variabler här, men funkar
            var momFirstName = "";      
            var momLastName = "";
            var dadFirstName = "";
            var dadLastName = "";

            Header("FIND / ADD PARENTS");

            Write("\nEnter first name of the person (not parents' name): ");
            var firstName = Console.ReadLine();

            PersonCrud.FindParents(firstName, lastName, momFirstName, momLastName, dadFirstName, dadLastName);
        }

        private static void Add()
        {
            Header("ADD PERSON");

            AskForWholeName(out string firstName, out string lastName);

            PersonCrud.FindAndCreate(firstName, lastName);

            Write($"{firstName} {lastName} is now added to the database");
        }

        private static void Header(string header)
        {
            Write("\t");
            Write(header);
            Write("\n\t----------------");
        }

        private static void AskForWholeName(out string firstName, out string lastName)
        {
            Write("\nEnter first name of a person: ");
            firstName = Console.ReadLine();
            Write("Enter last name of person: ");
            lastName = Console.ReadLine();
        }

        //-------------little helpers------------------------------------------------------------------

        private static void Write(string message)
        {
            Console.Write(message);
        }

        private static int UserInput()
        {
            int.TryParse(Console.ReadLine(), out int menuChoise);
            return menuChoise;
        }
    }
}


