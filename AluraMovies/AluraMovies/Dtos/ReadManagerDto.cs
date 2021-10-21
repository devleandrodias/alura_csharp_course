using AluraMovies.Models;
using System.Collections.Generic;

namespace AluraMovies.Dtos
{
    public class ReadManagerDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public object MovieTheaters { get; set; }
    }
}
