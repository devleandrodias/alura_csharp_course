using System;
using System.Text.RegularExpressions;

namespace ByteBank_10
{
    internal class Program
    {
        static void Main()
        {
            Console.ReadLine();
        }

        private static void RegexMethods()
        {
            string input = "Hello my name is Leandro, call me in 92688-2345";

            string pattern0 = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";

            string pattern1 = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";

            string pattern2 = "[0-9]{4}[-][0-9]{4}";

            string pattern3 = "[0-9]{4,5}[-][0-9]{4}";

            string pattern4 = "[0-9]{4,5}[-]{0,1}[0-9]{4}";

            string pattern5 = "[0-9]{4,5}[-]?[0-9]{4}";

            Match match = Regex.Match(input, pattern5);

            Console.WriteLine(match.Value);
        }

        private static void StringMethods()
        {
            string url = "https://bytebank.com/currencyOrigin=BRL&CURrencyDestiny=CAD&vaLue=2000";

            string urlNubank = "https://nubank.com/currencyOrigin=BRL&CURrencyDestiny=CAD&vaLue=2000";

            ArgumentValueExtractorUrl extractor = new(urlNubank);

            Console.WriteLine("Value - " + extractor.GetCurrency("Value"));
            Console.WriteLine("Origin - " + extractor.GetCurrency("CUrreNCYORigiN"));
            Console.WriteLine("Destiny - " + extractor.GetCurrency("currencyDestiny"));
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
