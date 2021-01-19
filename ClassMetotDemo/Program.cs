using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.Name = "Mirza";
            musteri1.Surname = "Aslan";
            musteri1.Tc = "11111111111";
            musteri1.Number = "00000000001";
            musteri1.City = "İstanbul";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.Name = "Hazal";
            musteri2.Surname = "Kaya";
            musteri2.Tc = "11111111112";
            musteri2.Number = "00000000002";
            musteri2.City = "Kayseri";

            Musteri musteri3 = new Musteri();
            musteri3.ID = 3;
            musteri3.Name = "Meryem";
            musteri3.Surname = "Ceylan";
            musteri3.Tc = "11111111113";
            musteri3.Number = "00000000003";
            musteri3.City = "Sivas";

            Console.WriteLine("-----EKLE-----");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Console.WriteLine("-----LİSTELE-----");
            musteriManager.Listele();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.ID + " " + musteri.Name + " " + musteri.Surname + " " + 
                    musteri.Tc + " " + musteri.Number + " " + musteri.City);
            }

            Console.WriteLine("-----SİL-----");
            musteriManager.Sil(musteri3);
        }
    }
}
