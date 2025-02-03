using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1720252401.Models
{
    internal class TourCity
    {
        public int TourID { get; set; }
        public int CityID { get; set; }
        public int Days { get; set; }
        public Tour Tour { get; set; }
        public City City { get; set; }
    }
}
