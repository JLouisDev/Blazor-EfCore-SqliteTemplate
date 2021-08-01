using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_EfCore_SqliteTemplate.Entities
{
    public class Car
    {
        // Property named Id is apicked up as the primary key by default.
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string ModelYear { get; set; }
        public decimal Msrp { get; set; }
    }
}
