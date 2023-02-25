using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //// array ler oluşturulan sınır dışına çıkamaz - 
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //// diziler bu şekilde genişletilemez - bu şekilde yaptığımızda eskiler gider yeni oluşturulanlardan devam edilir
            //isimler = new string[5];
            //isimler[4] = "Ilker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);


            // bu nedenle koleksiyonlar kullanırız
            
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            //isimler2.Add("Engin");- bu şekilde de ekleyebiliriz

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine("---------------------"); 
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}