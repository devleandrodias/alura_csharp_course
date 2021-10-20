using System.ComponentModel.DataAnnotations;

namespace AluraMovies.Models
{
    public class MovieTheater
    {
        [Key, Required]
        public int Id { get; set; }

        [Required, StringLength(60, ErrorMessage = "Movie theater can contain a maximum of 60 characters")]
        public string Name { get; set; }
    }
}
