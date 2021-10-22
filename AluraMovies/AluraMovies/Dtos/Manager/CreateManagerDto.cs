using System.ComponentModel.DataAnnotations;

namespace AluraMovies.Dtos.Manager
{
    public class CreateManagerDto
    {
        [Required, StringLength(100)]
        public string Name { get; set; }
    }
}
