using System;
using System.IO;
using System.Text;

namespace ByteBank_13
{
    internal partial class Program
    {
        private static void WorkWithBuffers(string pathFile)
        {
            using (FileStream fs = new(pathFile, FileMode.Open))
            {
                byte[] buffer = new byte[1024];

                int readBytes = -1;

                while (readBytes != 0)
                {
                    readBytes = fs.Read(buffer, 0, 1024);

                    WriteBuffer(buffer, readBytes);
                }
            }
        }

        static void WriteBuffer(byte[] buffer, int readBytes)
        {
            Encoding utf8 = Encoding.UTF8;

            string text = utf8.GetString(buffer, 0, readBytes);

            Console.Write(text);
        }
    }
}