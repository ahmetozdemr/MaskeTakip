using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    // bir class oluşturulduğunda interface olması gerekiyor.
    // Hatta ilk başta interface oluşturulması gerekiyor.
    //interface içerisinde sadece metot imzası barındırabilirsin
    public interface IApplicantService
    {
        public void ApplyForMask(Person person);


        public List<Person> GetList();


        bool CheckPerson(Person person);

    }
        
}
