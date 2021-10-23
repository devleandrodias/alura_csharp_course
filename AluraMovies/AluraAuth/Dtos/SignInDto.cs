using System.ComponentModel.DataAnnotations;

namespace AluraAuth.Dtos
{
    public class SignInDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
