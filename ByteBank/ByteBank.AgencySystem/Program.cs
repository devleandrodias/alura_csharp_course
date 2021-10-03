using ByteBank.Models;
using ByteBank.Models.Employees;
using System;

namespace ByteBank.AgencySystem
{
    internal class Program
    {
        static void Main()
        {
            CheckingAccount checkingAccount = new(0001, 12893);

            AccountManager employee = new("111.111.111-11") { Name = "Leandro Dias" };

            Console.WriteLine(employee.Name);

            Console.WriteLine(checkingAccount.Number);

            Console.ReadLine();
        }
    }
}
