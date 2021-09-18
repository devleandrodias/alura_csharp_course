using System;

namespace ByteBank_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checkingAccountThaisa = new();

            checkingAccountThaisa.Owner = "Thaísa";
            checkingAccountThaisa.Agency = 863;
            checkingAccountThaisa.Number = 863642;
            checkingAccountThaisa.Balance = 90.93;

            CheckingAccount checkingAccountLeandro = new()
            {
                Owner = "Leandro",
                Agency = 863,
                Number = 863146,
                Balance = 100,
            };

            Console.WriteLine(checkingAccountThaisa.Owner);

            Console.WriteLine(checkingAccountLeandro.Owner);

            Console.ReadLine();
        }
    }
}
