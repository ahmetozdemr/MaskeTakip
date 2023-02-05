internal class Program
{
    private static void Main(string[] args)
    {
        int x = 1;
        string a = ""; 

        // ternary operatör
        a += x == 0 ? "doğru" : "Yanlış";

        // dont reapet yourslf. DRY. Clean code. best practice

        //Ternary Operatörü
        Console.Write("[1-10] arasında sayı giriniz :");
        int sayi = int.Parse(Console.ReadLine());
        string cevap = "";
        cevap += sayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış cevap";
        Console.WriteLine(cevap);

        // Coalescing Kullanımı
        Console.Write("Lütfen yaşınızı giriniz :");
        string yasiniz = Console.ReadLine();
        string sonuc = "";
        //Burada iki operatörü birarada kullanmış olduk 
        //Ternary kullanma amaçımız kullanıcı direkt boş geçerse stringlerde boş değer bir karakter olduğudan
        //Coalescing de bildiğiniz gibi null değer gelirse varsayılan değeri yazdırır.
        sonuc = (yasiniz == "" ? null : yasiniz) ?? "Boş geçildi.";
        Console.WriteLine("Yaşınız :" + sonuc);



        Console.WriteLine(a);

      //  if (x > 0)
      //  {
      //      Console.WriteLine(x);   
      //  }
      //  else
      //  {
      //      Console.WriteLine(-x);
      //  }

      //int a = ( x %2) ==  0 ? x : -x;

        
        

        List<string> sehirler = new List<string>();
        sehirler.Add("Ankara");
        sehirler.Add("Ankara");
        sehirler.Add("Ankara");
        sehirler.Add("Ankara");
        sehirler.Add("Ankara");
        Console.WriteLine(sehirler.Count); 


        Mylist<string> sehirler2 = new Mylist<string>();
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");

        Console.WriteLine(sehirler2.Count);    
    }

    class Mylist<T> //Genericclass
    {
        T[] _array;
        T[] _tempArray;

        public Mylist()
        {
            _array = new T[0];
        }

        public void Add(T item) 
        {
            _tempArray = _array;
            _array = new T[_tempArray.Length + 1];
            for(int i=0; i<_tempArray.Length; i++) 
            {
                _array[i] = _tempArray[i];   
            }

            _array[_array.Length -1] = item;        
        }

        public int Count
        {
            get { return _array.Length; }
        }

    }
}