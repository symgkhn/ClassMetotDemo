using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine( musteri.Ad +" "+ musteri.Soyad + " " +musteri.Id +" " + "Müşteri Eklendi" );
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine( musteri.Id +" " + "Id'li müşteri silindi  " );
        }
    }
}
