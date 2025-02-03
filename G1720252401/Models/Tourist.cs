using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1720252401.Models
{
    internal class Tourist
    {
        public int TouristID { get; set; }
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Personal Number Should Be 11 Symbols")]
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string ContactPhone { get; set; }
        public ICollection<TouristTour> TouristTours { get; set; } = new List<TouristTour>();
    }
}
