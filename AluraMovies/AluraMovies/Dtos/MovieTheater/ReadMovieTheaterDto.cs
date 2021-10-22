namespace AluraMovies.Dtos.MovieTheater
{
    public class ReadMovieTheaterDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Models.Address Address { get; set; }

        public virtual Models.Manager Manager { get; set; }
    }
}
