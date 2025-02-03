using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1720252401.Models
{
    internal class TouristTour
    {
        public string TouristID { get; set; }
        public int TourID { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Tourist Tourist { get; set; }
        public Tour Tour { get; set; }
    }
}
