using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en mening:");
            string mening = Console.ReadLine();
            Metod(mening);
        }

        static void Metod(string mening)
        {
            string[] ord = mening.Split(' ');

            for (int i = 0; i < ord.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(ord[i].ToUpper() + " ");
                }
                else
                {
                    Console.Write(ord[i].ToLower() + " ");
                }
            }
        }
    }
}