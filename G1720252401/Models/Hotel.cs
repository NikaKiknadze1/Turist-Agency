using System;
using System.Collections.Generic;
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
        public int Stars { get; set; }
        public decimal PricePerNight { get; set; }
        public bool MealIncluded { get; set; }
        public string AdditionalServices { get; set; }
        public City City { get; set; }
    }
}
