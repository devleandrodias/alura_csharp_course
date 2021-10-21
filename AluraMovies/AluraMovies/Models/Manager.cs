using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AluraMovies.Models
{
    public class Manager
    {
        [Required, Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [JsonIgnore]
        public virtual List<MovieTheater> MoviesTheaters { get; set; }
    }
}
