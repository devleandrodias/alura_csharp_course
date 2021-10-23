using System.ComponentModel.DataAnnotations;

namespace AluraAuth.Dtos
{
    public class SignUpDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, Compare(nameof(Password))]
        public string RePassword { get; set; }
    }
}
