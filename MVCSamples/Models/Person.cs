using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSamples.Models
{
    public class Person : ModelBase
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public Occupation Occupation { get; set; }

        public Address HomeAddress { get; set; }
    }
}
