using ByteBank_08.Interfaces;

namespace ByteBank_08.Employees
{
    internal abstract class EmployeeAuthenticable : Employee, IAuthenticable
    {
        protected EmployeeAuthenticable(string cpf, double salary) : base(cpf, salary)
        {

        }

        public string Password { get; set; }

        public bool Authenticate(string password) => Password == password;
    }
}
