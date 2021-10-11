using System;

namespace ByteBank_11
{
    internal class Program
    {
        static void Main()
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

            Console.ReadLine();
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
}
