using ByteBank.Models;
using ByteBank.Models.Employees;
using Humanizer;
using System;

namespace ByteBank.AgencySystem
{
    internal class Program
    {
        static void Main()
        {
            DateTime paymentEndDate = new(2021, 11, 14);

            TimeSpan difference = paymentEndDate - DateTime.Now;

            Console.WriteLine(TimeSpanHumanizeExtensions.Humanize(difference));

            Console.ReadLine();
        }

        private static void Documentation()
        {
            CheckingAccount checkingAccount = new(0001, 12893);

            CheckingAccount account = new(011, 3423);

            AccountManager employee = new("111.111.111-11") { Name = "Leandro Dias" };

            Console.WriteLine(employee.Name);

            Console.WriteLine(checkingAccount.Number);
        }
    }
}
