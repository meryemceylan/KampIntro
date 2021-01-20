﻿using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Yağız", "Amine", "Sena", "Ali" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5];
            isimler[4] = "Meryem";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);

            Console.WriteLine("-----List-----");
            List<string> isimler2 = new List<string>() { "Yağız", "Amine", "Sena", "Ali"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Meryem");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
