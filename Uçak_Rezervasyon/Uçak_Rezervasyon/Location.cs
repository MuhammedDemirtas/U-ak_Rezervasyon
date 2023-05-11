using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uçak_Rezervasyon
{
    internal class Location
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Airport { get; set; }

            public Location(string country, string city, string airport)
            {
                Country = country;
                City = city;
                Airport = airport;
            }

                public override string ToString()
                {
                    return $"{Country} ({City}) | {Airport} ";
                }
    }
}
