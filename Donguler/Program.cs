using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılımcı Geliştirme Kursu";
            string kurs2 = "Programlama için Temel Kurs";
            string kurs3 = "Java Kursu";

            //array - diziler

            string[] kurslar = new string[] { "Yazılımcı Geliştirme Kursu", "Programlama için Temel Kurs", "Java Kursu" , "Python" , "C++"};


            for (int i = 0; i<kurslar.Length; i++  )
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
