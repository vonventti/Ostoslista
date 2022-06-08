using System;
using System.IO;
using System.Text;

namespace Ostoslista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä tuote");
            string tuote = Console.ReadLine();

            string path = @"C:\Users\Anders\ostoslista.txt";

            File.WriteAllText(path, tuote);
        }
    }
}

