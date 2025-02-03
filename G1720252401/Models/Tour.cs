using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1720252401.Models
{
    internal class Tour
    {
        
        public int TourID { get; set; }
        [StringLength(5, MinimumLength = 5, ErrorMessage ="Code length should be 5 symbols")]
        public string Code { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<TourCity> TourCities { get; set; }
    }
}
