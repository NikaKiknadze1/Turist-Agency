using G1720252401.Models;
using Microsoft.EntityFrameworkCore;

namespace G1720252401
{
    internal class MyDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourCity> TourCities { get; set; }
        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<TouristTour> TouristTours { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=G17_TouristAgancy.db; Integrated Security=True; trustservercertificate = true; pooling = true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasKey(c => c.CountryID);
            modelBuilder.Entity<City>()
                .HasOne(c => c.Country)
                .WithMany(c => c.Cities)
                .HasForeignKey(c => c.CountryID);
            modelBuilder.Entity<Hotel>()
                .HasCheckConstraint("CK_Hotel_Stars", "Stars between 1 and 5");
            modelBuilder.Entity<Tour>()
                .HasCheckConstraint("CK_Tour_Code", "LEN(Code) = 5");
            modelBuilder.Entity<TourCity>()
                .HasKey(tc => new { tc.TourID, tc.CityID });
            modelBuilder.Entity<Tourist>()
                .HasCheckConstraint("CK_Tourist_PassportNumber", "LEN(PassportNumber) = 11")
                .HasIndex(t => t.PassportNumber)
                .IsUnique();
            modelBuilder.Entity<TouristTour>()
                .HasKey(tt => new { tt.TourID, tt.TouristID });

            modelBuilder.Entity<Country>().HasData(
                new Country { CountryID = 1, Name = "Georgia" },
                new Country { CountryID = 2, Name = "Italy" },
                new Country { CountryID = 3, Name = "France" },
                new Country { CountryID = 4, Name = "Spain" },
                new Country { CountryID = 5, Name = "USA" }
            );

            modelBuilder.Entity<City>().HasData(
                new City { CityID = 1, CountryID = 1, Name = "Tbilisi" },
                new City { CityID = 2, CountryID = 1, Name = "Batumi" },
                new City { CityID = 3, CountryID = 2, Name = "Rome" },
                new City { CityID = 4, CountryID = 2, Name = "Florence" },
                new City { CityID = 5, CountryID = 3, Name = "Paris" },
                new City { CityID = 6, CountryID = 3, Name = "Nice" },
                new City { CityID = 7, CountryID = 4, Name = "Barcelona" },
                new City { CityID = 8, CountryID = 4, Name = "Madrid" },
                new City { CityID = 9, CountryID = 5, Name = "New York" },
                new City { CityID = 10, CountryID = 5, Name = "Los Angeles" }
            );

            modelBuilder.Entity<Hotel>().HasData(

                new Hotel { HotelID = 1, CityID = 1, Name = "Hotel Tbilisi", Stars = 5, PricePerNight = 200.00M, MealIncluded = true, AdditionalServices = "Laundry,WiFi,Satellite TV" },
                new Hotel { HotelID = 2, CityID = 2, Name = "Hotel Batumi", Stars = 4, PricePerNight = 150.00M, MealIncluded = false, AdditionalServices = "WiFi,Swimming Pool" },
                new Hotel { HotelID = 3, CityID = 3, Name = "Hotel Rome", Stars = 5, PricePerNight = 250.00M, MealIncluded = true, AdditionalServices = "Gym,WiFi,Restaurant" }
            );

            modelBuilder.Entity<Tour>().HasData(
                 new Tour { TourID = 1, Code = "T0011", Name = "Rome and Florence Tour", Duration = 7, TotalPrice = 1500.00M },
                 new Tour { TourID = 2, Code = "T0022", Name = "Paris and Nice Tour", Duration = 6, TotalPrice = 1400.00M }
             );

            modelBuilder.Entity<TourCity>().HasData(
                new TourCity { TourID = 1, CityID = 3, Days = 4 },
                new TourCity { TourID = 1, CityID = 4, Days = 3 } 
            );

            modelBuilder.Entity<Tourist>().HasData(
                new Tourist { TouristID = 1, PassportNumber = "12345678901", FirstName = "John", LastName = "Doe", BirthDate = new DateTime(1980, 1, 1), ContactPhone = "+1234567890" },
                new Tourist { TouristID = 2, PassportNumber = "12345678902", FirstName = "Jane", LastName = "Smith", BirthDate = new DateTime(1990, 2, 2), ContactPhone = "+1234567891" }
            );

            modelBuilder.Entity<TouristTour>().HasData(
                new TouristTour { TouristID = 1, TourID = 1, DepartureDate = new DateTime(2023, 1, 1), ReturnDate = new DateTime(2023, 1, 8) },
                new TouristTour { TouristID = 2, TourID = 2, DepartureDate = new DateTime(2023, 2, 1), ReturnDate = new DateTime(2023, 2, 7) }
            );
        }
    }
}
