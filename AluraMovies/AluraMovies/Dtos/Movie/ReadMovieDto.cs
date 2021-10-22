using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AluraMovies.Dtos.Movie
{
    public class ReadMovieDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public string Category { get; set; }

        public int Duration { get; set; }

        [JsonIgnore]
        public virtual List<Models.Session> Sessions { get; set; }
    }
}
