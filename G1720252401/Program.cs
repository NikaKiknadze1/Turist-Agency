using Microsoft.EntityFrameworkCore;

namespace G1720252401
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using( var context = new MyDbContext())
            {
                var countries = context.Countries.ToList();
                foreach (var country in countries)
                {
                    Console.WriteLine(country.Name);
                }
            }
            using (var context = new MyDbContext())
            {
                var mostPopularTour = context.Tours
                    .OrderByDescending(t => t.TouristTours.Count)
                    .FirstOrDefault();

                if (mostPopularTour != null)
                {
                    Console.WriteLine($"Most Popular Tour: {mostPopularTour.Name} ({mostPopularTour.Code})");
                    Console.WriteLine($"Total Tourists Visited: {mostPopularTour.TouristTours?.Count??0}");//ratom ar moaqvs bazidan informacia
                }
                else
                {
                    Console.WriteLine("No tours found.");
                }
            }


        }
    }
}
