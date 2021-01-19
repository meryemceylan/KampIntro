using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya alması";

            Product urun2 = new Product();
            urun2.Adi = "Muz";
            urun2.Fiyati = 10;
            urun2.Aciklama = "Yerli muz";

            Product urun3 = new Product();
            urun3.Adi = "Ayva";
            urun3.Fiyati = 8;
            urun3.Aciklama = "Limon ayva";

            Product[] urunler = new Product[] {urun1, urun2, urun3 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi + " : " + urun.Aciklama + " : " + urun.Fiyati);
                Console.WriteLine("---");
            }

            Console.WriteLine("-----------Methods-----------");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("-----Ekle2-----");

            sepetManager.Ekle2("Armut", "Dağ armutu", 32, 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 65, 25);


        }
    }
}


//Don't repeat yourself - DRY - Clean Code - Best Practice
