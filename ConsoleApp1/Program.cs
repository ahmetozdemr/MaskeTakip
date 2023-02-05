


namespace ConsoleApp1
{
	public class Program
	{

		static void Main(string[] args)
		{
			// Naming Convention
			// instance = bir class örneği oluşturma
			Product product1= new Product();
			product1.ProductName = "Elma";
			product1.Id = 1;
			product1.Expalnation = "Amasya";

			Product product2 = new Product();
			product2.ProductName = "Çiğköfte";
			product2.Id = 2;
			product2.Expalnation = "Adıyaman";

			SepetManager sepetManager = new SepetManager();

			sepetManager.Add(product1);
			sepetManager.Add(product2);
			
			Product[] products = new Product[] {product1,product2};

			foreach (var item in products)
			{
				Console.WriteLine(item.ProductName);
				Console.WriteLine(item.Id);
				
			}


			PersonManager personManager = new PersonManager();

			Student student = new Student()
			{
				FirstName = "Ahmet",
				LastName = "Özdemir",
				Id = 1,

			};

			Teacher teacher = new Teacher()
			{
				 
				FirstName = "Ramazan",
				LastName = "Özdenir",
				Id = 2

			};



   //         personManager.Add(student);
   //         personManager.Add(teacher);
			//personManager.Add(student);

			Console.ReadLine();
        }

		//class Product
		//{
		//	public int Id { get; set; }
		//	public string ProductName { get; set; }

		//	public string Expalnation { get; set; }
		//	public int Price { get; set; }
		//}

		interface IPerson
		{
			string FirstName { get; set; }
			string LastName { get; set; }
			int Id { get; set; }	
		}

        class Student : IPerson
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Id { get; set; }
        }

        class Teacher : IPerson
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Id { get; set; }
        }

		class Personel : IPerson
		{
			public string FirstName { get; set; }
			public string LastName { get; set; }
			public int Id { get; set; }
		}

		class PersonManager
		{ 
		
		  public void Add( IPerson person)
			{
				Console.WriteLine(person.FirstName);
			}

		}

	}
}