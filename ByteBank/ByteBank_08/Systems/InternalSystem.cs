using ByteBank_08.Interfaces;
using System;

namespace ByteBank_08.Systems
{
    internal static class InternalSystem
    {
        public static bool SignIn(IAuthenticable employee, string password)
        {
            bool isAuthenticated = employee.Authenticate(password);

            if (isAuthenticated)
            {
                Console.WriteLine("Welcome the internal system...");
                return true;
            }

            else
            {
                Console.WriteLine("Incorrect password...");
                return false;
            }
        }
    }
}
