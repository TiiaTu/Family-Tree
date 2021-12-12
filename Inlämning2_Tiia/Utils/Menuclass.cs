using Inlämning2_Tiia.Utils;
using System;
using System.Collections.Generic;

namespace Inlämning2_Tiia
{
    class Menuclass
    {
        public static void Menu()
        {
            Visual.SpoilerAlert();
            while (true)
            {
                Visual.MainMenu();
                int menuChoise = UserInput();

                switch (menuChoise)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Parents();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Siblings(); 
                        break;
                    case 5:
                        Children(); 
                        break;
                    case 6:
                        Grandparents(); 
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
                PressEnter();
                Console.Clear();
            }
        }

        private static void Delete()
        {
            HeaderAndName("DELETE A PERSON", out string firstName, out string lastName);
            PersonCrud.Delete(firstName, lastName);
        }

        private static void ByLetter()
        {
            Console.Write("LIST BY LETTER");
            PersonCrud.ListByLetter();
        }

        private static void ListAll()
        {
            Console.Write("LIST OF ALL THE PERSONS IN THE FAMILY TREE");
            PersonCrud.DisplayAll();
        }

        private static void Grandparents()
        {
            HeaderAndName("SHOW GRANDPARENTS", out string firstName, out string lastName);
            PersonCrud.ShowGrandparents(firstName, lastName);
        }

        private static void Children()
        {
            HeaderAndName("SHOW CHILDREN", out string firstName, out string lastName);
            PersonCrud.ShowChildren(firstName, lastName);
        }

        private static void Siblings()
        {
            HeaderAndName("SHOW SIBLINGS",out string firstName, out string lastName);
            PersonCrud.FindSiblings(firstName, lastName);
        }

        private static void Update()
        {
            HeaderAndName("UPDATE INFORMATION OF A PERSON", out string firstName, out string lastName);
            PersonCrud.Update(firstName, lastName);
        }

        private static void Parents()
        {
            HeaderAndName("FIND / ADD PARENTS", out string firstName, out string lastName);
            PersonCrud.FindParents(firstName, lastName);
        }

        private static void Add()
        {
            HeaderAndName("ADD PERSON", out string firstName, out string lastName);
            PersonCrud.FindAndCreate(firstName, lastName);
        }


        //-------------little helpers------------------------------------------------------------------

        private static void HeaderAndName(string header, out string firstName, out string lastName)
        {
            Write("\t");
            Write(header);
            Write("\n\t----------------");

            Write("\nEnter person's first name: ");
            firstName = Console.ReadLine();
            Write("Enter person's last name: ");
            lastName = Console.ReadLine();
        }

        private static void Write(string message)
        {
            Console.Write(message);
        }

        private static int UserInput()
        {
            int.TryParse(Console.ReadLine(), out int menuChoise);
            return menuChoise;
        }

        private static void PressEnter()
        {
            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();
        }
    }
}


