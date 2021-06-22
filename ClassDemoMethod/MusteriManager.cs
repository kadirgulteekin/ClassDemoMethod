using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {

            Console.WriteLine("Müsteri Eklendi : " + musteri.Ad + " " + musteri.DogumTarihi + " " + musteri.Yas);



        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müsteri Silindi : " + musteri.Ad + " " + musteri.DogumTarihi + " " + musteri.Yas);
        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müsteriler Listelendi : " + musteri.Ad + " " + musteri.DogumTarihi + " " + musteri.Yas);
        }

    }
}
