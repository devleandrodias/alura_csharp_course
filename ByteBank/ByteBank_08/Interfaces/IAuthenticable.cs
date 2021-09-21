namespace ByteBank_08.Interfaces
{
    internal interface IAuthenticable
    {
        public bool Authenticate(string password);
    }
}
