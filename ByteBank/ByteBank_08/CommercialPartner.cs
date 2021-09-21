using ByteBank_08.Interfaces;

namespace ByteBank_08
{
    internal class CommercialPartner : IAuthenticable
    {
        public string Password { get; set; }

        public bool Authenticate(string password) => Password == password;
    }
}
