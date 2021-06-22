using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Kadir";
            musteri1.DogumTarihi = 1995;
            musteri1.Yas = 26;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Burak";
            musteri2.DogumTarihi = 2005;
            musteri2.Yas = 16;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            Console.WriteLine("-----------------Bankacılık Admin Sistemine Hoşgeldiniz----------------");
            Console.WriteLine("-----------------Yapmak İstediğiniz İşlemi Seçiniz----------------");

            Console.WriteLine("1- Müşterileri Listele");

            Console.WriteLine("2- Yeni Müşteri Ekle");

            Console.WriteLine("3- Mevcut Müşteri Sil");

            int cevap = Convert.ToInt16(Console.ReadLine());
            MusteriManager musteriManager = new MusteriManager();
            foreach (var musteri in musteriler)
            {
                if (cevap == 1)
                {
                    musteriManager.Listeleme(musteri);
                }
                if (cevap == 2)
                {
                    musteriManager.Ekle(musteri);
                }
                if (cevap == 3)
                {
                    musteriManager.Sil(musteri);
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Başka bir işlem yapmak ister misiniz?, Evet,Hayır");
            string cevap1 = Convert.ToString(Console.ReadLine());
            if (cevap1 == "Evet")
            {
                Console.WriteLine("2- Yeni Müşteri Ekle");

                Console.WriteLine("3- Mevcut Müşteri Sil");


            }
            else
            {
                Console.WriteLine("İyi günler dileriz.");
            }
            int cevap2 = Convert.ToInt16(Console.ReadLine());
            foreach (var musteri in musteriler)
            {
                if (cevap2 == 2)
                {
                    musteriManager.Ekle(musteri);
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Başka bir işlem yapmak ister misiniz?, Evet,Hayır");
            string cevap3 = Convert.ToString(Console.ReadLine());
            if (cevap3 == "Evet")
            {


                Console.WriteLine("3- Mevcut Müşteri Sil");


            }
            else
            {
                Console.WriteLine("İyi günler dileriz.");
            }
            int cevap4 = Convert.ToInt16(Console.ReadLine());
            foreach (var musteri in musteriler)
            {
                if (cevap4 == 3)
                {
                    musteriManager.Sil(musteri);
                }
            }
            Console.ReadLine();

        }
    }
}
