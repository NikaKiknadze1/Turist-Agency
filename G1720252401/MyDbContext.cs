using G1720252401.Entities;
using G1720252401.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace G1720252401
{
    internal class MyDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        //public DbSet<City> Cities { get; set; }
        //public DbSet<Hotel> Hotels { get; set; }
        //public DbSet<Tour> Tours { get; set; }
        //public DbSet<TourCity> TourCities { get; set; }
        //public DbSet<Tourist> Tourists { get; set; }
        //public DbSet<TouristTour> TouristTours { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Database=G17_TouristAgancy.db"); /*Integrated Security=True; trustservercertificate = true; pooling = true;*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>();
            //modelBuilder.Entity<TourCity>().HasKey(tc => new { tc.TourID, tc.CityID });
            //modelBuilder.Entity<TouristTour>().HasKey(tt => new { tt.TourID, tt.TouristID });
        }


    //    public static void Seed(MyDbContext context)
    //    {
    //        var countries = new List<Country>
    //{
    //    new Country { CountryID = 1, Name = "Georgia" },
    //    new Country { CountryID = 2, Name = "Italy" },
    //    new Country { CountryID = 3, Name = "France" },
    //    new Country { CountryID = 4, Name = "Spain" },
    //    new Country { CountryID = 5, Name = "USA" }
    //};
    //        context.Countries.AddRange(countries);

    //        var cities = new List<City>
    //{
    //    new City { CityID = 1, CountryID = 1, Name = "Tbilisi" },
    //    new City { CityID = 2, CountryID = 1, Name = "Batumi" },
    //    new City { CityID = 3, CountryID = 2, Name = "Rome" },
    //    new City { CityID = 4, CountryID = 2, Name = "Florence" },
    //    new City { CityID = 5, CountryID = 3, Name = "Paris" },
    //    new City { CityID = 6, CountryID = 3, Name = "Nice" },
    //    new City { CityID = 7, CountryID = 4, Name = "Barcelona" },
    //    new City { CityID = 8, CountryID = 4, Name = "Madrid" },
    //    new City { CityID = 9, CountryID = 5, Name = "New York" },
    //    new City { CityID = 10, CountryID = 5, Name = "Los Angeles" }
    //};
    //        context.Cities.AddRange(cities);

    //        // Hotels
    //        var hotels = new List<Hotel>
    //{
    //    new Hotel { HotelID = 1, CityID = 1, Name = "Hotel Tbilisi", Stars = 5, PricePerNight = 200.00M, MealIncluded = true, AdditionalServices = "Laundry,WiFi,Satellite TV" },
    //    new Hotel { HotelID = 2, CityID = 2, Name = "Hotel Batumi", Stars = 4, PricePerNight = 150.00M, MealIncluded = false, AdditionalServices = "WiFi,Swimming Pool" },
    //    new Hotel { HotelID = 3, CityID = 3, Name = "Hotel Rome", Stars = 5, PricePerNight = 250.00M, MealIncluded = true, AdditionalServices = "Gym,WiFi,Restaurant" },
    //    // add more hotels...
    //};
    //        context.Hotels.AddRange(hotels);

    //        // Tours
    //        var tours = new List<Tour>
    //{
    //    new Tour { TourID = 1, Code = "T001", Name = "Rome and Florence Tour", Duration = 7, TotalPrice = 1500.00M },
    //    new Tour { TourID = 2, Code = "T002", Name = "Paris and Nice Tour", Duration = 6, TotalPrice = 1400.00M },
    //    // add more tours...
    //};
    //        context.Tours.AddRange(tours);

    //        // TourCities
    //        var tourCities = new List<TourCity>
    //{
    //    new TourCity { TourID = 1, CityID = 3, Days = 4 },
    //    new TourCity { TourID = 1, CityID = 4, Days = 3 },
    //    // add more tour cities...
    //};
    //        context.TourCities.AddRange(tourCities);

    //        // Tourists
    //        var tourists = new List<Tourist>
    //{
    //    new Tourist { TouristID = "12345678901", FirstName = "John", LastName = "Doe", BirthDate = new DateTime(1980, 1, 1), ContactPhone = "+1234567890" },
    //    new Tourist { TouristID = "12345678902", FirstName = "Jane", LastName = "Smith", BirthDate = new DateTime(1990, 2, 2), ContactPhone = "+1234567891" },
    //    // add more tourists...
    //};
    //        context.Tourists.AddRange(tourists);

    //        // TouristTours
    //        var touristTours = new List<TouristTour>
    //        {
    //            new TouristTour { TouristID = "12345678901", TourID = 1, DepartureDate = new DateTime(2023, 1, 1), ReturnDate = new DateTime(2023, 1, 8) },
    //            new TouristTour { TouristID = "12345678902", TourID = 2, DepartureDate = new DateTime(2023, 2, 1), ReturnDate = new DateTime(2023, 2, 7) },
    //            // add more tourist tours...
    //        };
    //    }

    }
}
