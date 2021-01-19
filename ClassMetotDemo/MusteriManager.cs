using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Name + " " + musteri.Surname);
        }
        public void Listele()
        {
            Console.WriteLine("Müşteriler listelendi : ");
            
            //Console.WriteLine( musteri.ID + " " + musteri.Name + " " + musteri.Surname + " " + musteri.Tc + " " + musteri.Number + " " + musteri.City);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Üyelik sonlandırıldı : " + musteri.Name + " " + musteri.Surname);
        }
    }
}
