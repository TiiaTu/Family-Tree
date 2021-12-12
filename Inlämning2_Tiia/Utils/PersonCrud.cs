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
        public void Start()
        {
            using var db = new PersonContext();
            Utils.Helper.PeopleInDatabase.PersonsAdded(); //lägger till alla personer till listan
            db.SaveChanges();
            
            Menuclass.Menu();     
        }

        //-----------------[1] Skapa en person med för- och efternamn [1]----------------------------
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
                    Console.WriteLine($"\n{firstName} {lastName} is added to the database");

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

        //-----------------[2] Hitta föräldrarna till en person [2]----------------------------------

        public static void FindParents(string firstName, string lastName)
        {
            var momFirstName = "";
            var momLastName = "";
            var dadFirstName = "";
            var dadLastName = "";

            Console.WriteLine("Which parent do you want to find? \n[1] - Mother \n[2] - Father");
            Console.Write(">");

            int.TryParse(Console.ReadLine(), out int menuChoise);

            switch (menuChoise)
            {
                case 1:
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

        //-----------------[3] Uppdatera uppgifter [3]-----------------------------------------------

        public static Person Update(string firstName, string lastName)
        {
            var newFirstName = "";
            var newLastName = "";

            using (var db = new PersonContext())
            {
                var update = db.People.FirstOrDefault(n => n.FirstName == firstName &&
                                                            n.LastName == lastName);

                if (update != null)
                {
                    update.FirstName = newFirstName;
                    update.LastName = newLastName;

                    db.SaveChanges();
                }
                else Console.WriteLine("This person doesn't exist!");

                return update;
            }
        }

        //-----------------[4] Syskonen till en person [4]-------------------------------------------
        public static Person FindSiblings(string firstName, string lastName)
        {
            using (var db = new PersonContext())
            {
                var person = db.People.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName);

                if (person != null)
                {
                    var siblings = db.People.Where(n => n.MotherId == person.MotherId || n.FatherId == person.FatherId).ToList();
                    Console.WriteLine($"Siblings to {firstName} {lastName}; \n");

                    foreach (var sibling in siblings.OrderBy(s => s.FirstName).ThenBy(s => s.LastName))
                    {
                        Console.WriteLine(sibling);
                    }
                }
                else
                {
                    Console.WriteLine($"Could not find siblings to {firstName} {lastName}.");
                }
                return person;
            }
        }

        //-----------------[5] Barn till en person [5]-----------------------------------------------

        public static Person ShowChildren(string firstName, string lastName)
        {
            using var db = new PersonContext();
            {
                var person = db.People.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName);

                if (person != null)
                {
                    var children = db.People.Where(p => p.MotherId == person.Id || p.FatherId == person.Id).ToList();
                    Console.WriteLine($"Children to {firstName} {lastName}; \n");

                    foreach (var child in children.OrderBy(s => s.FirstName).ThenBy(s => s.LastName))
                    {
                        Console.WriteLine(child);
                    }
                }
                else
                {
                    Console.WriteLine($"Could not find children for {firstName} {lastName}.");
                }
                return person;
            }
        }

        //-----------------[6] Show grandparents [6]-------------------------------------------------

        public static Person ShowGrandparents(string firstName, string lastName)
        {
            using (var db = new PersonContext())
            {
                var person = db.People.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName);

                if (person != null)
                {
                    List<Person> parents = GetParents(person); //lägger in föräldrarna i en lista

                    
                    if (parents.Count > 0)
                    {
                        Console.WriteLine($"{firstName} {lastName}'s grandparents are;\n ");
                        
                        foreach (Person p in parents)
                        {
                            List<Person> grandparents = GetParents(p); //lägger in förföräldrarna i en lista
                            
                            
                            if (grandparents.Count > 0)
                            {
                                foreach (Person gp in grandparents)
                                {
                                    Console.WriteLine($"{gp.FirstName} {gp.LastName}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Could not find parents to {p.FirstName} {p.LastName} (parent).");
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Could not find parents to {person.FirstName} {person.LastName}.");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Person does not exist.");
                }
                return person;
            }
        }

        // helpermetod för ShowGrandparents()
        private static List<Person> GetParents(Person p) 
        {
            List<Person> parentsList = new List<Person>();

            using (var parents = new PersonContext())
            {
                parentsList = parents.People.Where(n => n.Id == p.FatherId || n.Id == p.MotherId).ToList();
            }
            return parentsList;

        }

        //-----------------[7] visa alla [7]---------------------------------------------------------
        public static void DisplayAll()
        {
            using var db = new PersonContext();

            foreach (var person in db.People.OrderBy(n => n.LastName).ThenBy(n => n.FirstName))
            {
                Console.WriteLine(person);
            }
        }

        //-----------------[8] lista efter angiven bokstav [8]---------------------------------------
        public static void ListByLetter()
        {
            using var db = new PersonContext();

            Console.Write("Enter a letter: ");
            var givenLetter = Console.ReadLine();

            var input = db.People.Where(p => p.FirstName.Contains(givenLetter));

            foreach (var p in input.OrderBy(p => p.FirstName))
            {
                Console.WriteLine(p.FirstName + " " + p.LastName);
            }
        }


        //-----------------[9] Ta bort en person [9]---------------------------
        public static Person Delete(string firstName, string lastName)
        {
            using (var db = new PersonContext())
            {
                var person = db.People.
                            FirstOrDefault(
                                p => p.FirstName == firstName &&
                                p.LastName == lastName
                                );

                if (person != null)
                {
                    db.People.Remove(person);
                    db.SaveChanges();
                    Console.WriteLine($"\n{person.FirstName} {person.LastName} has been removed.");
                }
                return person;
            }
        }

        
    }
}






