﻿using System.ComponentModel.DataAnnotations;

namespace AluraMovies.Dtos
{
    public class UpdateMovieTheaterDto
    {
        [Required, StringLength(60, ErrorMessage = "Movie theater can contain a maximum of 60 characters")]
        public string Name { get; set; }
    }
}
