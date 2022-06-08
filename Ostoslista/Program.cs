using System;
using System.IO;

namespace Ostoslista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä tuote");
            string tuote = Console.ReadLine();

            string path = @"C:\Users\Anders\ostoslista.txt";

            // Luo tiedosto (jos ei jo ole)
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path));
            }

            // Lisää tuote
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(tuote);
            }

            // Lue tuotteet
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }
    }
}

