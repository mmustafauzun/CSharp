using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    // T - type
    // List ler arka pland bir array tutuyor
    internal class MyList<T>
    {

        T[] items; // class içerisinde erişilebilir bir dizi

        // constructor
        // listeler de new diyerek adres oluşturmayı yapıyoruz.yapmazsak refans yok hatası alırız.
        // array referans tip olduğu için new lememiz gerekiyor. "constructor" burada yaptığımız işleme diyoruz
        public MyList()
        {
            items = new T[0]; // elimizde sıfır elemanlı bir dizimiz var ve ekleme yapabiliriz
        }
        public void Add(T item) 
        {
            T[] tempArray = items; // eleman ekledikçe referans değeri kaybolmaması için geçici dizi oluşturuyoruz 
            items = new T[items.Length + 1]; // Bu işlem ile eleman sayısını hep +1 arttırıyoruz

            // burada tempArray de geçici hafızada tuttuğumuz değerleri alıcaz
            for (int i = 0; i < tempArray.Length; i++) 
            {
                items[i] = tempArray[i]; // böylelikle sırasıyla tempArray deki değerleri items üzerine geri alıyoruz ve bilgiler kaybolmuyor
            }
            items[items.Length-1] = item;

        }

        public int Length
        { 
            get { return items.Length; } 
        }

        public T[] Items
        {
            get { return items; }
        }

    }
}
