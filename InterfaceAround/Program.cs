using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAround
{
    public class Program
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
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

