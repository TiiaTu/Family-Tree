using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2_Tiia.Utils.Helper
{
    class Mother
    {
        //--------------------mor-------------------------------

        public static void SearchMother()
        {
            Console.Clear();
            Console.WriteLine("Search for mother\n");

            Console.WriteLine("Enter persons first name: ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter persons last name: ");
            var lastName = Console.ReadLine();

            FindMother(firstName, lastName);
            Console.WriteLine($"\nDo you want to change {firstName} {lastName}'s mother? y/n");
            var input = Console.ReadLine().ToLower();
            //if (input = 'y')
            //{
            //    Console.WriteLine("Enter mother's first name: ");
            //    var momFirstName = Console.ReadLine();
            //    Console.WriteLine("Enter mother's last name: ");
            //    var momLastName = Console.ReadLine();
            //    SetMother(firstName, lastName, momFirstName, momLastName);
            //}
            
            
        }
        public static Person FindMother(string firstName, string lastName) //hitta mor till personen
        {
            using (var db = new Database.PersonContext())
            {
                var person = db.People.FirstOrDefault(p => p.FirstName == firstName &&
                                                            p.LastName == lastName);

                if (person != null)
                {
                    var foundMother = person.MotherId;
                    var motherName = db.People.FirstOrDefault(m => m.Id == foundMother);
                    Console.WriteLine($"\n{motherName} is {person}s mother");
                }
                else Console.WriteLine("The person you searched for doesn't exist!");

                return person;
            }
        }

        public static Person SetMother(string fname, string lname, string momFirstName, string momLastName) //kontrollera och uppdatera kopplingen
        {
            using (var db = new Database.PersonContext())
            {
                var person = db.People.FirstOrDefault(p => p.FirstName == fname &&
                                                            p.LastName == lname);

                if (person != null)
                {
                    var mother = db.People.FirstOrDefault(m => m.FirstName == momFirstName &&
                                                            m.LastName == momLastName);

                    if (mother != null) //Om mor finns, uppdatera Id-kopplingen
                    {
                        var currentMother = person.MotherId;
                        Console.WriteLine($"\nYou just changed {person}'s mother to {mother}!");
                        person.MotherId = mother.Id;
                        db.SaveChanges();
                    }
                    else Console.WriteLine("Enter an existing person on the family tree!");
                }
                else Console.WriteLine("The person you searched for doesn't exist!");

                return person;
            }
        }
    }
}
