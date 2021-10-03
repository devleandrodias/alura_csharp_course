using ByteBank.Models.Interfaces;

namespace ByteBank.Models.Employees
{
    public abstract class EmployeeAuthenticable : Employee, IAuthenticable
    {
        private readonly AuthenticationHelper _authenticationHelper = new();

        protected EmployeeAuthenticable(string cpf, double salary) : base(cpf, salary)
        {

        }

        public string Password { get; set; }

        public bool Authenticate(string password)
        {
            return _authenticationHelper.ComparePasswords(Password, password);
        }
    }
}
