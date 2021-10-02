namespace ByteBank.Models.Interfaces
{
    internal interface IAuthenticable
    {
        public bool Authenticate(string password);
    }
}
