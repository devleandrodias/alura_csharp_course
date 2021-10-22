using System.ComponentModel.DataAnnotations;

namespace AluraMovies.Dtos.MovieTheater
{
    public class UpdateMovieTheaterDto
    {
        [Required, StringLength(60, ErrorMessage = "Movie theater can contain a maximum of 60 characters")]
        public string Name { get; set; }

        [Required]
        public int AddressId { get; set; }

        [Required]
        public int ManagerId { get; set; }
    }
}
