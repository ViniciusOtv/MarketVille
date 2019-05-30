using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string UF { get; set; }

        public string Country { get; set; }
    }
}
