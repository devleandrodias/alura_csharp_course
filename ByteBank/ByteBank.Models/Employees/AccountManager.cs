namespace ByteBank.Models.Employees
{
    public class AccountManager : EmployeeAuthenticable
    {
        public AccountManager(string cpf) : base(cpf, 4000)
        {

        }

        public override void IncreaseSalary()
        {
            Salary *= 1.05;
        }

        internal protected override double GetBonus() => Salary * 0.25;
    }
}
