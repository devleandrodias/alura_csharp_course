using System;
using System.ComponentModel.DataAnnotations;

namespace AluraMovies.Models
{
    public class Session
    {
        [Required, Key]
        public int Id { get; set; }

        public int MovieTheaterId { get; set; }

        public virtual MovieTheater MovieTheater { get; set; }

        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }

        public DateTime ClosingTime { get; set; }
    }
}
