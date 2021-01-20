using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Armut";
            urun2.Fiyati = 10;
            urun2.Aciklama = "Ankara Armudu";

            Urun urun3 = new Urun();
            urun3.Adi = "Karpuz";
            urun3.Fiyati = 8;
            urun3.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2, urun3 };

           // type safe
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("------Metotlar---------");

            // Instance - ürün örneği oluşturmak. Spetmanager dan bir şey çağırmak istiyorsam önce instance oluşturmalyım.
            // Encapsulation
            
            SepetManager sepetManager = new SepetManager();            
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Elma", "Yeşil elma", 12,5);
            sepetManager.Ekle2("Armut", "Yeşil armut", 15,12);
            sepetManager.Ekle2("Karpuz", "Yeşil karpuz", 8,0);

        }
    }
}


// Do not repeat yourself - DRY - Clean Code - Best Practice