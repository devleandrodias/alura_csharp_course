using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execution 2 program - Create variables");

            int number = (20 + 5) * 2;

            Console.WriteLine(number);

            string name = "Leandro";

            int age = 20;

            Console.WriteLine("My name is " + name + " and I'm " + age + " years old");

            Console.WriteLine("My name is {0} and I'm {1} years old", name, age);

            Console.WriteLine($"My name is {name} and I'm {age} years old");

            Console.ReadLine();
        }
    }
}
