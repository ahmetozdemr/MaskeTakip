using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Customer
    {

        public int Id { get; set; }
        public string FirstName { get; set; }  
        public string LastName { get; set; }    = string.Empty; 
        public string City { get; set; } 
        public string Region { get; set; }  
    }
}
