using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        // encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        // Void Anahtar kelimesi

        // Void ile oluşturulmuş metotlar emir kipi olarak git işle ,git yap gibi işlem yapıp bitirme istediğimiz metotlarda kullanırız
        // return ile farkı ise örnek ile açıklayalım
        //örnek:

        // buradaki işlemde toplama işlemi yapılıp sonuç geri döndürülür.Ancak void ile farkı işleme ,işlem sonucunu alıp devam edebilinmesidir.
        // her hangi 2 sayıyı gönderip toplam sonucu ile başka işlem yapa bilir. 2+3=5 sonuc 5 aldık.Devamında işleme farklı bir işlemde devam edip 2 ile çarpabiliriz.
        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}

        // buradaki void ile sonucu elde ederiz.Ancak işlem biter.Bir önceki yazdığımız 2+3=5 sonucundan sonra aldığımız değer ekrana yazılır ve biter devam edilemez.
        
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1+sayi2);
        //}

        // Kısaca metot sonrası işlem devam edecekse "RETURN", devam etmeyecek bitirilecekse "VOID" kullanılır.

    }
}
