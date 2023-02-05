using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static  void Main(string[] args) 
        {
            IWork[] work = new IWork[]
            {
                new Worker(),
                new Manager(),
                new Robot()

            };

            foreach (var workItem in work)
            {
                workItem.work();
               
            }
            Console.ReadLine();

            IEat[] eat = new IEat[]
            {
               new Worker(),
               new Manager()
            };

            foreach(var eatItem in eat) 
            {
                eatItem.eat();
            }

            IGetSalery[] getSalery = new IGetSalery[]
                {
                new Worker(),
                new Manager()
                };
            foreach (var getSaleryItem in getSalery)
            {
                getSaleryItem.salery();
            }


        }

        interface IEat
        {
            void eat ();
        }
        interface IWork
        {
            void work();
        }
        interface IGetSalery
        {
            void salery();
        }

        class Manager : IEat, IWork, IGetSalery
        {
            public void eat()
            {
                throw new NotImplementedException();
            }

            public void salery()
            {
                throw new NotImplementedException();
            }

            public void work()
            {
                Console.WriteLine("worked");
            }
        }
        class Worker : IEat, IWork, IGetSalery
        {
            public void eat()
            {
                throw new NotImplementedException();
            }

            public void salery()
            {
                throw new NotImplementedException();
            }

            public void work()
            {
                Console.WriteLine("worked");
            }
        }
        //SOLID : Iterface segregation

        class Robot : IWork
        {
            public void work()
            {
                Console.WriteLine("worked");
            }
        }
    }
}
