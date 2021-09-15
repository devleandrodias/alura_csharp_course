using System;

namespace ByteBank_03
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checkingAccountLeandro = new();

            checkingAccountLeandro.Owner = "Leandro";
            checkingAccountLeandro.Agency = 853;
            checkingAccountLeandro.Number = 853245;
            checkingAccountLeandro.Balance = 230.12;

            CheckingAccount checkingAccountLeandroDias = new();

            checkingAccountLeandroDias.Owner = "Leandro";
            checkingAccountLeandroDias.Agency = 853;
            checkingAccountLeandroDias.Number = 853245;
            checkingAccountLeandroDias.Balance = 230.12;

            // Reference
            Console.WriteLine(checkingAccountLeandro == checkingAccountLeandroDias);

            // Value
            Console.WriteLine(checkingAccountLeandro.Owner == checkingAccountLeandroDias.Owner);

            checkingAccountLeandro = checkingAccountLeandroDias;

            // Reference
            Console.WriteLine(checkingAccountLeandro == checkingAccountLeandroDias);

            Console.ReadLine();
        }
    }
}
