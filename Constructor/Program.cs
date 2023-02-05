internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer = new Customer() { FirstName= "Ramazan", LastName = "Özdemir", id = 1, city = "Adıyaman" };

        Console.WriteLine(customer.FirstName);

        Customer customer1 = new Customer("Mustafa", "Özdemir", 8, "Adıyaman");
    }

  class  Customer
    {
        // default constructer
        public Customer() 
        {
        
        }   
        public Customer(string firstname, string lastname, int id, string city)
        {
            Console.WriteLine("Ahmet Özdemir");
            FirstName = firstname;
            Console.WriteLine(FirstName);
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public int id { get; set; }  
        public string city { get; set; }
    }
}