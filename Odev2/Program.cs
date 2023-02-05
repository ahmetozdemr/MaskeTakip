namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { ID = 1, Name = "Eray", Surname = "Güler", City = "İstanbul" };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Update(customer);
            Console.ReadLine();

        }
    }
}
class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
}
class CustomerManager
{
    public void Add(Customer customer)
    {
        Console.WriteLine(customer.ID + "-" + customer.Name + "-"
                         + customer.Surname + "-" + customer.City + " customer has been added.");
    }
    public void Update(Customer customer)
    {
        if (customer.City == "İstanbul")
        {
            Console.WriteLine("The customer has earned a new credit limit");
        }
        else
        {
            Console.WriteLine("The customer has standard credit limit.");
        }
    }

}