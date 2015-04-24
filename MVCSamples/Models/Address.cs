using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSamples.Models
{
    public class Address : ModelBase
    {
        public string Street { get; set; }

        public string District { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }
    }
}
