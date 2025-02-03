using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace G1720252401.Models
{
    internal class Country
    {
        public int CountryID { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<City> Cities { get; set; }
    }
}
