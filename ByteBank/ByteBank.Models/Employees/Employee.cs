namespace ByteBank.Models.Employees
{
    internal abstract class Employee
    {
        public Employee(string cpf, double salary)
        {
            Cpf = cpf;
            Salary = salary;

            TotalEmployees++;
        }

        public static int TotalEmployees { get; private set; }

        public string Name { get; set; }

        public string Cpf { get; private set; }

        public double Salary { get; protected set; }

        public abstract void IncreaseSalary();

        public abstract double GetBonus();
    }
}
