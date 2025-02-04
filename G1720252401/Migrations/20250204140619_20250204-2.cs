using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace G1720252401.Migrations
{
    /// <inheritdoc />
    public partial class _202502042 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Tourist_TouristID",
                table: "Tourists");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CountryID", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Tbilisi" },
                    { 2, 1, "Batumi" },
                    { 3, 2, "Rome" },
                    { 4, 2, "Florence" },
                    { 5, 3, "Paris" },
                    { 6, 3, "Nice" },
                    { 7, 4, "Barcelona" },
                    { 8, 4, "Madrid" },
                    { 9, 5, "New York" },
                    { 10, 5, "Los Angeles" }
                });

            migrationBuilder.InsertData(
                table: "Tourists",
                columns: new[] { "TouristID", "BirthDate", "ContactPhone", "FirstName", "LastName", "PassportNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "+1234567890", "John", "Doe", "12345678901" },
                    { 2, new DateTime(1990, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "+1234567891", "Jane", "Smith", "12345678902" }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "TourID", "Code", "Duration", "Name", "TotalPrice" },
                values: new object[,]
                {
                    { 1, "T0011", 7, "Rome and Florence Tour", 1500.00m },
                    { 2, "T0022", 6, "Paris and Nice Tour", 1400.00m }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelID", "AdditionalServices", "CityID", "MealIncluded", "Name", "PricePerNight", "Stars" },
                values: new object[,]
                {
                    { 1, "Laundry,WiFi,Satellite TV", 1, true, "Hotel Tbilisi", 200.00m, 5 },
                    { 2, "WiFi,Swimming Pool", 2, false, "Hotel Batumi", 150.00m, 4 },
                    { 3, "Gym,WiFi,Restaurant", 3, true, "Hotel Rome", 250.00m, 5 }
                });

            migrationBuilder.InsertData(
                table: "TourCities",
                columns: new[] { "CityID", "TourID", "Days" },
                values: new object[,]
                {
                    { 3, 1, 4 },
                    { 4, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "TouristTours",
                columns: new[] { "TourID", "TouristID", "DepartureDate", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.AddCheckConstraint(
                name: "CK_Tourist_PassportNumber",
                table: "Tourists",
                sql: "LEN(PassportNumber) = 11");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Tourist_PassportNumber",
                table: "Tourists");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TourCities",
                keyColumns: new[] { "CityID", "TourID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "TourCities",
                keyColumns: new[] { "CityID", "TourID" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "TouristTours",
                keyColumns: new[] { "TourID", "TouristID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TouristTours",
                keyColumns: new[] { "TourID", "TouristID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tourists",
                keyColumn: "TouristID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tourists",
                keyColumn: "TouristID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourID",
                keyValue: 2);

            migrationBuilder.AddCheckConstraint(
                name: "CK_Tourist_TouristID",
                table: "Tourists",
                sql: "LEN(TouristID) = 11");
        }
    }
}
