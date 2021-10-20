using System.ComponentModel.DataAnnotations;

namespace AluraMovies.Models
{
    public class Address    
    {
        [Required, Key]
        public int Id { get; set; }

        [Required, StringLength(60)]
        public string Street { get; set; }

        [Required, StringLength(60)]
        public string Neighborhood { get; set; }

        [Required, Range(1, 10000)]
        public int Number { get; set; }
    }
}
