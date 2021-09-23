using System;

namespace ByteBank_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CheckingAccount account = new(000, 0)
                {
                    Balance = 11532.32,
                    Client = new Client
                    {
                        Cpf = "111.111.111-11",
                        Name = "Leandro",
                        Job = "Dev. Backend .NET"
                    }
                };
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine($"An invalid argument error occurred! {ex.ParamName}");
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
