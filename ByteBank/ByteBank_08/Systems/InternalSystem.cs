using ByteBank_08.Employees;
using System;

namespace ByteBank_08.Systems
{
    internal static class InternalSystem
    {
        public static bool SignIn(Authenticable employee, string password)
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
