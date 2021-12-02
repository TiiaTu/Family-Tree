using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2_Tiia
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("MotherId")]
        public Person Mother { get; set; }

        [ForeignKey("FatherId")]
        public Person Father { get; set; }
    }
}
