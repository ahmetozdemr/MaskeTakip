internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer = new Customer();
        Customer customer1 = new Customer();
        customer1 = customer;

        customer.Firstname = "Ramo";

        Console.WriteLine(customer1.Firstname); // Böyle olmasının sebebi claslar refererans mantığıyla çalışmaktadır.


        Person[] person = new Person[]
        {
            new Student {Firstname = "Ahmet"},
            new Customer {Firstname = " Ramazan"},
            new Person {Firstname = "Mahut"},
            new Customer {Departmant = " Yönetim"}
      
        };

        foreach (Person personItem in person) 
        
        { 
        Console.WriteLine(personItem.Firstname);
        }
    }

    interface IPerson
    {
        void Adress();
    }

    class Person2
    { }

    class Person: Person2
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }

    // base class ( temel sınıf) = Person 
    class Student : Person, IPerson
    {
        public void Adress()
        {
            throw new NotImplementedException();
        }
    }

    class Customer : Person 
    { 
      public string Departmant { get; set; }
    }
}