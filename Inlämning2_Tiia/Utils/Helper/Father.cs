using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2_Tiia.Utils.Helper
{
    class Father
    {
        //-------------------------far--------------------------------------------------

        public static Person FindFather(string firstName, string lastName)
        {
            using (var db = new Database.PersonContext())
            {
                var person = db.People.FirstOrDefault(p => p.FirstName == firstName &&
                                                            p.LastName == lastName);

                if (person != null)
                {
                    var foundFather = person.FatherId;
                    var fatherName = db.People.FirstOrDefault(d => d.Id == foundFather);

                    Console.WriteLine($"\n{fatherName} is {person}s father");
                }
                else Console.WriteLine("The person you searched for doesn't exist!");

                return person;
            }
        }

        public static Person SetFather(string firstName, string lastName, string dadFirstName, string dadLastName)
        {
            using (var db = new Database.PersonContext())
            {
                var person = db.People.FirstOrDefault(p => p.FirstName == firstName &&
                                                            p.LastName == lastName);
                if (person != null)
                {
                    //Hämta pappans Id
                    var dad = db.People.FirstOrDefault(m => m.FirstName == dadFirstName &&
                                                            m.LastName == dadLastName);

                    if (dad != null) //Om mor finns, uppdatera ID kopplingen
                    {
                        //var foundFather = person.MotherId;
                        Console.WriteLine($"\nYou just changed {person}'s father to {dad}!");

                        person.MotherId = dad.Id;
                        db.SaveChanges();
                    }
                    else Console.WriteLine($"Enter an existing person on the family tree!");
                }
                else Console.WriteLine("The person you searched for doesn't exist!");

                return person;
            }
        }
    }
}
