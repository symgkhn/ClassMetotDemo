using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Şeyma";
            musteri1.Soyad = "Gökhan";
            musteri1.Id = 1234;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Büşra";
            musteri2.Soyad = "Cenk";
            musteri2.Id = 1223;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Kübra";
            musteri3.Soyad = "Çamlı";
            musteri3.Id = 4567;

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3};
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.Id);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSilme(musteri1);


        }
    }
}
