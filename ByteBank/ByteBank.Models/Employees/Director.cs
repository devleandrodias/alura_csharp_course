namespace ByteBank.Models.Employees
{
    internal class Director : EmployeeAuthenticable
    {
        public Director(string cpf) : base(cpf, 5000)
        {

        }

        public override void IncreaseSalary()
        {
            Salary += Salary * 0.15;
        }

        public override double GetBonus() => Salary * 0.5;
    }
}
