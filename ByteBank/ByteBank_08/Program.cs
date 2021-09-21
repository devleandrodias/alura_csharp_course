using ByteBank_08.Employees;
using ByteBank_08.Systems;
using System;

namespace ByteBank_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalculateBonus();

            UseInternalSystem();

            Console.ReadLine();
        }

        public static void CalculateBonus()
        {
            ManagerBonus manager = new();

            Employee thaisa = new Designer("111.111.111-11")
            {
                Name = "Thaísa",
            };
            Employee leandro = new Director("222.222.222-22")
            {
                Name = "Leandro",
            };
            Employee beatriz = new AccountManager("333.333.333-33")
            {
                Name = "Beatriz"
            };
            Employee leonardo = new Assistant("444.444.444-44")
            {
                Name = "Leonardo"
            };

            manager.Register(thaisa);
            manager.Register(leandro);
            manager.Register(beatriz);
            manager.Register(leonardo);

            Console.WriteLine($"Total bonus {manager.GetTotalBonus():C2}");

            Console.WriteLine($"Total employees {Employee.TotalEmployees}");

            Console.WriteLine("\nBonus: {0} - {1}", thaisa.Name, thaisa.GetBonus().ToString("C2"));

            Console.WriteLine($"Old salary {thaisa.Salary:C2}");

            thaisa.IncreaseSalary();

            Console.WriteLine($"New salary {thaisa.Salary:C2}");

            Console.WriteLine("\nBonus: {0} - {1}", leandro.Name, leandro.GetBonus().ToString("C2"));

            Console.WriteLine($"Old salary {leandro.Salary:C2}");

            leandro.IncreaseSalary();

            Console.WriteLine($"New salary {leandro.Salary:C2}");

        }

        public static void UseInternalSystem()
        {
            Director leandro = new("111.111.111-11")
            {
                Name = "Leandro",
                Password = "leandro123"
            };

            AccountManager thaisa = new("222.222.222-22")
            {
                Name = "Thaisa",
                Password = "thaisa123"
            };

            CommercialPartner nubank = new()
            {
                Password = "nubank123"
            };

            InternalSystem.SignIn(leandro, "leandro123");

            InternalSystem.SignIn(leandro, "leandroABC");

            InternalSystem.SignIn(thaisa, "thaisa123");

            InternalSystem.SignIn(nubank, "nubank123");
        }
    }
}

