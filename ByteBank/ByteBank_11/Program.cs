using System;
using System.Collections.Generic;

namespace ByteBank_11
{
    internal class Program
    {
        static void Main()
        {
            Console.ReadLine();
        }

        private static void TestGenerics()
        {
            Generics.Print<int>(643);
            Generics.Print<string>("Leandro");
            Generics.Print<CheckingAccount>(new CheckingAccount(0001, 13532) { Client = new() { Name = "Leandro", Cpf = "111.111.111-11" } });
        }

        private static void TestOptionalArgumentsAndParams()
        {
            OptionalAndParams.Optional();
            OptionalAndParams.Optional(13, 23);
            OptionalAndParams.Optional(x: 12, y: 63);
            OptionalAndParams.Optional(x: 13);
            OptionalAndParams.Optional(y: 20);

            OptionalAndParams.Params(
                new CheckingAccount(0001, 2492837),
                new CheckingAccount(0001, 2492837),
                new CheckingAccount(0001, 2492837)
            );

            Console.WriteLine(OptionalAndParams.Sum(123, 23, 42, 65, 23, 13, 64, 34));
        }

        private static void TestListCheckingAccount()
        {
            List<CheckingAccount> accounts = new();

            accounts.Add(new(0001, 42523));
            accounts.Add(new(0001, 23456));
            accounts.Add(new(0001, 53473));

            foreach (CheckingAccount account in accounts)
            {
                Console.WriteLine($"Agency: {account.Number} - Number: {account.Number}");
            }
        }

        private static void TestArrayCheckingAccount()
        {
            CheckingAccount[] accounts = new CheckingAccount[3]
            {
                new(0001, 42523),
                new(0001, 23456),
                new(0001, 53473),
            };


            for (int i = 0; i < accounts.Length; i++)
            {
                CheckingAccount account = accounts[i];

                Console.WriteLine($"Agency: {account.Number} - Number: {account.Number}");
            }
        }

        private static void TestArrayInt()
        {
            int[] ages = new int[6];

            int sum = 0, avg;

            ages[0] = 15;
            ages[1] = 20;
            ages[2] = 30;
            ages[3] = 23;
            ages[4] = 53;
            ages[5] = 60;

            for (int i = 0; i < ages.Length; i++)
            {
                sum += ages[i];
            }

            avg = sum / ages.Length;

            Console.WriteLine(ages[3]);

            Console.WriteLine(ages[0 + 1]);

            Console.WriteLine($"LENGTH: {ages.Length}");

            Console.WriteLine($"AVG: {avg}");
        }
    }


    internal class Generics
    {
        public static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }
    }

    internal class OptionalAndParams
    {
        public static void Optional(int x = 10, int y = 5)
        {
            Console.WriteLine(x + y);
        }

        public static void Params(params CheckingAccount[] accounts)
        {
            foreach (CheckingAccount account in accounts)
            {
                Console.WriteLine($"Agency: {account.Number} - Number: {account.Number}");
            }
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
