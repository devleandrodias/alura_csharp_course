using ByteBank_09.Exceptions;
using System;

namespace ByteBank_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CheckingAccount account = new(0001, 2346)
                {
                    Client = new Client
                    {
                        Cpf = "111.111.111-11",
                        Name = "Leandro",
                        Job = "Dev. Backend - .NET"
                    }
                };

                CheckingAccount account2 = new(0001, 2346)
                {
                    Client = new Client
                    {
                        Cpf = "2222.222.222-22",
                        Name = "Thaísa",
                        Job = "Dev. Frontend - React"
                    }
                };

                account.Deposit(50);

                account.ShowBalance();

                account2.Deposit(120);

                account2.Transfer(-100, account);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(CheckingAccount.TransactionFee);

            Console.ReadLine();
        }
    }
}
