using ByteBank_08.Systems;

namespace ByteBank_08.Employees
{
    internal class Director : Authenticable
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
