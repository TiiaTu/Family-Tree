using Inlämning2_Tiia.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2_Tiia
{
    public class PersonCrud
    {
        public static void Start()
        {
            Menuclass.Menu();

            using (var db = new PersonContext())
            {
                Utils.Helper.PeopleInDatabase.PersonsAdded(); //lägger till alla personer till listan
                db.SaveChanges();
            }
        }


        //--------------[1] skapa en person med för- och efternamn [1]--------------------------

        public static Person FindAndCreate(string firstName, string lastName)
        {
            using (var db = new PersonContext())
            {
                var person = db.People.
                            FirstOrDefault(
                                p => p.FirstName == firstName &&
                                p.LastName == lastName
                                );

                if (person == null) // skapa personen om den inte finns
                {
                    person = new Person { FirstName = firstName, LastName = lastName };
                    Console.WriteLine($"{firstName} {lastName} is added to the database");

                    db.People.Add(person);
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName} exists in the database and has Id {person.Id}");
                }
                return person;
            }
        }

        //-----------------[2] hitta föräldrarna till en person [2]--------------------------------------------------------------------------------------------

        public static void FindParents(string firstName, string lastName, string momFirstName, string momLastName, string dadFirstName, string dadLastName)
        {
            Console.WriteLine("Which parent you want to find? \n[1] - Mother \n[2] Father");

            int.TryParse(Console.ReadLine(), out int menuChoise);
            switch (menuChoise)
            {
                case 1:
                    Utils.Helper.Mother.SearchMother();
                    Utils.Helper.Mother.FindMother(firstName, lastName);
                    Utils.Helper.Mother.SetMother(firstName, lastName, momFirstName, momLastName);
                    break;
                case 2:
                    Utils.Helper.Father.FindFather(firstName, lastName);
                    Utils.Helper.Father.SetFather(firstName, lastName, dadFirstName, dadLastName);
                    break;
                default:
                    Console.WriteLine("Enter 1 or 2");
                    break;
            }
        }

        //-------------------------[3] Uppdatera uppgifter [3]-----------------------------------

        public static Person Update(string firstName, string lastName, string fname, string lname)
        {
            using (var db = new PersonContext())
            {
                var update = db.People.FirstOrDefault(n => n.FirstName == firstName &&
                                                            n.LastName == lastName);

                if (update != null)
                {
                    update.FirstName = fname;
                    update.LastName = lname;

                    db.SaveChanges();
                }
                else Console.WriteLine("This person doesn't exist!");

                return update;
            }
        }

        //---------------------[4] Show siblings [4]------------------------


        //show children




        //show grandparents


        //----------------visa alla----------------------------------------------------
        public static void DisplayAll(List<Person> people, string name)
        {
            using var db = new PersonContext();
            Console.WriteLine("List of all the family members ordered by last name");

            foreach (var person in db.People.OrderBy(n => n.LastName).ThenBy(n => n.FirstName))
            {
                Console.WriteLine(person);
            }
        }

        //------------[8] lista efter angiven bokstav-----------------------------------------
        public static void ListByLetter()
        {
            using var db = new PersonContext();

            Console.WriteLine("Enter a letter: ");
            var givenLetter = Console.ReadLine();

            var input = db.People.Where(p => p.FirstName.Contains(givenLetter));

            foreach (var p in input.OrderBy(p => p.FirstName))
            {
                Console.WriteLine(p.FirstName + " " + p.LastName);
            }
        }


        //----------[9] ta bort en person via för- och efternamn-----------------------------
        public static Person Delete(string firstName, string lastName)
        {
            using (var db = new PersonContext())
            {
                var person = db.People.
                            FirstOrDefault(
                                p => p.FirstName == firstName &&
                                p.LastName == lastName
                                );
                if (person == null)
                {
                    db.People.Remove(person);
                    db.SaveChanges();
                }
                return person;
            }
        }

        //-----------ta bort en person via Id----------------------------------------
        public static Person Delete(int id)
        {
            using (var db = new PersonContext())
            {
                var person = db.People.
                            FirstOrDefault(
                                p => p.Id == id);

                if (person == null)
                {
                    db.People.Remove(person);
                    db.SaveChanges();
                }
                return person;
            }
        }
    }
}



