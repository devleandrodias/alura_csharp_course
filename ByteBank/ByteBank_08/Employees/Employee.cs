namespace ByteBank_08.Employees
{
    internal class Employee
    {
        public string Name { get; set; }

        public string Cpf { get; set; }

        public double Salary { get; set; }

        public double GetBonus() => Salary * 0.10;
    }
}
