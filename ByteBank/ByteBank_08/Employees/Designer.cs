namespace ByteBank_08.Employees
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

        public override double GetBonus() => Salary * 0.17;
    }
}
