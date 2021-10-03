using ByteBank.Models;
using System;

namespace ByteBank.InternalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount account = new(0001, 123567)
            {
                Balance = 6233,
                Client = new Client
                {
                    Cpf = "111.111.111-11",
                    Job = "Software engineer",
                    Name = "Leandro Dias"
                }
            };

            account.ShowBalance();

            Console.ReadLine();
        }
    }
}
