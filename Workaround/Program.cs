using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
          
            person1.SelamVer();
            person1.Topla();


            person1.FirstName = "Ahmet";
            person1.LastName = "Özdemir";
            person1.DateOfBirthYear = 1994;
            person1.NationalIdentity = 1;

            Console.WriteLine(person1.FirstName);
            Console.WriteLine(person1.LastName);
            Console.WriteLine(person1.DateOfBirthYear);
            Console.WriteLine(person1.NationalIdentity);

            Console.WriteLine("*******************************");

            Person person2 = new Person();
            person2.FirstName = "Mehmet";

            Console.WriteLine(person2.FirstName);

            Console.WriteLine("***************************");

     

            string[] ogrenciler = new string[4];
            ogrenciler[1] = "Engin";
            ogrenciler[2] = "Kerem";
            ogrenciler[3] = "Berkay";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);

            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana"; // array referans mantığıyla çalışır
            Console.WriteLine(sehirler2[0]);
            long a = 1234567890123;

            Console.WriteLine(a);



            Console.WriteLine("***********************************");
            //MyList
            List<string> yenisehirler1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
            yenisehirler1.Add("Adana");

            foreach (var sehirler in yenisehirler1)
            {
                Console.WriteLine(sehirler);
            }

            Console.WriteLine("***********************************");
            Console.ReadLine();


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }


        // Stack ve Heap: Veri tipleri bellekte (ram) değer tipleri ve referans tipler diye iki şekilde tutuluyor.
        // Referans tipleri: string, object, class, interface, array, delegate, pointer
        // Değer tipleri: int, long, float, double, decimal, char, bool, byte, short, struct, enum
        // Garbage Collector: Kullanılmayan değerleri ortadan kaldırmayı sağlıyor.

        //*************************************************************************************************

        //S.O.L.I.D
        /*
        S is single responsibility principle(SRP)
        - Bir sınıfa sadece bir özellik ya da operasyon verilmelidir
        O stands for open closed principle (OCP)
        L Liskov substitution principle (LSP)
        I interface segregation principle(ISP)
        D Dependency injection principle (DIP)
        */
        /*
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }
        */

    }
}
