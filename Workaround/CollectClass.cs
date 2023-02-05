using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    internal class CollectClass
    {
        public void ColectMetho()

        {
            Console.WriteLine("**********************************");

            Console.Write(" Vatandaşın bu seneki toplam vurduğu aşı sayısını yaz: ");
            int asi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Vatandaşın geçen seneki toplam vurduğu aşı sayısı yaz: ");
            int asi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Vatandaşın vurulduğu toplam aşı sayısı:{asi1 + asi2} ");
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
