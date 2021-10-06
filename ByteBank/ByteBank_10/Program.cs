using System;

namespace ByteBank_10
{
    internal class Program
    {
        static void Main()
        {
            string url = "https://bytebank.com/currencyOrigin=BRL&CURrencyDestiny=CAD&vaLue=2000";

            string urlNubank = "https://nubank.com/currencyOrigin=BRL&CURrencyDestiny=CAD&vaLue=2000";

            ArgumentValueExtractorUrl extractor = new(urlNubank);

            Console.WriteLine("Value - " + extractor.GetCurrency("Value"));
            Console.WriteLine("Origin - " + extractor.GetCurrency("CUrreNCYORigiN"));
            Console.WriteLine("Destiny - " + extractor.GetCurrency("currencyDestiny"));

            Console.ReadLine();
        }

        private static void Introduction()
        {
            string url = "page?args";

            int index = url.IndexOf('?');

            try
            {
                ArgumentValueExtractorUrl extractorUrl = new("");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string arguments = url.Substring(index + 1);

            Console.WriteLine(url);

            Console.WriteLine(arguments); // string is immutable

            Console.WriteLine(url[(1 + index)..]);
        }
    }
}
