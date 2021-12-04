using Inlämning2_Tiia.Database;
using System;

namespace Inlämning2_Tiia
{
    class Program
    {
        static void Main(string[] args)
        {
            //instansiera och starta familjeträdet

            //var start = new PersonCrud();
            //start.Start();
          
            //Console.WriteLine("Enter a first name of a person: ");
            //var fname = Console.ReadLine();
            //Console.WriteLine("Enter a last name of a person: ");
            //var lname = Console.ReadLine();
            //var person = PersonCrud.CreatePerson(fname, lname);

            //var person2 =
            using (var db = new PersonContext())
            {
                db.People.Add(
                    new Person { FirstName = "Robb", LastName = "Stark", Mother=null, Father=null }
                    );

                db.SaveChanges();
            }

        }
    }
}
