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
            using (var db = new PersonContext())
            {
                Utils.Helper.PeopleInDatabase.PersonsAdded(); //lägger till alla personer till listan
                db.SaveChanges();
            }
        }



        //--------------skapa en person med för- och efternamn
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

        //---------------söker en person på Id-----------------------
        public static Person FindPerson(int id)
        {
            using (var db = new PersonContext())
            {
                var person = db.People.
                            FirstOrDefault(
                                p => p.Id == id);

                if (person == null)
                {
                    Console.WriteLine("There is no person with this Id");
                }
                else
                {
                    Console.WriteLine($"The person at Id {id} is {person.FirstName} {person.LastName}");
                }
                return person;
            }
        }

        //public static Person findperson(string firstname, string lastname)
        //{
        //    using (var db = new Personcontext())
        //    {
        //        var person = db.people.where(p => p.firstname.contains(firstname) ||
        //                                    p.lastname.contains(lastname));

        //        if (person == null)
        //        {
        //            console.writeline("there is no persons with this name");
        //        }
        //        else
        //        {
        //            displaylist(firstname, lastname)
        //        }
        //        return person;

        //    }
        //}
        public void FindParents(string firstName, string lastName)
        {
            public void GetMother(string firstName) //TODO: gör en likadan till fatherId
            {
                //Fråga efter ett namn
                using (var db = new PersonContext())
                {
                    Console.WriteLine("Enter the first name of the person: ");
                    var person = db.People.
                                FirstOrDefault(
                                    p => p.FirstName == firstName); //sök på förnamn
                    if (person == null)
                    {
                        Console.WriteLine("There is no persons with that name");
                    }
                    else
                    {
                        Console.WriteLine($"The is {person.FirstName} {person.LastName}");
                    }
                }
            }
            public static Person FindMother(string fname, string lname)
            {
                using (var db = new PersonContext())
                {
                    var person = db.People.FirstOrDefault(p => p.FirstName == fname && p.LastName == lname);
                    if (person != null)
                    {
                        var currentMother = person.MotherId;
                        var currentMotherName = db.People.FirstOrDefault(mom => mom.Id == currentMother);
                        Console.WriteLine($"\n{person}s current mother is {currentMotherName}");
                    }
                    else Console.WriteLine("The person you searched for doesn't exist!");
                    return person;
                }
            }

            //public static Person SetMother(string fname, string lname, string mfname, string mlname)
            //{
            //    using (var db = new PersonContext())
            //    {
            //        //Sök person, hämta ID
            //        var person = db.People.FirstOrDefault(p => p.FirstName == fname && p.LastName == lname);
            //        if (person != null)
            //        {
            //            //Sök persons mamma, hämta mamma ID
            //            var mom = db.People.FirstOrDefault(m => m.FirstName == mfname && m.LastName == mlname);

            //            if (mom != null) //Om mor finns, uppdatera ID kopplingen
            //            {
            //                var currentMother = person.MotherId;
            //                Console.WriteLine($"\nYou just changed {person}'s mother to {mom}!");
            //                person.MotherId = mom.ID;
            //                db.SaveChanges();
            //            }
            //            else Console.WriteLine($"You have to enter a person that exist in the family tree to become {fname} {lname}'s mom!");
            //        }
            //        else Console.WriteLine("The person you searched for doesn't exist!");
            //        return person;
            //    }
            //}

            //public static Person FindFather(string fname, string lname)
            //{
            //    using (var db = new PersonContext())
            //    {
            //        var person = db.People.FirstOrDefault(p => p.FirstName == fname && p.LastName == lname);
            //        if (person != null)
            //        {
            //            var currentFather = person.MotherId;
            //            var currentFatherName = db.People.FirstOrDefault(mom => mom.ID == currentFather);
            //            Console.WriteLine($"\n{person}s current mother is {currentFatherName}");
            //        }
            //        else Console.WriteLine("The person you searched for doesn't exist!");
            //        return person;
            //    }
            //}

            //public static Person SetFather(string fname, string lname, string mfname, string mlname)
            //{
            //    using (var db = new PersonContext())
            //    {
            //        //Sök person, hämta ID
            //        var person = db.People.FirstOrDefault(p => p.FirstName == fname && p.LastName == lname);
            //        if (person != null)
            //        {
            //            //Sök persons mamma, hämta mamma ID
            //            var dad = db.People.FirstOrDefault(m => m.FirstName == mfname && m.LastName == mlname);

            //            if (dad != null) //Om mor finns, uppdatera ID kopplingen
            //            {
            //                var currentMother = person.MotherId;
            //                Console.WriteLine($"\nYou just changed {person}'s mother to {mom}!");
            //                person.MotherId = dad.ID;
            //                db.SaveChanges();
            //            }
            //            else Console.WriteLine($"You have to enter a person that exist in the family tree to become {fname} {lname}'s mom!");
            //        }
            //        else Console.WriteLine("The person you searched for doesn't exist!");
            //        return person;
            //    }
            //}
        }


        //public void Read(string firstName, string lastName)
        //{
        //    using (var db = new PersonContext())
        //    {
        //        var person = db.Persons.Where(p => p.FirstName.Contains(firstName))
        //            .ToList(); ; //sök på Id

        //        if (person == null)
        //        {
        //            Console.WriteLine("There is no persons on this Id");
        //        }
        //        else
        //        {
        //            foreach (var item in db.Persons)
        //            {

        //            }
        //        }
        //        return person;
        //    }
        //}
        //public void Update()
        //{

        //}
        //public void Delete(Person)
        //{
        //    using (var db = new PersonContext())
        //    {
        //        var person = db.People.
        //                    FirstOrDefault(
        //                        p => p.FirstName == firstName && // Sök på namnet
        //                        p.LastName == lastName
        //                        );
        //        if (person == null) // om personen inte finns, skapa den
        //        {
        //            person = new Person { FirstName = firstName, LastName = lastName };
        //            db.People.Add(person);
        //            db.SaveChanges(); // objektet uppdateras med ID efter save
        //        }
        //        return person;


        //        public void Delete(int id)
        //        {

        //        }

        //        private static void DisplayList(List<Person> people, string name)
        //        {
        //            Console.WriteLine(name);
        //            foreach (var person in people.OrderBy(n => n.LastName).ThenBy(n => n.FirstName))
        //            {
        //                Console.WriteLine(person);
        //            }
        //            Console.WriteLine();
        //        }
        //    }
    }
}
