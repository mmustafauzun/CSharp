using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    // class iki adet özelliği vardır
    // bir özellikler
    // iki operasyon
    // özellik tuttuğumuz yerde ,operasyon tutmuyoruz
    // operasyon tuttuğumuz yerde,özellik tutmuyoruz

    internal class Musteri
    {
        // Bir nesnede bir değeri kullanmak zorunda değilse o nesneye ait değilmiş gibi duruyorsa , soyutlama hatası yapıyoruz deriz

        public int Id { get; set; }
        public string MusteriNo { get; set; }

    }
}
