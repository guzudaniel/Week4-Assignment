using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week4.Models
{
    public class Movie
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public int Year { get; set; }
    }
}
