using Inlämning2_Tiia.Database;
using System;
using System.Collections.Generic;

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
            //using (var db = new PersonContext())
            //{
            //    db.People.Add(
            //        new Person { FirstName = "Robb", LastName = "Stark", Mother=null, Father=null }
            //        );

            //    db.SaveChanges();
            //}

            using (var db = new PersonContext())
            {
                //var newPerson = db.People.Add(new Person { FirstName = "Sansa", LastName = "Stark" });

//                IList<Person> newpeople = new List<Person>() {
//                                    new Person(){
//                                        //ID = 1,
//                                        FirstName = "Catelyn",
//                                        LastName = "Tully",
//                                        MotherId = null,
//                                        FatherId = null,
//                                    },
//                                    new Person(){
//                                        //ID = 2,
//                                        FirstName = "Eddard Stark",
//                                        LastName = "",
//                                        MotherId = null,
//                                        FatherId = null,

//db.Add(newpeople);
//                db.SaveChanges();
            }



        }
    }
}
