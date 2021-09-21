using ByteBank_08.Employees;

namespace ByteBank_08.Systems
{
    internal abstract class Authenticable : Employee
    {
        protected Authenticable(string cpf, double salary) : base(cpf, salary)
        {

        }

        public string Password { get; set; }

        public bool Authenticate(string password) => Password == password;
    }
}
