using System;
using System.ComponentModel.DataAnnotations;

namespace AluraMovies.Dtos
{
    public class CreateSessionDto
    {
        [Required]
        public int MovieId { get; set; }

        [Required]
        public int MovieTheaterId { get; set; }

        [Required]
        public DateTime ClosingTime { get; set; }
    }
}
