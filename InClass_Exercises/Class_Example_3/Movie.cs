using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Example_3
{
    class Movie
    {
        public string Title { get; set; }

        public List<string> Genres { get; set; }

        public int ReleaseYear { get; set; }

        public Movie()
        {
            Title = string.Empty;

            ReleaseYear = 0;

            Genres = new List<string>();
        }

        public Movie(string title, int year)
        {
            Title = title;

            ReleaseYear = year;

            Genres = new List<string>();
        }

        public Movie(string title, int year, string[] genres)
        {
            Title = title;

            ReleaseYear = year;

            Genres = new List<string>();

            foreach (string genre in genres)
            {
                Genres.Add(genre);
            }
        }

        public int Age()
        {
            DateTime today = DateTime.Now;

            int age = today.Year - ReleaseYear;

            return age;
        }

        public override string ToString()
        {
            string output = "";

            int age = Age();

            switch (age)
            {
                case 0:
                    output = $"{Title} was released in {ReleaseYear} and has the genres of: {string.Join(", ", Genres)}.";
                    break;
                case 1:
                    output = $"{Title} was released in {ReleaseYear} (which makes it {age} year old) and has the genres of: {string.Join(", ", Genres)}.";
                    break;
                default:
                    output = $"{Title} was released in {ReleaseYear} (which makes it {age} years old) and has the genres of: {string.Join(", ", Genres)}.";
                    break;
            }

            return output;
        }
    }
}
