namespace ByteBank.Models.Employees
{
    internal class Assistant : Employee
    {
        public Assistant(string cpf) : base(cpf, 2000)
        {

        }

        public override void IncreaseSalary()
        {
            Salary *= 1.1;
        }

        internal protected override double GetBonus() => Salary * 0.20;
    }
}
