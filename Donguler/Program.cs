using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            Console.WriteLine("---diziler---");
            
            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs",
            "Java", "Python", "C#"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("-for bitti-");
            Console.WriteLine("---foreach dizileri tek tek dolaşır---");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            Console.WriteLine( "Sayfa sonu-footer" );

            Console.WriteLine("------");

            for (int i = 0; i < 10; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
