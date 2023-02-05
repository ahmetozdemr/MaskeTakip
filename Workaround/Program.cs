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

            int number1;
            int number2 = 20;

            var result = add(out number1,ref number2);

            Console.WriteLine(result);
            Console.WriteLine(number2);

            SayHello sayHello = new SayHello();
            CollectClass collect = new CollectClass();

            var number = 11;
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

            Console.WriteLine(MyEnum.Friday);
            Console.WriteLine((int)MyEnum.Wednesday);
           // sayHello.SayHelloMethod();
           // collect.ColectMetho();

            Person person1 = new Person();

            person1.FirstName = "Ahmet";
            person1.LastName = "Özdemir";
            person1.DateOfBirthYear = 1994;
            person1.NationalIdentity = 19723161134;

            Console.WriteLine(person1.LastName);
            /*
            Console.WriteLine(person1.FirstName);
            Console.WriteLine(person1.LastName);
            Console.WriteLine(person1.DateOfBirthYear);
            Console.WriteLine(person1.NationalIdentity);
             */
            Console.WriteLine("*******************************");

            Person person2 = new Person();
            person2.FirstName = "Mehmet";

            Console.WriteLine(person2.FirstName);

            Console.WriteLine("***************************");

            /*

                   string[] ogrenciler = new string[4];
                   ogrenciler[1] = "Engin";
                   ogrenciler[2] = "Kerem";
                   ogrenciler[3] = "Berkay";

                   for (int i = 0; i < ogrenciler.Length; i++)
                   {
                       Console.WriteLine(ogrenciler[i]);

                   }
            */
            /*
                   string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
                   string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

                   sehirler2 = sehirler1;
                   sehirler1[0] = "Adana"; // array referans mantığıyla çalışır
                   Console.WriteLine(sehirler2[0]);
                   long a = 1234567890123;

                   Console.WriteLine(a);

                   */
            /*
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
            */
            Multy(1, 2);
            Multy(4, 6, 3);

            Console.WriteLine(Add4(3, 6, 4, 3, 4, 7, 3, 6, 1, 0, 8));

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
           
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
        static int add(out int number1,ref int number2)
        {
            number1 = 50;
            number2 = 40;
            return number1 + number2;
        }

        static int Multy(int a, int b)
        {
            return a + b;
        }
        static int Multy(int a, int b, int c)
        {
            return a + b + c;
        }

        enum MyEnum
        {
            Monday, Tuesday, Wednesday, Thursday = 10, Friday, Saturday,Sunday
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
