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
        public static Person CreateAndFind(string firstName, string lastName)
        {
            using (var db = new PersonContext())
            {
                var person = db.Persons.
                            FirstOrDefault(
                                h => h.FirstName == firstName && // Sök på namnet
                                h.LastName == lastName
                                );
                if (person == null) // om personen inte finns, skapa den
                {
                    person = new Person { FirstName = firstName, LastName = lastName };
                    db.Persons.Add(person);
                    db.SaveChanges(); // objektet uppdateras med ID efter save
                }
                return person;
            }
        }

        public void Read(int id) { }
        public void Read(string firstName) { }
        public void Read(string firstName, string lastName) { }
        public void Update() { }
        public void Delete() { }
    }
}
