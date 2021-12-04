using Inlämning2_Tiia.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2_Tiia
{
    class PersonCrud
    {
        internal void Start()
        {
            var firstName = "";
            var lastName = "";
            var id = 0;

            Console.WriteLine("Enter persons first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter persons last name: ");
            lastName = Console.ReadLine();
            CreatePerson(firstName, lastName);
        }

        public static Person CreatePerson(string firstName, string lastName)
        {
            using (var db = new PersonContext())
            {
                var person = db.People.
                            FirstOrDefault(
                                p => p.FirstName == firstName && // Sök på namnet
                                p.LastName == lastName
                                );
                if (person == null) // om personen inte finns, skapa den
                {
                    person = new Person { FirstName = firstName, LastName = lastName };
                    db.People.Add(person);
                    db.SaveChanges(); // objektet uppdateras med ID efter save
                }
                return person;
            }
        }

        public static Person FindPerson(int id)
        {
            using (var db = new PersonContext())
            {
                var person = db.People.
                            FirstOrDefault(
                                p => p.Id == id); //sök på Id
                if (person == null)
                {
                    Console.WriteLine("There is no persons with this Id");
                }
                else
                {
                    Console.WriteLine($"The person at Id {id} is {person.FirstName} {person.LastName}");
                }
                return person;
            }
        }

        public static Person FindPerson(string firstName, string lastName)
        {
            using (var db = new PersonContext())
            {
                var person = db.People.Where(p => p.FirstName.Contains(firstName) ||
                                            p.LastName.Contains(lastName));

                if (person == null)
                {
                    Console.WriteLine("There is no persons with this name");
                }
                else
                {
                    DisplayList(firstName, lastName)
                }
                return person;
            }
        }

        public void GetMother(string firstName)
        {
            //Fråga efter ett namn
            using (var db = new PersonContext())
            {
                Console.WriteLine("Enter the first name of the person: ");
                var person = db.People.
                            FirstOrDefault(
                                p => p.FirstName == firstName); //sök på Id
                if (person == null)
                {
                    Console.WriteLine("There is no persons with that name");
                }
                else
                {
                    Console.WriteLine($"The person at Id {id} is {person.FirstName} {person.LastName}");
                }
            }

            Console.WriteLine("Enter the first name of the person: ");
            var person = db.People.
                        FirstOrDefault(
                            p => p.FirstName == firstName); //sök på Id
            if (person == null)
            {
                Console.WriteLine("There is no persons with that name");
            }
            else
            {
                Console.WriteLine($"The person at Id {id} is {person.FirstName} {person.LastName}");
            }
            return person;

            //Avbryt om det är tomt

            //Fråga efter förälders namn


            //Avbryt om det är tom

            //Sök namn

            //Koppla föräldrer till personen
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


        //public void Delete(int id)
        //{

        //}

        private static void DisplayList(List<Person> people, string name)
        {
            Console.WriteLine(name);
            foreach (var person in people.OrderBy(n => n.LastName).ThenBy(n => n.FirstName))
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
        }
    }
}
