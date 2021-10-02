using ByteBank.Models.Interfaces;

namespace ByteBank.Models
{
    internal class CommercialPartner : IAuthenticable
    {
        public string Password { get; set; }

        public bool Authenticate(string password) => Password == password;
    }
}
