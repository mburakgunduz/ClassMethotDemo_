using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethotDemo_
{
    class MusteriManager
    {
        public void Listele(Musteri[] musteri)
        {
            Console.WriteLine("Müşteriler");

            foreach (Musteri item in musteri)
            {
                Console.WriteLine(item.Id + " " + item.isim + " " + item.soyisim + " " + item.yas);

            }
            
        }
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.isim +" "+musteri.soyisim+ " Kayıt Eklendi.");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.isim + " " + musteri.soyisim + " Kayıt Silindi.");
        }
    }
}
