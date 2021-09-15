using System;

namespace ByteBank_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checkingAccountLeandro = new();

            checkingAccountLeandro.Owner = "Leandro";
            checkingAccountLeandro.Agency = 863;
            checkingAccountLeandro.Number = 863146;
            checkingAccountLeandro.Balance = 100;
        }
    }
}
