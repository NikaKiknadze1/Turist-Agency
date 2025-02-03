using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1720252401.Models
{
    internal class City
    {
        public int CityID { get; set; }
        public int CountryID { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
    }
}
