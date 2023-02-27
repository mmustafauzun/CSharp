namespace OOP2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Gerçek
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12353";
            musteri1.Adi = "Mustafa";
            musteri1.Soyadi = "UZUN";
            musteri1.TcNo = "11254589654";

            // Tüzel 

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54784";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123468796546";

            // Gerçek Müşetri - Tüzel Müşteri
            // SOLID 
            // İkiside ayrı musteri tipidir.


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

        }
    }
}