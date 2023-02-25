internal class Program
{
    private static void Main(string[] args)
    {
        // type safety - tip güvenliği
        // do not repeat yourself - Kendini tekrarlama

        string kategoriEtiketi = "Kategoriler";
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;
        bool sistemGirisYapmisMi = false;
        double dolarDun = 7.55;
        double dolarBugun = 7.55;

        if (dolarDun>dolarBugun)
        {
            Console.WriteLine("Azalış butonu");
        }
        else if (dolarDun<dolarBugun)
        {
            Console.WriteLine("Artış butonu");
        }
        else
        {
            Console.WriteLine("değişmedi butonu");
        }


        if (sistemGirisYapmisMi == true)
        {
            Console.WriteLine("Kullanıcı ayarları butonu");
        }
        else
        {
            Console.WriteLine("Giris yap butonu");
        }


        Console.WriteLine(kategoriEtiketi);
    }
}