using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSamples.Models
{
    public class Occupation : ModelBase
    {
        public string JobTitle { get; set; }

        public decimal Salary { get; set; }
    }
}
