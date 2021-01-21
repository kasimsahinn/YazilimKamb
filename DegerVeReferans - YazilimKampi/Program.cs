using System;

namespace DegerVeReferans___YazilimKampi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------- Değer Tipler --------");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // Sayi 1 Kaçtır?
            Console.WriteLine(sayi1);

            Console.WriteLine("-------- Referans Tipler -------- " );

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // Sayilar1[0] Kaçtır?
            Console.WriteLine(sayilar1[0]);

            // int, decimal, floati double, bool = Değer Tiplerdir.
            // array, class, interface = Referans tiplerdir.

            
        }
    }
}
