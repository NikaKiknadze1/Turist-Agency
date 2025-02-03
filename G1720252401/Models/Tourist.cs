using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1720252401.Models
{
    internal class Tourist
    {
        public string TouristID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string ContactPhone { get; set; }
        public ICollection<TouristTour> TouristTours { get; set; }
    }
}
