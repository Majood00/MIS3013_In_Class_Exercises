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

            Genres = new List<string>;
        }

        public int Age()
        {
            DateTime today = DateTime.Now;

            int age = today.Year - ReleaseYear;

            return age;
        }
    }
}
