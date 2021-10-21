using System.ComponentModel.DataAnnotations;

namespace AluraMovies.Dtos
{
    public class UpdateManagerDto
    {
        [Required, StringLength(100)]
        public string Name { get; set; }
    }
}
