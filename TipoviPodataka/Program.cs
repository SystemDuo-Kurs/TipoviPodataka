using System;

namespace TipoviPodataka
{
    class Program
    {
        static void Main(string[] args)
        {
            byte jedanBajt = 1;

            //Console.WriteLine($"Bajt je sada {jedanBajt}");
            //jedanBajt++;
            //Console.WriteLine($"Bajt je sada {jedanBajt}");
            //jedanBajt++;
            //Console.WriteLine($"Bajt je sada {jedanBajt}");

            int ceoBroj = -4;

            Console.WriteLine($"Int ide od {int.MinValue} do {int.MaxValue}");
            Console.WriteLine($"UInt ide od {uint.MinValue} do {uint.MaxValue}");

            long veeeeelikiCeoBroj = 56;
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine($"Long je {sizeof(long)} bajta");
            

            ceoBroj = ceoBroj + 1;
            ceoBroj *= 5;
            ceoBroj++;

            float maleni = (float)4.5;
            double BrojSaOstatkom = 4.5;
            decimal veeeliki = (decimal)4.5;

            char karakter = 'g';
            string tekst = "asdasd sdfsdf dfgdfgfdg";

            bool istina = 6 > 3;
            istina = false;
        }
    }
}
