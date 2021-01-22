using System;
using System.Collections.Generic;
using System.Text;

namespace Musteri
{
    class MusteriMeneger
    {




        public void Ekle(Musteri musteri)

        {
            Console.WriteLine(musteri.Ad + musteri.Soyad + "Musterisi eklendi");
        }

        public void mustgoster(Musteri musteri)
          {
            Console.WriteLine(musteri.MustId + "." + musteri.Ad + " " + musteri.Soyad);
          }

    }
}

