using ClassMetotDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer = new Customer() { Id = 1,FirstName="Ahmet",LastName="Özdemir",City="Adyaman",Region="Gerger"};

        Customer customer2 = new Customer() { Id = 1, FirstName = "Ramazan", LastName = "Özdemir", City = "Adyaman", Region = "Gergera" };
    
    CustomerManager manager = new CustomerManager();
        manager.Add(customer);
        manager.Add(customer2);
        manager.Delete(customer);
        manager.Update(customer);

        manager.Get(customer, customer2);

        Customer[] customers = new Customer[] { customer , customer2};

        foreach (var item in customers)
        {
            Console.WriteLine(  "Müşteri listesi tekrarı: {0} ", item.FirstName);     
        }
        Console.ReadKey();
    }

}