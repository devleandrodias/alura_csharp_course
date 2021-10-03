namespace ByteBank.Models
{
    internal class AuthenticationHelper
    {
        internal bool ComparePasswords(string password, string tryPassword)
        {
            return password.Equals(tryPassword);
        }
    }
}
