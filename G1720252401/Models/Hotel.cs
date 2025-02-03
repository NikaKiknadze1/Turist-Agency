using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1720252401.Models
{
    internal class Hotel
    {
        public int HotelID { get; set; }
        public int CityID { get; set; }
        public string Name { get; set; }
        [Range(1, 5, ErrorMessage = "Stars must be between 1 and 5")]
        public int Stars { get; set; }
        public decimal PricePerNight { get; set; }
        public bool MealIncluded { get; set; }
        public string AdditionalServices { get; set; }
        public City City { get; set; }
    }
}
