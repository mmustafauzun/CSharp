using System.Collections.Concurrent;

namespace Metotlar
{
    internal class Program
    {
        // Metotlar : tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
        // Do not repeat yourself - "DRY" - Clean Code - Best Practice
        private static void Main(string[] args)
        {
            // urunleri tanımlıyoruz

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            // tanımladığımız ürünleri dizi içerisine alıyoruz
            Urun[] urunler = new Urun[] { urun1, urun2 };

            // listeleme type-safe -- tip güvenli

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("-----------------Metotlar--------------------");

            // Instance - örnek
            // encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("-------------------------------------");

            sepetManager.Ekle2("Armut","Yeşil",12, 10);
            sepetManager.Ekle2("Elma","Yeşil Elma",12, 9 );
            sepetManager.Ekle2("Karpuz","Diyarbakır karpuzu",12 , 15);
            


        }
    }
}