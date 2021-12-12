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
            using (var checker = new PersonContext())
            {
                int rows = checker.People.Count();
                
                if (rows == 0)
                {
                    using (var db = new PersonContext())
                    {                        
                        db.People.Add(new Person // ID = 1
                        {
                            FirstName = "Rhaegar",
                            LastName = "Targaryen",
                            MotherId = 6,
                            FatherId = 5,
                        });

                        db.People.Add(new Person // ID = 2
                        {
                            FirstName = "Viserys",
                            LastName = "Targaryen",
                            MotherId = 6,
                            FatherId = 5,
                        });
                        
                        db.People.Add(new Person // ID = 3
                        {
                            FirstName = "Daenerys",
                            LastName = "Targaryen",
                            MotherId = 6,
                            FatherId = 5,
                        }); 
                        
                        db.People.Add(new Person // ID = 4
                        {
                            FirstName = "Elia",
                            LastName = "Martell",
                            MotherId = null,
                            FatherId = null,
                        }); 
                        
                        db.People.Add(new Person // ID = 5
                        {
                            FirstName = "Aerys",
                            LastName = "Targaryen",
                            MotherId = null,
                            FatherId = null,
                        });

                        db.People.Add(new Person // ID = 6
                        {
                            FirstName = "Rhaella",
                            LastName = "Targaryen",
                            MotherId = null,
                            FatherId = null,
                        });

                        db.People.Add(new Person // ID = 7
                        {
                            FirstName = "Lyanna",
                            LastName = "Stark",
                            MotherId = null,
                            FatherId = null,
                        });

                        db.People.Add(new Person // ID = 8
                        {
                            FirstName = "Jon",
                            LastName = "Snow",
                            MotherId = 7,
                            FatherId = 1,
                        });

                        db.People.Add(new Person // ID = 9
                        {
                            FirstName = "Rhaenys",
                            LastName = "Targaryen",
                            MotherId = 4,
                            FatherId = 1,
                        });

                        db.People.Add(new Person // ID = 10
                        {
                            FirstName = "Aegon",
                            LastName = "Targaryen",
                            MotherId = 4,
                            FatherId = 1,
                        });
                        
                        db.SaveChanges();
                    }

                    checker.SaveChanges();

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
            }
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
