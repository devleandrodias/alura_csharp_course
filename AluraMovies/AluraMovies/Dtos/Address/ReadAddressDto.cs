namespace AluraMovies.Dtos.Address
{
    public class ReadAddressDto
    {
        public int Id { get; set; }

        public string Street { get; set; }

        public string Neighborhood { get; set; }

        public int Number { get; set; }

        public virtual Models.MovieTheater MovieTheater { get; set; }
    }
}
