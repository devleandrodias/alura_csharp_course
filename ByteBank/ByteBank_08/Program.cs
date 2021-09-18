using ByteBank_08.Employees;
using System;

namespace ByteBank_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerBonus manager = new();

            Employee thaisa = new()
            {
                Name = "Thaísa",
                Cpf = "111.111.111-11",
                Salary = 5000
            };

            manager.Register(thaisa);

            Director leandro = new()
            {
                Name = "Leandro",
                Cpf = "111.111.111-11",
                Salary = 5000
            };

            manager.Register(leandro);

            Console.WriteLine("{0} - {1}", thaisa.Name, thaisa.GetBonus().ToString("C2"));

            Console.WriteLine("{0} - {1}", leandro.Name, leandro.GetBonus().ToString("C2"));

            Console.WriteLine($"Total bonus {manager.GetTotalBonus():C2}");

            Console.ReadLine();
        }
    }
}

