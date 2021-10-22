using System;
using System.ComponentModel.DataAnnotations;

namespace AluraMovies.Dtos.Session
{
    public class UpdateSessionDto
    {
        [Required]
        public int MovieId { get; set; }

        [Required]
        public int MovieTheaterId { get; set; }

        [Required]
        public DateTime ClosingTime { get; set; }
    }
}
