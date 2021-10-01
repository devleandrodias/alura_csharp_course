using System;
using System.IO;

namespace ByteBank_09
{
    internal class ReadFiles : IDisposable
    {
        public string File { get; set; }

        public ReadFiles(string file)
        {
            File = file;

            Console.WriteLine("Open file... {0}", file);

            //throw new FileNotFoundException();
        }

        public void ReadNextLine()
        {
            Console.WriteLine("Read line...");

            throw new IOException();
        }

        public void Dispose()
        {
            Console.WriteLine("Closing file...");
        }
    }
}
