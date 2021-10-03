using ByteBank.Models.Interfaces;

namespace ByteBank.Models
{
    internal class CommercialPartner : IAuthenticable
    {
        private readonly AuthenticationHelper _authenticationHelper = new();

        public string Password { get; set; }

        public bool Authenticate(string password)
        {
            return _authenticationHelper.ComparePasswords(Password, password);
        }
    }
}
