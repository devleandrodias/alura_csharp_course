using System.ComponentModel.DataAnnotations;

namespace AluraAuth.Dtos
{
    public class ConfirmEmailDto
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public string ConfirmationCode { get; set; }
    }
}
