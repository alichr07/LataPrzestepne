using System;

namespace Lata_przestępne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sprawdzanie roku przestępnego

            Console.WriteLine("Podaj rok:");
            int rok = int.Parse(Console.ReadLine());

            if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0)
            {
                Console.WriteLine("To jest rok przestępny.");
            }
            else
            {
                Console.WriteLine("To nie jest rok przestępny.");
            }
        }
    }
}
