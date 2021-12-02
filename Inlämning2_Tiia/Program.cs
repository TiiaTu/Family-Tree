using Inlämning2_Tiia.Database;
using System;

namespace Inlämning2_Tiia
{
    class Program
    {
        static void Main(string[] args)
        {
            //instansiera och starta familjeträdet
          
            Console.WriteLine("Enter a first name of a person: ");
            var fname = Console.ReadLine();
            Console.WriteLine("Enter a last name of a person: ");
            var lname = Console.ReadLine();
            var person = PersonCrud.CreateAndFind(fname, lname);

            //using (var db = new PersonContext())
            //{
            //    db.Persons.Add(
            //        new Models.Person { FirstName = "Ned", LastName = "Stark" }
            //    );
          
            //    db.SaveChanges();
            //}
            
        }
    }
}
