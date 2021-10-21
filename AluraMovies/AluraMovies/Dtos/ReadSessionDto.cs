using AluraMovies.Models;
using System;

namespace AluraMovies.Dtos
{
    public class ReadSessionDto
    {
        public int Id { get; set; }

        public MovieTheater MovieTheater { get; set; }

        public Movie Movie { get; set; }

        public DateTime ClosingTime { get; set; }

        public DateTime OpeningTime { get; set; }
    }
}
