using System;

namespace ClassMethotDemo_
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.isim = "Burak";
            musteri1.soyisim = "Gündüz";
            musteri1.yas = 30;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.isim = "Vince";
            musteri2.soyisim = "Carter";
            musteri2.yas = 45;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.isim = "Tracy";
            musteri3.soyisim = "McGrady";
            musteri3.yas = 44;

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Listele(musteriler);

            musteriManager.Ekle(musteri2);

            musteriManager.Sil(musteri3);

        }

    }
    
}
