using ByteBank_09.Exceptions;
using System;
using System.IO;

namespace ByteBank_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToStringAndEquals();

            Console.ReadLine();
        }

        private static void ToStringAndEquals()
        {
            CheckingAccount account = new(0001, 21453);

            Client client1 = new() { Cpf = "111.111.111-11", Name = "Leandro" };

            account.Client = client1;

            Client client2 = new() { Cpf = "111.111.111-11", Name = "Leandro" };

            Console.WriteLine(account.ToString());

            Console.WriteLine(client1.Equals(client2));
        }

        private static void LoadAccountsByFile()
        {
            try
            {
                using (ReadFiles reader = new("accounts.txt"))
                {
                    reader.ReadNextLine();
                    reader.ReadNextLine();
                    reader.ReadNextLine();
                    reader.ReadNextLine();
                };
            }

            catch (IOException)
            {
                Console.WriteLine("IOException...");
            }
        }

        private static void TestInnerExecption()
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
        }
    }
}
