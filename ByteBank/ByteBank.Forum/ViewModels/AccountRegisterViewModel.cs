using System.ComponentModel.DataAnnotations;

namespace ByteBank.Forum.ViewModels
{
    public class AccountRegisterViewModel
    {
        [Required]
        [Display(Name = "Full name")]
        public string Name { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

