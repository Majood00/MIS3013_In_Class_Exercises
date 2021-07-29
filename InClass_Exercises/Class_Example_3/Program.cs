using System;

namespace Class_Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie();
            movie1.Title = "Jungle Cruise";
            movie1.ReleaseYear = 2021;
            movie1.Genres.Add("Action");
            movie1.Genres.Add("Adventure");
            movie1.Genres.Add("Comedy");

            Movie movie2 = new Movie("Free Guy", 2021);
            movie2.Genres.Add("Comedy");
            movie2.Genres.Add("Action");
            movie2.Genres.Add("Sci-Fi");

            string[] genres = { "Action", "Drama", "Adventure" };

            Movie movie3 = new Movie("Avengers: End Game", 2019, genres);

            Console.WriteLine(movie1);
            Console.WriteLine(movie2);
            Console.WriteLine(movie3);

            
        }
    }
}
