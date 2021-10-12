using ByteBank_12.Extensions;
using System;
using System.Collections.Generic;

namespace ByteBank_12
{
    internal class Program
    {
        static void Main(string[] args)
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
