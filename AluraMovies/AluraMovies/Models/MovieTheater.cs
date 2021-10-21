using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AluraMovies.Models
{
    public class MovieTheater
    {
        [Key, Required]
        public int Id { get; set; }

        [Required, StringLength(60, ErrorMessage = "Movie theater can contain a maximum of 60 characters")]
        public string Name { get; set; }

        public virtual Address Address { get; set; }

        public int AddressId { get; set; }

        public virtual Manager Manager { get; set; }

        public int ManagerId { get; set; }

        [JsonIgnore]
        public virtual List<Session> Sessions { get; set; }
    }
}
