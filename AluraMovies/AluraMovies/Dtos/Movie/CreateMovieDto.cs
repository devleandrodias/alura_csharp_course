using System.ComponentModel.DataAnnotations;

namespace AluraMovies.Dtos.Movie
{
    public class CreateMovieDto
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Director is required'")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [StringLength(30, ErrorMessage = "Category cannot be longer than 30 characters")]
        public string Category { get; set; }

        [Range(1, 400, ErrorMessage = "Duration must be between 1 and 400 minutes")]
        public int Duration { get; set; }
    }
}
