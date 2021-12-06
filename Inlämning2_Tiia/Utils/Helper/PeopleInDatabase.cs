using Inlämning2_Tiia.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2_Tiia.Utils.Helper
{
    class PeopleInDatabase
    {
        public static void PersonsAdded()
        {
            using (var db = new PersonContext())
            {
                db.People.Add(new Person
                {
                    FirstName = "Rhaegar",
                    LastName = "Targaryen",
                    MotherId = 6,
                    FatherId = 5,
                });

                db.People.Add(new Person
                {
                    FirstName = "Viserys",
                    LastName = "Targaryen",
                    MotherId = 6,
                    FatherId = 5,
                });
                db.SaveChanges();
            }

            //CreatePerson("Rhaegar", "Targaryen", 6, 5); //ID = 1
            //CreatePerson("Viserys", "Targaryen", 6, 5); //ID = 2
            //CreatePerson("Daenerys", "Targaryen", 6, 5); //ID = 3
            //CreatePerson("Elia", "Martell", 0, 0);
            //CreatePerson("Aerys", "Targaryen", 0, 0);
            //CreatePerson("Rhaella", "Targaryen", 0, 0);
            //CreatePerson("Lyanna", "Stark", 0, 0);
            //CreatePerson("Jon", "Snow", 7, 1);
            //CreatePerson("Rhaenys", "Targaryen", 4, 1);
            //CreatePerson("Aegon", "Targaryen", 4, 1);
        }
        public static Person CreatePerson(string firstName, string lastName, int motherId, int fatherId)
        {

            using (var db = new PersonContext())
            {
                var person = db.People.
                            FirstOrDefault(
                                p => p.FirstName == firstName &&
                                p.LastName == lastName &&
                                p.MotherId == motherId &&
                                p.FatherId == fatherId
                                );

                if (person == null) // skapa personen om den inte finns
                {
                    person = new Person { FirstName = firstName, LastName = lastName, MotherId = motherId, FatherId = fatherId };

                    db.People.Add(person);
                    db.SaveChanges();
                }
                return person;
            }
        }


    }
}
