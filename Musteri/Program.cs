using System;

namespace Musteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Elif";
            musteri1.Soyad = "Oz";
            musteri1.Yas = 28;
            musteri1.MustId = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ipek";
            musteri2.Soyad = "Oz";
            musteri2.Yas = 18;
            musteri2.MustId = 2;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriMeneger musteriMeneger = new MusteriMeneger();

            musteriMeneger.Ekle(musteri1);

            foreach (Musteri i in musteriler)
            {
                musteriMeneger.mustgoster(i);
            }
            

               
        }
    }
}
