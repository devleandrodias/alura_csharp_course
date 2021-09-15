using System;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execution 4 program - Conversions");

            double salary = 1200.50;

            int salaryInt = (int)salary;

            Console.WriteLine(salary);

            Console.WriteLine(salaryInt);

            long universeAge = 13000000000000;

            short ageShort = 24;

            float salaryFloat = 24000.23f;

            Console.WriteLine(universeAge);

            Console.WriteLine(ageShort);

            Console.WriteLine(salaryFloat);

            Console.ReadLine();
        }
    }
}
