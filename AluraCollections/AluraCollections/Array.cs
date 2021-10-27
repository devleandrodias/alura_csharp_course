using System;

namespace AluraCollections
{
    internal partial class Program
    {
        private static void IntroductionArray()
        {
            string class1 = "Introdução conjuntos";
            string class2 = "Modelando a classe aula";
            string class3 = "Trabalhando com conjuntos";

            string[] classes1 = new[] { class1, class2, class3 };

            string[] classes2 = new string[3];

            classes2[0] = class1;
            classes2[1] = class2;
            classes2[2] = class3;

            PrintForeach(classes1);

            Console.WriteLine($"\nAula modelando está no índice {Array.IndexOf(classes1, class3)}");

            Console.WriteLine(Array.LastIndexOf(classes2, class2));

            Console.WriteLine();

            Array.Reverse(classes1);

            PrintFor(classes1);

            Array.Resize(ref classes1, 2);

            Console.WriteLine();

            PrintFor(classes1);

            classes2[classes2.Length - 1] = "Trocando última posição!";

            Console.WriteLine();

            PrintFor(classes2);

            Array.Sort(classes2);

            Console.WriteLine();

            PrintForeach(classes2);

            string[] copy = new string[2];

            string[] clone = classes2.Clone() as string[];

            Array.Copy(classes2, 0, copy, 0, 2);

            Console.WriteLine();

            PrintFor(copy);

            Console.WriteLine();

            PrintFor(clone);

            Console.WriteLine();

            Array.Clear(clone, 1, 2);

            PrintFor(clone);
        }

        private static void PrintForeach(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintFor(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
