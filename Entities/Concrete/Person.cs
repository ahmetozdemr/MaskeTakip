using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Person
    {
        private string _lastname;
        public string FirstName { get; set; } = "Mustafa";
        public string LastName {
            get { return "Mr." +_lastname; }

            set { _lastname = value; } 
        }
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }


    }
}