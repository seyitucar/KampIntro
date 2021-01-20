using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        // naming convention - C# ta metotlar büyük harfle balar. PascalCase
        //syntax - yazım şekli demek

        public void Ekle(Urun urun) // normal parantez var ise metot çalışıyor demektir
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
