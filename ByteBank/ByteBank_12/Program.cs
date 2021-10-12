using ByteBank_12.Comparators;
using ByteBank_12.Extensions;
using System;
using System.Collections.Generic;

namespace ByteBank_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        private static void TestSort()
        {
            var accounts = new List<CheckingAccount>()
            {
                new (4536, 34576) {Client = new() {Name = "Leandro"}},
                new (7435, 34074) {Client = new() {Name = "Beatriz"}},
                new (8534, 97364) {Client = new() {Name = "Thaísa"}},
                new (2346, 26384) {Client = new() {Name = "Ana"}},
            };

            accounts.Sort(new CheckingAccountComparatorByAgency());

            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }
        }

        private static void TestVarAndSort()
        {
            var account1 = new CheckingAccount(0001, 242355);
            var account2 = new CheckingAccount(0001, 242355);
            var account3 = new CheckingAccount(0001, 242355);

            var client1 = new Client();
            var client2 = new Client();

            var list = new List<int>();

            list.Add(1);
            list.Add(5);
            list.Add(8);
            list.Add(3);
            list.Add(0);

            list.Sort();

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var names = new List<string>()
            {
                "Leandro",
                "Ana",
                "Beatriz",
                "Thaísa",
            };

            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        private static void TestListMethods()
        {
            List<int> ages1 = new();
            List<int> ages2 = new();

            List<string> names = new();

            ages1.Add(34);
            ages1.Add(25);
            ages1.Add(73);
            ages1.Add(12);

            ages2.PersonalList(52, 23, 12, 43, 64, 23);

            names.PersonalList("Leandro", "Thaísa", "Beatriz");

            foreach (int age in ages1)
            {
                Console.WriteLine(age);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
