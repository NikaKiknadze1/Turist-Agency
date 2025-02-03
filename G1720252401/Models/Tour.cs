using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1720252401.Models
{
    internal class Tour
    {
        public int TourID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<TourCity> TourCities { get; set; }
    }
}
