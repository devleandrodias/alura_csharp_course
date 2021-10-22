using System.ComponentModel.DataAnnotations;

namespace AluraMovies.Dtos.Address
{
    public class UpdateAddressDto
    {
        [Required, StringLength(60)]
        public string Street { get; set; }

        [Required, StringLength(60)]
        public string Neighborhood { get; set; }

        [Required, Range(1, 10000)]
        public int Number { get; set; }
    }
}
