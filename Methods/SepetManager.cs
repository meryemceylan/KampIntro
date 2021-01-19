using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Product urun)
        {
            Console.WriteLine("Ürün sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string Aciklama, double Fiyat, int stokAdedi)
        {
            Console.WriteLine("Ürün sepete eklendi : " + urunAdi);
        }
    }
}
