namespace DegerVeReferansTipler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // stack kısmında kalıyor.Heap kısmına geçmiyoruz
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ?? 30

            //Console.WriteLine(sayi1);

            // burada stack kısmından "new" diyerek bellekte bir adres oluşturuyoruz ve o bölüme değerler atıyoruz
            // işlem yaptığımızda direkt olarak değerlerde değil adreslerde değişiklik yapıyoruz
            // en sonunda da değer ataması yapıyoruz 
            int[] sayilar1 = new int[]{ 10,20,30 };
            int[] sayilar2 = new int[] { 100,200,300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar1[0] 999

            // Console.WriteLine(sayilar1[0]);

            // Peki neden ?
            // Sayısal veri tipleri = int ,decimal,float,double,bool = değer tip 
            // ama bir array , bir class , interface = referans tip olarak çıkar

            // kısacası sayısal tip olarak görünenler bunlar değer tip
            // ama array,class,interface ise referans tip

            // Bellekte stack ve heap diye iki değişken tanım var
            // değer tipler de değeri atıyorusun - referans tiplerde adresi atıyorsun

            
        }
    }
}