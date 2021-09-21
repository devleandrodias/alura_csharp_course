namespace ByteBank_08.Employees
{
    internal class AccountManager : EmployeeAuthenticable
    {
        public AccountManager(string cpf) : base(cpf, 4000)
        {

        }

        public override void IncreaseSalary()
        {
            Salary *= 1.05;
        }

        public override double GetBonus() => Salary * 0.25;
    }
}
