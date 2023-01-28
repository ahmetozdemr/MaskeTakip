using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }



        public void SelamVer()
        {
            Console.WriteLine("**********************************");

            Console.Write("Selam vermek istediğin vatandaşı yaz :");
            string personName = Console.ReadLine();
            Console.WriteLine("Selam Verdiğin Vatandaşın İsmi: " + personName);
        }

        public void Topla()
                     
        {
            Console.WriteLine("**********************************")
                ;

            Console.Write(" Vatandaşın bu seneki toplam vurduğu aşı sayısını yaz: ");
            int asi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Vatandaşın geçen seneki toplam vurduğu aşı sayısı yaz: ");
            int asi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Vatandaşın vurulduğu toplam aşı sayısı:{asi1 + asi2} " );
        }


    }
}

/*
public int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    return sonuc;
}
*/