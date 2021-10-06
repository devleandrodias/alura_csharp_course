using System;

namespace ByteBank_10
{
    public class ArgumentValueExtractorUrl
    {
        private readonly string _arguments;

        public string Url { get; }

        public ArgumentValueExtractorUrl(string url)
        {
            url = url.ToLower();

            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("URL argument cannot be null or empty.", nameof(url));
            }

            if (!url.StartsWith("https"))
            {
                throw new ArgumentException("HTTP not supported only HTTPS", nameof(url));
            }

            if (!url.Contains("https://bytebank.com"))
            {
                throw new ArgumentException("Unknown origin url", nameof(url));
            }

            int index = url.IndexOf('?');

            _arguments = url[(index + 1)..];

            Url = url;
        }

        public string GetCurrency(string currency)
        {
            string search = currency.ToUpper() + "=";

            string arugmentUpper = _arguments.ToUpper();

            int searchIndex = arugmentUpper.IndexOf(search);

            string result = arugmentUpper.Substring(searchIndex + search.Length);

            int ampersandIndex = result.IndexOf('&');

            if (ampersandIndex == -1) return result;

            return result.Remove(ampersandIndex);
        }
    }
}
