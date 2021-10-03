namespace ByteBank.Models.Employees
{
    internal class Designer : Employee
    {
        public Designer(string cpf) : base(cpf, 3000)
        {

        }

        public override void IncreaseSalary()
        {
            Salary *= 1.11;
        }

        internal protected override double GetBonus() => Salary * 0.17;
    }
}
