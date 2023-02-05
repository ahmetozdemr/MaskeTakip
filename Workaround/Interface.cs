using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    public class Interface
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Dwmiroğ",
                Adress = "Ankara"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Demiroğ",
                Department = "ComputerScience"
            };

            manager.Add(customer);
            manager.Add(student);
            Console.ReadLine();
        }
   
             
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Student : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    
    class Worker : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Department { get; set;}
    }

    class Customer : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Adress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
