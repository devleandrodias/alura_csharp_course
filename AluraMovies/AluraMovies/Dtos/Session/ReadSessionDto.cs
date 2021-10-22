using System;

namespace AluraMovies.Dtos.Session
{
    public class ReadSessionDto
    {
        public int Id { get; set; }

        public Models.MovieTheater MovieTheater { get; set; }

        public Models.Movie Movie { get; set; }

        public DateTime ClosingTime { get; set; }

        public DateTime OpeningTime { get; set; }
    }
}
