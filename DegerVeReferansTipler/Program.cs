using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;
            sayi2 = 65;

            //sayi 1 ? 30  / stack memory tip belleğinde tutulur

            // int, double, decimal, bool, float = değer tip!
            // array, class, interface = referans tip !


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            //sayilar1 [0] ?? 999 / heap memory tip belleğinde tutulur

        }
    }
}
