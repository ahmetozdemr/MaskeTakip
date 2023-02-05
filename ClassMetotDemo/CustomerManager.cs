using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Id: {0}, Musteri ismi: {1} ", customer.Id, customer.FirstName);
        }

        public void Update(Customer customer) {

            Console.WriteLine("{0} id numralı müşteri güncellenmiştir ", customer.Id);
        }
        public void Delete(Customer customer) {
            Console.WriteLine("{0} id numaralı müşeri silinmiştir.", customer.Id);
        }

        public void Get(params Customer[] customer) {


            foreach (var item in customer)
            {
                Console.WriteLine("Müşteri Listesi: {0} ", item.FirstName);
            }

            
        
        }

    }
}
